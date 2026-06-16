using GestaoDeEquipamentos.ConsoleApp.Dominio;

namespace GestaoDeEquipamentos.ConsoleApp.Infraestutura;

public class RepositorioEquipamento
{
    public int contadorIdsEquipamentos = 1;
    public Equipamentos[] equipamentosSalvos = new Equipamentos[100];

    public void Cadastrar(Equipamentos novoEquipamento)
    {
        novoEquipamento.id = contadorIdsEquipamentos++;

        for (int i = 0; i < equipamentosSalvos.Length; i++)
        {
            if (equipamentosSalvos[i] == null)
            {
                equipamentosSalvos[i] = novoEquipamento;
                break;
            }
        }
    }

    public void Editar(int idSelecionado, Equipamentos equipamentoAtualizado)
    {
        for (int i = 0; i < equipamentosSalvos.Length; i++)
        {
            Equipamentos equipamentoSelecionado = equipamentosSalvos[i];

            if (equipamentosSalvos == null)
                continue;

            if (equipamentoSelecionado.id == idSelecionado)
            {
                equipamentoSelecionado.nome = equipamentoAtualizado.nome;
                equipamentoSelecionado.precoAquisicao = equipamentoAtualizado.precoAquisicao;
                equipamentoSelecionado.dataFabricacao = equipamentoAtualizado.dataFabricacao;
                break;
            }

        }
    }

    public void Excluir(int idSelecionado)
    {
        for (int i = 0; i < equipamentosSalvos.Length; i++)
        {
            Equipamentos equipamentoSelecionado = equipamentosSalvos[i];

            if (equipamentoSelecionado == null)
                continue;
            if (equipamentoSelecionado.id == idSelecionado)
            {
                equipamentosSalvos[i] = null;
                break;
            }

        }
    }
    public Equipamentos[] SelecionarTodos()
    {
        return equipamentosSalvos;
    }
}