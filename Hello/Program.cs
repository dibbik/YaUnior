string s1 = "Каждый ";
string s2 = "охотник ";
string s3 = "желает ";
string s4 = "знать ";
string s5 = "где ";
string s6 = "сидит ";
string s7 = "фазан.";

Console.Write(s1);
Console.Write(s2);
Console.Write(s3);
Console.Write(s4);
Console.Write(s5);
Console.Write(s6);
Console.WriteLine(s7);

string conkastString = s1+s2+s3+s4+s5+s6+s7;
Console.WriteLine(conkastString);

string interpolatedString = $"{s1}{s2}{s3}{s4}{s5}{s6}{s7}";
Console.WriteLine(interpolatedString);