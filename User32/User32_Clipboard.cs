﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace TOAPI.User32
{
    public partial class User32
    {
        [DllImportAttribute("user32.dll", EntryPoint = "SetClipboardViewer")]
        public static extern IntPtr SetClipboardViewer([In] IntPtr hWndNewViewer);

        [DllImportAttribute("user32.dll", EntryPoint = "ChangeClipboardChain")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool ChangeClipboardChain([In] IntPtr hWndRemove, [In] IntPtr hWndNewNext);

    }
}
