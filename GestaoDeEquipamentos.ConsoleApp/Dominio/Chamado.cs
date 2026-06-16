using System;

namespace GestaoDeEquipamentos.ConsoleApp.Dominio;

public class Chamado
{
    public int id;
    public string titulo;
    public string descricao;

    public DateTime dataAbertura;
    public Equipamentos equipamento;
}
