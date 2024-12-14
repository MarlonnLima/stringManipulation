// Guid
var id = Guid.NewGuid(); // Gera um Guid Aleatório
id = new Guid("4f269ad7-7e3d-4e3c-8cc1-0b49443af319");

var id2 = new Guid(); // Gera um guid composto de zeros porque apenas inicializou a classe;
Console.WriteLine(id);
Console.WriteLine(id2);

// Format
Console.WriteLine(string.Format("Guid: {0}", id));

// Compare
var texto = "Este é um texto de teste";
Console.WriteLine(texto.CompareTo("testando"));
Console.WriteLine(texto.Contains("testando"));
Console.WriteLine(texto.Contains("Testando", StringComparison.OrdinalIgnoreCase));

// Equals

Console.WriteLine(texto.Equals("testando"));

// Index

Console.WriteLine(texto.IndexOf(" t "));
Console.WriteLine(texto.LastIndexOf("t"));

// Case Methods
Console.WriteLine(texto.ToUpper());
Console.WriteLine(texto.ToLower());
Console.WriteLine(texto.Insert(5, " AQUI "));
Console.WriteLine(texto.Remove(5, 3));
Console.WriteLine(texto.Length);


// Replace
Console.WriteLine(texto.Replace("ando", "ado"));

var divisao = texto.Split(" ");
Console.WriteLine(divisao[0]);
Console.WriteLine(divisao[1]);
Console.WriteLine(divisao[2]);
Console.WriteLine(divisao[3]);
Console.WriteLine(divisao[4]);
Console.WriteLine(divisao[5]);
Console.WriteLine(texto.Substring(0, 5));
Console.WriteLine(texto.Trim());