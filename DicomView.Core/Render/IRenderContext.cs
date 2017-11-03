﻿using DicomPanel.Core.Utilities;
using DicomPanel.Core.Utilities.RTMath;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DicomPanel.Core.Render
{
    public interface IRenderContext
    {
        int Width { get; set; }
        int Height { get; set; }
        double RelativeScale { get; set; }

        void BeginRender();
        void DrawRect(double x0, double y0, double x1, double y1, DicomColor color);
        void DrawLine(double x0, double y0, double x1, double y1, DicomColor color);
        void DrawEllipse(double x0, double y0, double radiusX, double radiusY, DicomColor color);
        void DrawString(string text, double x, double y, double size, DicomColor color);
        void EndRender();
        void FillRect(double x0, double y0, double x1, double y1, DicomColor fill, DicomColor stroke);
        void FillPixels(byte[] byteArray, Rectd destRect);
    }
}
