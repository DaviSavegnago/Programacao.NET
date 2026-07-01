using ControleEquipamentos.Models;

namespace ControleEquipamentos.Services
{
    public class ArquivoEquipamento
    {
        private readonly string caminho = "equipamentos.txt";

        public List<Equipamento> LerTodos()
{
    List<Equipamento> lista = new List<Equipamento>();

    if (!File.Exists(caminho))
    {
        File.Create(caminho).Close();
        return lista;
    }

    string[] linhas = File.ReadAllLines(caminho);

    foreach (string linha in linhas)
    {
        if (string.IsNullOrWhiteSpace(linha))
            continue;

        string[] dados = linha.Split(';');

        Equipamento equipamento = new Equipamento();

        equipamento.Codigo = int.Parse(dados[0]);
        equipamento.Nome = dados[1];
        equipamento.Patrimonio = dados[2];
        equipamento.Email = dados[3];
        equipamento.Situacao = Enum.Parse<SituacaoEquipamento>(dados[4]);

        lista.Add(equipamento);
    }

    return lista;
}

    public bool Salvar(Equipamento equipamento)
{
    List<Equipamento> lista = LerTodos();

    foreach (Equipamento e in lista)
    {
        if (e.Codigo == equipamento.Codigo)
        {
            return false;
        }
    }

    string linha = $"{equipamento.Codigo};{equipamento.Nome};{equipamento.Patrimonio};{equipamento.Email};{equipamento.Situacao}";

    File.AppendAllText(caminho, linha + Environment.NewLine);

    return true;
}

    public Equipamento? BuscarPorCodigo(int codigo)
{
    List<Equipamento> lista = LerTodos();

    foreach (Equipamento equipamento in lista)
    {
        if (equipamento.Codigo == codigo)
        {
            return equipamento;
        }
    }

    return null;
}

    public void Excluir(int codigo)
{
    List<Equipamento> lista = LerTodos();

    lista.RemoveAll(e => e.Codigo == codigo);

    List<string> linhas = new List<string>();

    foreach (Equipamento equipamento in lista)
    {
        linhas.Add($"{equipamento.Codigo};{equipamento.Nome};{equipamento.Patrimonio};{equipamento.Email};{equipamento.Situacao}");
    }

    File.WriteAllLines(caminho, linhas);
}

    }
}

