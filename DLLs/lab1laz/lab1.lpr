////Тябин Иван 903б
library lab1;
uses Classes;
//Сложение
function Addition(val1,val2: integer): integer; stdcall;
begin
  Result := val1 + val2;
end;

exports
  Addition;
begin
end.

