//Тябин Иван 903б
#include "pch.h"
#include "fstream"
#include "iostream"
#include <string>
using namespace std;

extern "C"
{
    //сложение
    __declspec(dllexport) int __stdcall AdditionC(int val1, int val2)
    {
        return val1 + val2;
    }

    //функция проверки TSV файла
    __declspec(dllexport) int __stdcall ReadTextFileC(const char* FileName)
    { 
        int count = 0;
        ifstream in(FileName);
        if (in.is_open())
        {
            string line;
            while (in >> line) ++count;
        }
        in.close();    
        cout << FileName;
        return count;
    }
}
