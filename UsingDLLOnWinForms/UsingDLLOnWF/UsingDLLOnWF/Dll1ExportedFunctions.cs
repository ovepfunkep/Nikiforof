using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;

namespace UsingDLLOnWF
{
    class Dll1ExportedFunctions
    {
        public static string pathToDLLC = @"E:\Projects\Nikiforof\UsingDLLOnWinForms\UsingDLLOnWF\x64\Debug\Lab1C.dll";
        public static string pathToDLLLaz = @"E:\Projects\Nikiforof\UsingDLLOnWinForms\UsingDLLOnWF\x64\Debug\Lab1C.dll";
        public static string mainPath;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate int AdditionC(int val1, int val2);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate int ReadTextFileC(string FilePath);

        public static object InitFromLibrary(string LibPath, string ProcName, Type type)
        {
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
