

string nome, nickName, plataforma, nomeJogo = "", plataformaJogo= "", jogoProcurado, NomeMaior = "", maisJogado ="";
int ano, quantidadeJogos, indice = 0, totalHoras = 0, maiorHora=0;
double saldo, preco=0, totalGasto = 0, ValorMaior = 0;

string[] listaJogos;
bool jogoEncontrado = false;
double[] valorJogo;
int[] horasJogadas;

string[] novaListaJogos;
double[] novoValorJogo;
int[] novoHorasJogadas;



Console.WriteLine("=== CADASTRO DO CLIENTE ====");
Console.WriteLine("Nome:");
nome = Console.ReadLine();
Console.WriteLine("Nickname:");
nickName = Console.ReadLine();
Console.WriteLine("Plataforma (PC, PS5, Xbox ou Switch): ");
plataforma = Console.ReadLine();
Console.WriteLine("Cliente desde (Ano):");
ano = int.Parse(Console.ReadLine());
Console.WriteLine("Digite seu Saldo(R$):");
saldo = double.Parse(Console.ReadLine());
Console.WriteLine("=== FICHA DO CLIENTE ====");
Console.WriteLine($"Nome: {nome}");
Console.WriteLine($"Nickname: {nickName}");
Console.WriteLine($"Plataforma: {plataforma}");
Console.WriteLine($"Cliente desde: {ano}");
Console.WriteLine($"Saldo: R${saldo.ToString("F2")}");


Console.WriteLine("Nome do jogo: ");
nomeJogo = Console.ReadLine();
Console.WriteLine("Plataforma do jogo: ");
plataformaJogo = Console.ReadLine();
Console.WriteLine("Preço (R$):");
preco = int.Parse(Console.ReadLine());


if (plataforma.ToLower() == plataformaJogo.ToLower() && saldo >= preco)
{
    Console.WriteLine($"Pode comprar {nomeJogo}! Sobrariam {saldo - preco}");
}
else if (plataforma.ToLower() != plataformaJogo.ToLower() && saldo >= preco)
{
    Console.WriteLine($"{nomeJogo} é do {plataformaJogo}! Sua plataforma é {plataforma}");
}
else
{
    Console.WriteLine($"Saldo insuficiente faltam R${preco - saldo}");
}

Console.WriteLine("Quantos jogos você já tem? ");
quantidadeJogos = int.Parse(Console.ReadLine());
listaJogos = new string[quantidadeJogos];

for (int i = 0; i < quantidadeJogos; i++)
{
    Console.WriteLine($"Nome jogo {i + 1}:");
    listaJogos[i] = Console.ReadLine();

}
Console.WriteLine($"==== BIBLIOTECA DE {nickName.ToUpper()} ========");
for (int i = 0; i < listaJogos.Length; i++) { Console.WriteLine($"{i + 1} - {listaJogos[i]}"); }
Console.WriteLine($"Total de jogos: {listaJogos.Length}");

Console.WriteLine("Qual jogo você verificar?");
jogoProcurado = Console.ReadLine();

for (int i = 0; i < listaJogos.Length; i++)
{
    if (listaJogos[i].ToLower() == jogoProcurado.ToLower())
    {
        jogoEncontrado = true;
        Console.WriteLine($"Você já tem {jogoProcurado}! Não precisa comprar de novo.");
    }
}
if (jogoEncontrado == false)
{
    Console.WriteLine($"{jogoProcurado} não está na sua biblioteca");
}

valorJogo = new double[listaJogos.Length];

for (int i = 0; i < listaJogos.Length; i++)
{

    Console.WriteLine($"Quanto você pagou em {listaJogos[i]}");
    valorJogo[i] = double.Parse(Console.ReadLine());

    totalGasto += valorJogo[i];
}
Console.WriteLine($"Total gasto {totalGasto} ");

Console.WriteLine($"Média por compra {totalGasto / listaJogos.Length:F2}");

if (totalGasto > 500)
{

    Console.WriteLine("Status: Cliente VIP");

}
else

{
    Console.WriteLine($"Cliente comum. Faltam {500 - totalGasto + 1} para virar VIP");

}

for (int i = 0; i < valorJogo.Length; i++)
{

    if (valorJogo[i] >= ValorMaior) 
    {
        ValorMaior = valorJogo[i];
        NomeMaior = listaJogos[i];
        indice = i;
    }

}
Console.WriteLine($"Jogo mais caro: {NomeMaior} (R$ {ValorMaior}), no índice {indice}");

horasJogadas = new int[listaJogos.Length];
for (int i = 0; i < listaJogos.Length; i++)
{

    Console.WriteLine($"Quantas horas você jogou em {listaJogos[i]}?");
    horasJogadas[i] = int.Parse(Console.ReadLine());

    totalHoras += horasJogadas[i];
}
Console.WriteLine($"Total de horas: {totalHoras}h");
for (int i = 0; i < horasJogadas.Length;i++)
{
    if (horasJogadas[i] >= maiorHora)
    {
        maiorHora = horasJogadas[i];
        maisJogado = listaJogos[i];    
    }
}
Console.WriteLine($"Jogo mais jogado: {maisJogado} ({maiorHora}h)");
Console.WriteLine("Jogos encostados (0 horas):");
for (int i = 0; i < horasJogadas.Length; i++)
{
    if (horasJogadas[i] == 0)
    {
        Console.WriteLine($"- {listaJogos[i]}");
     
    }
}

Console.WriteLine("Nome do jogo: ");
nomeJogo = Console.ReadLine();
Console.WriteLine("Plataforma do jogo: ");
plataformaJogo = Console.ReadLine();
Console.WriteLine("Preço (R$):");
preco = int.Parse(Console.ReadLine());
jogoEncontrado = false;
jogoProcurado = nomeJogo;

for (int i = 0; i < listaJogos.Length; i++)
{
    if (listaJogos[i].ToLower() == jogoProcurado.ToLower())
    {
        jogoEncontrado = true; 
    }
}

if (plataforma.ToLower() == plataformaJogo.ToLower() && saldo >= preco && jogoEncontrado == false)
{
    novaListaJogos = new string[listaJogos.Length + 1];
    novoValorJogo = new double[valorJogo.Length + 1];
    novoHorasJogadas = new int[horasJogadas.Length + 1];

    for (int i = 0; i < listaJogos.Length; i++)
    {
        novaListaJogos[i] = listaJogos[i];
        novoValorJogo[i] = valorJogo[i];
        novoHorasJogadas[i] = horasJogadas[i];
    }

    novaListaJogos[novaListaJogos.Length -1] = nomeJogo;

    novoValorJogo[novoValorJogo.Length -1] = preco;

    novoHorasJogadas[novoHorasJogadas.Length -1 ] = 0;

    saldo -= preco;
    foreach (string jogo in novaListaJogos)
    {
        Console.WriteLine(jogo);
    }
    foreach (double valor in novoValorJogo)
    {
        Console.WriteLine(valor);
    }
    foreach (int hora in novoHorasJogadas)
    {
        Console.WriteLine(hora);
    }

    Console.WriteLine($"Compra aprovada! {nomeJogo}! adicionado a sua biblioteca");
}
else if (plataforma.ToLower() != plataformaJogo.ToLower() && saldo >= preco && jogoEncontrado == false)
{
    Console.WriteLine($"{nomeJogo} é do {plataformaJogo}! Sua plataforma é {plataforma}");
}
else if (plataforma.ToLower() == plataformaJogo.ToLower() && saldo < preco && jogoEncontrado == false)
{
    Console.WriteLine($"Saldo insuficiente faltam R${preco - saldo}");
}
else
{
    Console.WriteLine($"Você já tem {jogoProcurado}! Não precisa comprar de novo.");
}


