using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;

namespace UsingDLLOnWF
{
    class Dll1ExportedFunctions
    {
        public static string HomeDir = @"E:\Projects\Nikiforof\";
        public static string VKIDir = @"G:\Nikiforof\";
        public static string pathToDLLC = @"UsingDLLOnWinForms\UsingDLLOnWF\x64\Debug\Lab1C.dll";
        public static string pathToDLLLaz = @"DLLs\lab1laz\project1.dll";
        public static string mainPath;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate int Addition(int val1, int val2);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate int ReadTextFile([MarshalAs(UnmanagedType.LPWStr)] string FileName, [MarshalAs(UnmanagedType.BStr)] out string Text, out int Count);

        public static object InitFromLibrary(string LibPath, string ProcName, Type type)
        {
            File.Exists(LibPath);
            IntPtr pDll = NativeMethods.LoadLibrary(LibPath);
            if (IntPtr.Zero == pDll) { return null; }

            IntPtr pAddressOfFunctionToCall = NativeMethods.GetProcAddress(pDll, ProcName);
            if (IntPtr.Zero == pAddressOfFunctionToCall) { return null; }

            Object procedure = Marshal.GetDelegateForFunctionPointer
            (
            pAddressOfFunctionToCall,
            type
            );
            return procedure;
        }
    }
}
