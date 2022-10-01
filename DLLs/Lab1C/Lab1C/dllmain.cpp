//Тябин Иван 903б
#include "pch.h"
#include "fstream"
#include "iostream"
#include <string>
#include <vector>
#include <WTypes.h>
#include <comutil.h>
#include <comdef.h>
using namespace std;

//подсчет элементов
static int CountElems(string line) {
    int Count = 0;
    int i = 0;
    while (i < line.length()) {
        while (line[i] != '\t' && i < line.length())
            ++i;
        Count++;
        i++;
    }
    return Count;
}

extern "C" {
    //сложение
    __declspec(dllexport) int __stdcall Addition(int val1, int val2)
    {
        return val1 + val2;
    }

    //функция подсчета элементов в строке .tsv
    __declspec(dllexport) int __stdcall ReadTextFile(LPCWSTR FileName, BSTR* Text, int& Count)
    {
        Count = 0;
        *Text = _com_util::ConvertStringToBSTR("");;
        string TextTemp = "";
        ifstream file(FileName);
        if (file.is_open())
        {
            string line;
            getline(file, line);
            TextTemp += (line + '\n');
            int CountFirst = CountElems(line);
            if (CountFirst < 2) return -1;
            while (getline(file, line))
            {
                if (CountElems(line) == CountFirst)
                {
                    TextTemp += (line + '\n');
                    Count++;
                }
            }
        }
        else return -1;
        file.close();
        const char* temp = TextTemp.c_str();
        *Text = _com_util::ConvertStringToBSTR(temp);

        return Count > 0 ? 0 : -1;
    }
}
