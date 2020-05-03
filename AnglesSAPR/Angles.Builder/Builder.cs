using System;
using System.Runtime.InteropServices;
using Angles.Model;
using Kompas6API5;
using Kompas6Constants3D;

namespace Angles.KompasWrapper
{
    public class Builder
    {
        #region Private fields

        /// <summary>
        ///     Хранит ссылку на экземпляр Компас 3Д
        /// </summary>
        private KompasObject _kompasObject;

        #endregion

        #region Public methods

        /// <summary>
        ///     Запуск KOMPAS
        /// </summary>
        public void StartKompas()
        {
            if (_kompasObject == null)
            {
                var kompasType = Type.GetTypeFromProgID("KOMPAS.Application.5");
                _kompasObject = (KompasObject) Activator.CreateInstance(kompasType);
            }

            if (_kompasObject != null)
            {
                var retry = true;
                short tried = 0;
                while (retry)
                {
                    try
                    {
                        tried++;
                        _kompasObject.Visible = true;
                        retry = false;
                    }
                    catch (COMException)
                    {
                        var kompasType = Type.GetTypeFromProgID("KOMPAS.Application.5");
                        _kompasObject =
                            (KompasObject) Activator.CreateInstance(kompasType);

                        if (tried > 3)
                        {
                            retry = false;
                        }
                    }
                }

                _kompasObject.ActivateControllerAPI();
            }
        }

        /// <summary>
        ///     Построение уголка
        /// </summary>
        /// <param name="planeXY">Плоскость #1</param>
        /// <param name="planeYZ">Плоскость #2</param>
        public void Build(PlaneParameters planeXY, PlaneParameters planeYZ)
        {
            ksDocument3D document3D = _kompasObject.Document3D();
            document3D.Create();

            ksPart part = document3D.GetPart((short) Part_Type.pTop_Part);

            ksEntity planeXOY = part.GetDefaultEntity((short) Obj3dType.o3d_planeXOY);
            BuildPlane(part, planeXOY, planeXY.Height + planeXY.Thickness,
                planeXY.Width, planeXY.Thickness);

            BuildHole(part, planeXOY, planeXY.Width / 2,
                planeXY.Length + planeXY.Thickness,
                planeXY.Diameter / 2,
                planeXY.Thickness, planeXY.NumberOfHoles,
                planeXY.DistanceBetweenHoles);


            ksEntity planeYOZ = part.GetDefaultEntity((short) Obj3dType.o3d_planeXOZ);
            BuildPlane(part, planeYOZ, planeYZ.Height, planeYZ.Width,
                planeYZ.Thickness);

            BuildHole(part, planeYOZ, planeYZ.Width / 2, planeYZ.Length,
                planeYZ.Diameter / 2, planeYZ.Thickness,
                planeYZ.NumberOfHoles, planeYZ.DistanceBetweenHoles);
        }

        /// <summary>
        ///     Построение одной плоскости
        /// </summary>
        /// <param name="part"></param>
        /// <param name="plane"></param>
        /// <param name="height"></param>
        /// <param name="width"></param>
        /// <param name="thickness"></param>
        private void BuildPlane(ksPart part, ksEntity plane, double height, double width,
            double thickness)
        {
            ksEntity sketch = part.NewEntity((short) Obj3dType.o3d_sketch);
            ksSketchDefinition sketchDefinition = sketch.GetDefinition();
            sketchDefinition.SetPlane(plane);
            sketch.Create();

            // Входим в режим редактирования эскиза
            ksDocument2D document2D = sketchDefinition.BeginEdit();
            document2D.ksLineSeg(0, 0, 0, height, 1);
            document2D.ksLineSeg(0, height, width, height, 1);
            document2D.ksLineSeg(width, height, width, 0, 1);
            document2D.ksLineSeg(width, 0, 0, 0, 1);
            sketchDefinition.EndEdit();

            ///Выдавливание
            ksEntity extrude = part.NewEntity((short) Obj3dType.o3d_bossExtrusion);
            ksBossExtrusionDefinition extrudeDefinition = extrude.GetDefinition();
            extrudeDefinition.directionType = (short) Direction_Type.dtNormal;
            extrudeDefinition.SetSketch(sketch);
            ksExtrusionParam extrudeParam = extrudeDefinition.ExtrusionParam();
            extrudeParam.depthNormal = thickness;
            extrude.Create();
        }

        /// <summary>
        ///     Построение отверстий в плоскости
        /// </summary>
        /// <param name="part"></param>
        /// <param name="plane"></param>
        /// <param name="xc"></param>
        /// <param name="yc"></param>
        /// <param name="rad"></param>
        /// <param name="thickness"></param>
        /// <param name="numberOfHoles"></param>
        /// <param name="distance"></param>
        private void BuildHole(ksPart part, ksEntity plane, double xc, double yc,
            double rad, double thickness, int numberOfHoles, double distance)
        {
            ksEntity sketch = part.NewEntity((short) Obj3dType.o3d_sketch);
            ksSketchDefinition sketchDefinition = sketch.GetDefinition();
            sketchDefinition.SetPlane(plane);
            sketch.Create();

            // Входим в режим редактирования эскиза
            ksDocument2D document2D = sketchDefinition.BeginEdit();
            for (var i = 0; i < numberOfHoles; i++)
            {
                document2D.ksCircle(xc, yc, rad, 1);
                yc += distance;
            }

            sketchDefinition.EndEdit();

            ///Выдавливание
            ksEntity extrude = part.NewEntity((short) Obj3dType.o3d_cutExtrusion);
            ksCutExtrusionDefinition extrudeDefinition = extrude.GetDefinition();
            extrudeDefinition.directionType = (short) Direction_Type.dtReverse;
            extrudeDefinition.SetSketch(sketch);
            ksExtrusionParam extrudeParam = extrudeDefinition.ExtrusionParam();
            extrudeParam.depthReverse = thickness;
            extrude.Create();
        }

        #endregion
    }
}