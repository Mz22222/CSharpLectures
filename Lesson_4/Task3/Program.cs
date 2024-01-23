/*
Считать с консоли строку, состоящую из цифр и латинских букв.
Сформировать новую строку, состояющую из букв исходной строки.

Этапы: 
1. Ввод строки 
2. Проход по элементам строки 
3. Проверка элемента: является ли он буквой 
4. Дописать подходящий элемент к новой строке
*/

string GetLettersFromString(string s)
{
    string letters = "";
    foreach (char e in s)
    {
        if (char.IsAsciiLetter(e) == true)// этот метод проверяет является ли переданный символ буквенным (находится ли он в таблице ASCI)
        {
            letters = letters + e;// оператор конкатенации (обычно это +)
        }
    }
    return letters;
}

string str = Console.ReadLine();
string result = GetLettersFromString(str);
Console.WriteLine(result);
