String acessoP, senha;
const string senhacorreta  = "thi123";

Console.Write("Olá, usuário. Por favor, digite sua senha:");
senha = Console.ReadLine()!;

acessoP = senha == senhacorreta ? "permitido" : "negado";

Console.WriteLine($"Acesso { acessoP }");