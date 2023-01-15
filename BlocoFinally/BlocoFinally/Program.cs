//fechar um arquivo ou conexão de banco de dados ao final do processamento.

FileStream fs = null;
try
{
    fs = new FileStream(@"C:\temp\data.txt", FileMode.Open);
    StreamReader sr = new StreamReader(fs);
    string line = sr.ReadLine();
    Console.WriteLine(line);
}
catch (FileNotFoundException e)
{
    Console.WriteLine(e.Message);
}
catch (DirectoryNotFoundException i)
{
    Console.WriteLine("Diretorio nao encontrado"+i.Message);
}
finally
{
    if (fs != null)
    {
        fs.Close();
    }
}