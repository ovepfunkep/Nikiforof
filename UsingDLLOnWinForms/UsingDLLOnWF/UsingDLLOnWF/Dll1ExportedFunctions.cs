using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;

namespace UsingDLLOnWF
{
    class Dll1ExportedFunctions
    {
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate int AdditionC(int val1, int val2);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate int ReadTextFile(string FilePath);

        public static object InitFromLibrary(string LibPath, string ProcName)
        {
            //IntPtr pDll = NativeMethods.LoadLibraryW(LibPath);
            IntPtr pDll = NativeMethods.LoadLibraryW(@"G:\Nikiforof\DLLs\Lab1C\x64\Debug\Lab1C.dll");
            if (IntPtr.Zero == pDll) { return null; }

            IntPtr pAddressOfFunctionToCall = NativeMethods.GetProcAddress(pDll, ProcName);
            if (IntPtr.Zero == pAddressOfFunctionToCall) { return null; }

            Object procedure = Marshal.GetDelegateForFunctionPointer
            (
            pAddressOfFunctionToCall,
            typeof(AdditionC)
            );
            return procedure;
        }
    }
}
