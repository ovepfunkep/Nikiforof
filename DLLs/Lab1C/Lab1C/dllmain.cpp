//Тябин Иван 903б
#include "pch.h"
#include "fstream"
#include "iostream"
#include <string>
#include <vector>
#include <WTypes.h>
using namespace std;

extern "C"
{
    //сложение
    __declspec(dllexport) int __stdcall AdditionC(int val1, int val2)
    {
        return val1 + val2;
    }

    //функция проверки TSV файла
    __declspec(dllexport) int __stdcall ReadTextFileC(LPCWSTR FileName, BSTR Text, int Count)
    { 
        Count = 0;
        ifstream in(FileName);
        if (in.is_open())
        {
            string line;
            while (in >> line)
            {
                Count++;
            }
        }
        else return -1;
        in.close();

        return Count > 0 ? 0 : -1;
    }
}
