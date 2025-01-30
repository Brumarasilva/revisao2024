


//solicitar a quantidade de caracteres
Console.WriteLine("insira a quantidade de caracteres: ");
int quant = int.Parse(Console.ReadLine());

//Perguntar ao usário se irá conter letras
Console.WriteLine("a senha irá conter letras? (S/N) ");
string letra = Console.ReadLine();

//Perguntar ao usuário se irá conter números
Console.WriteLine("A senha irá conter Números? (S/N) ");
string numeros = Console.ReadLine();

//Perguntar ao usuário se vai ter caractere especial
Console.WriteLine("a senha irá conter caractere especial? (S/N) ");
string CaractEspecial = Console.ReadLine();





string[] alfabeto = new string[]
{
    "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o",
            "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z",
            "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O",
            "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"

};

string[] num = new string[]
{

    "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"

};

string[] caracteresEspeciais = new string[]
{

    "!", "@", "#", "$", "%", "^", "&", "*", "(", ")"

};

string senha = "";

Random random = new Random();

string[] caracteresPossiveis = new string[0];

if (letra == "S")
{
    caracteresPossiveis = caracteresPossiveis.Concat(alfabeto).ToArray();
}

if (numeros == "S")
{
    caracteresPossiveis = caracteresPossiveis.Concat(num).ToArray();
}

if (CaractEspecial == "S")
{
    caracteresPossiveis = caracteresPossiveis.Concat(caracteresEspeciais).ToArray();
}


for (int i = 1; i <= quant; i++)

{
    int indicealeatorio = random.Next(caracteresPossiveis.Length);
    senha += caracteresPossiveis[indicealeatorio];

}


Console.WriteLine("Senha Aleatória: " + senha);




