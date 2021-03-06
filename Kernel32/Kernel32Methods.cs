using System;
using System.Runtime.InteropServices;
//using System.Runtime.InteropServices.ComTypes;  // For FILETIME

namespace TOAPI.Kernel32
{

    public partial class Kernel32
    {
        // Generic across many sub-systems
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseHandle(IntPtr hObject);


        // NUMA Support
        // GetNumaAvailableMemoryNode
        // GetNumaHighestNodeNumber
        // GetNumaNodeProcessorMask
        // GetNumaProcessorNode



        // Job Objects
        // AssignProcessToJobObject
        // CreateJobObject
        // IsProcessInJob
        // OpenJobObject
        // QueryInformaitonJobObject
        // SetInformationJobObject
        // TerminateJobObject
        // UserHandleGrantAccess

        [DllImport("kernel32.dll", EntryPoint = "FormatMessageW")]
        public static extern uint FormatMessageW(int dwFlags, IntPtr lpSource, int dwMessageId, int dwLanguageId, 
            [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpBuffer, int nSize, ref IntPtr Arguments);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Int32 FormatMessage(Int32 dwFlags, ref Int64 lpSource, Int32 dwMessageId, Int32 dwLanguageZId, String lpBuffer, Int32 nSize, Int32 Arguments);        


        [DllImport("kernel32.dll")]
        public extern static uint GetLastError();


        [DllImport("kernel32.dll")]
        public static extern uint WTSGetActiveConsoleSessionId();


    }
}
