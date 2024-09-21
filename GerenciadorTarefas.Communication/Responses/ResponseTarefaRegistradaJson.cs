using GerenciadorTarefas.Communication.Enum;

namespace GerenciadorTarefas.Communication.Responses;
public class ResponseTarefaRegistradaJson
{
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;
}
