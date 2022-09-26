//Тябин Иван 903б
#include "pch.h"
#include "WTypes.h"
#include "fstream"
#include "oleauto.h"
#include "comutil.h"
#include "chstring.h"
#include "string.h"
#include "comdef.h"
using namespace std;
using namespace _com_util;

BOOL APIENTRY DllMain( HMODULE hModule,
                       DWORD  ul_reason_for_call,
                       LPVOID lpReserved
                     )
{
    switch (ul_reason_for_call)
    {
    case DLL_PROCESS_ATTACH:
    case DLL_THREAD_ATTACH:
    case DLL_THREAD_DETACH:
    case DLL_PROCESS_DETACH:
        break;
    }
    return TRUE;
}

extern "C"
{
    //сложение
    __declspec(dllexport) int __stdcall AdditionC(int val1, int val2)
    {
        return val1 + val2;
    }

    //функция проверки TSV файла
    __declspec(dllexport) int __stdcall ReadTextFile(string FileName)
    { 
        return 0;
    }
}
