try
{
    string[] linhas = File.ReadAllLines("Arquivos/arquivosLeitura.txt");

foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
} catch (Exception ex)
{
    Console.WriteLine($"Ocorreu um erro. {ex.Message}");
}

