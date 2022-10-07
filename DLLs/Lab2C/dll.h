#ifndef _DLL_H_
#define _DLL_H_
#include "fstream"
#include "iostream"
#include <string.h>
#include <vector>
#include <WTypes.h>
#include <comutil.h>
#include <comdef.h>
using namespace std;

#if BUILDING_DLL
#define DLLIMPORT __declspec(dllexport)
#else
#define DLLIMPORT __declspec(dllimport)
#endif

class DLLIMPORT DllClass
{
	public:
		DllClass();
		virtual ~DllClass();
		void HelloWorld();
};

#endif


extern "C" {
    __declspec(dllexport) int __stdcall Addition_Debug(int val1, int val2)
    {
        return val1 + val2;
    }

    __declspec(dllexport) int __stdcall ReadTextFile(LPCWSTR FileName, BSTR* Text, int& Count)
    {
        Count = 0;
        *Text = _com_util::ConvertStringToBSTR("");;
    	string TextTemp = "";
    	//string FFileName = FileName;
    	/*
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
/**/
        return Count > 0 ? 0 : -1;
    }
}
