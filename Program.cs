using TesteFioTecBiblioteca.Services;

string connectionString = "Data Source=myServerAddress;Initial Catalog=myDataBase;User ID=myUsername;Password=myPassword";
string palavrasFile = "Palavras.txt";
string emailMessagesTable = "EmailMessages";
string palavrasChaveTable = "PalavrasChave";
double minFrequency = 0.05;

// Carrega palavras do dicionário
HashSet<string> dicionario = new HashSet<string>(File.ReadAllLines(palavrasFile), StringComparer.OrdinalIgnoreCase);

DicionarioServices dicionarioService = new DicionarioServices();

dicionarioService.VerificarPalavra();


