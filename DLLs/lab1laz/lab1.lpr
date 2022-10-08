////Тябин Иван 903б
library lab1;
uses Classes, SysUtils;

//Сложение
function Addition(val1,val2: integer): integer; stdcall;
begin
  Result := val1 + val2;
end;

//Функция считает сколько переменных имеет TSV таблица
function CountValue(str: string): integer; stdcall;
var countval,i: integer;
begin
  countval:=0;

  for i:=1 to length(str) do
  begin
    if (str[i] <> ' ') then
    begin
      if (str[i+1] = ' ') then
      begin
        countval:=countval + 1;
      end;
    end;
  end;

  if (str[length(str)] <> ' ') then
  begin
    countval:=countval + 1;
  end;

  Result:=countval;
end;

//Функция чтения TSV файла, вывод строк в которых получилось прочитать все значения
//Возвращает 0 при удачной попытке чтения
function ReadTextFile(FileName: PWideChar; out Text: WideString; out Count: integer): integer; stdcall;
var
  SL: TStringList;
  counter: integer;
  counterAll: integer;
  sAll: string;
  i: integer;

begin
  SL:=TStringList.Create;
  SL.LoadFromFile(FileName);

  counterAll:=CountValue(SL[0]);
  sAll:='';
  Count:=0;

  for i:=1 to SL.Count-1 do
  begin
    counter:=CountValue(SL[i]);
    if (counter = counterAll) then
    begin
      sAll:=sAll + #13#10 + SL[i];
      Count:=Count + 1;
    end;
  end;

  Text:=WideString(sAll);
  FreeAndNil(SL);

  Writeln();
  Result:=0;
end;

exports
  Addition,
  ReadTextFile;
begin
end.

