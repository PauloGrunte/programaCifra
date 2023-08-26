/*Cada consoante deve ser substituída por exatamente três letras, na seguinte ordem:
1 a própria consoante (vamos chamar de consoante original);
2 a vogal mais próxima da consoante original no alfabeto, com a regra adicional de que se a consoante original está à mesma distância 
de duas vogais, então a vogal mais próxima do início do alfabeto é usada. Por exemplo, se a consoante original é d, a vogal que deve ser 
usada é e, pois esta é a vogal mais próxima; se a consoante original é c, a vogal que deve ser utilizada é a, porque c está à mesma 
distância de a e e, e a é mais próxima do início do alfabeto.
3 A consoante que segue a consoante original, na ordem do início ao fim do alfabeto. Por exemplo, se a consoante original é d, a consoante 
a ser utilizada é f. No caso de a consoante original ser z, deve ser utilizada a própria letra z.*/
using System.Collections;

Console.WriteLine("Cifra da Nlogônia");
Console.WriteLine("Digite a palavra para ser coficada");
string inpt = Console.ReadLine().ToLower();
Char[] Pchar = inpt.ToCharArray();
string Pstring;
int x = Pchar.Length;
ArrayList saida = new ArrayList();
string imprimirConsole = "";
/*A b c d E f g h I j k l m n O p q r s t U v x z
e as vogais são
a e i o u /*/
for (int i = 0; i < x; i++)
{
 
    Pstring = char.ToString(Pchar[i]);
    if (Pstring == "a" || Pstring == "e" || Pstring == "i" || Pstring == "o" || Pstring == "u" )
    {
        saida.Add(Pstring);
    }
    else
    {
       switch (Pstring)
        {
            case "b":
                saida.Add("bac");
                break;
            case "c":
                saida.Add("cad");
                break;
            case "d":
                saida.Add("def");
                break;
            case "f":
                saida.Add("feg");
                break;
            case "g":
                saida.Add("geh");
                break;
            case "h":
                saida.Add("hij");
                break;
            case "j":
                saida.Add("jik");
                break;
            case "k":
                saida.Add("kil");
                break;
            case "l":
                saida.Add("lim");
                break;
            case "m":
                saida.Add("mon");
                break;
            case "n":
                saida.Add("nop");
                break;
            case "p":
                saida.Add("poq");
                break;
            case "q":
                saida.Add("qor");
                break;
            case "r":
                saida.Add("ros");
                break;
            case "s":
                saida.Add("sut");
                break;
            case "t":
                saida.Add("tuv");
                break;
            case "v":
                saida.Add("vux");
                break;
            case "x":
                saida.Add("xax");
                break;
            case "z":
                saida.Add("zab");
                break;
        }
    }
}
for (int y = 0;  y < saida.Count ; y++)
{
    imprimirConsole += saida[y];
}
Console.WriteLine(imprimirConsole);
