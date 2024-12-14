// Guid
var id = Guid.NewGuid(); // Gera um Guid Aleatório
id = new Guid("4f269ad7-7e3d-4e3c-8cc1-0b49443af319");

var id2 = new Guid(); // Gera um guid composto de zeros porque apenas inicializou a classe;
Console.WriteLine(id);
Console.WriteLine(id2);

// Format
Console.WriteLine(string.Format("Guid: {0}", id));

// Compare
var texto = "testando";
Console.WriteLine(texto.CompareTo("testando"));
Console.WriteLine(texto.Contains("testando"));
Console.WriteLine(texto.Contains("Testando", StringComparison.OrdinalIgnoreCase));

// Equals

Console.WriteLine(texto.Equals("testando"));
