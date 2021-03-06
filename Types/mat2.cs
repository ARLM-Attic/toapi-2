﻿using System;
using System.Runtime.InteropServices;

namespace TOAPI.Types
{
    [StructLayout(LayoutKind.Sequential)]
    public class MAT2
    {
        public FIXED eM11;
        public FIXED eM12;
        public FIXED eM21;
        public FIXED eM22;

        public MAT2()
        {
            eM11.val = 1;
            eM11.fract = 0;

            eM12.val = 0;
            eM12.fract = 0;

            eM21.val = 0;
            eM21.fract = 0;

            eM22.val = 1;
            eM22.fract = 0;
        }
    }
}
