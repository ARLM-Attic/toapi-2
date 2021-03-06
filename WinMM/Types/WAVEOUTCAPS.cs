﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace TOAPI.WinMM
{
    [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct WAVEOUTCAPSW
    {
        public ushort wMid;
        public ushort wPid;
        public uint vDriverVersion;

        /// WCHAR[32]
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szPname;
        public uint dwFormats;
        public ushort wChannels;
        public ushort wReserved1;
        public uint dwSupport;
    }

    [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct WAVEOUTCAPSA
    {
        public ushort wMid;
        public ushort wPid;
        public uint vDriverVersion;

        /// CHAR[32]
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szPname;
        public uint dwFormats;
        public ushort wChannels;
        public ushort wReserved1;
        public uint dwSupport;
    }

}
