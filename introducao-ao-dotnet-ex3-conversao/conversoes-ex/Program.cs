// See https://aka.ms/new-console-template for more information

//Conversão Implícita 
int a = 10;
long b = a;
Console.WriteLine(a);

//Conversão Explícita (Cast) 
double c = 10.555;
Console.WriteLine(c);
int d = (int) c;
Console.WriteLine(d);

//Convert Class = que precisam de uma class para realizar a conversão
string inteiroPossivel = "1234";
int cont = Convert.ToInt32(inteiroPossivel);
Console.WriteLine(cont);

//TryParse = Converter um tipo para outro
int numero = 0;
string numeroString = "1234";
Console.WriteLine(int.TryParse(numeroString, out
numero));
Console.WriteLine(numero);

// Acabei concatenando depois dei uma espiada na resposta e minha logica tava certa. 
Console.WriteLine("Digite um número:");
string a = Console.ReadLine();
Console.WriteLine("Digite mais um número:");
string b = Console.ReadLine();
int c = Convert.ToInt32(a) + Convert.ToInt32(b);
//int c = a + b;
Console.WriteLine(c);

//Conversão de tipos, entrada de dados e soma
string a = Console.ReadLine();
string b = Console.ReadLine();
int aConvertido, bConvertido;
int.TryParse(a, out aConvertido);
int.TryParse(b, out bConvertido);
int c = aConvertido + bConvertido;
Console.WriteLine(c);