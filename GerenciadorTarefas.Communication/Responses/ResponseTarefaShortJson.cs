using GerenciadorTarefas.Communication.Enum;

namespace GerenciadorTarefas.Communication.Responses;
public class ResponseTarefaShortJson
{
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public DateTime DateLimit { get; set; }
    public StatusType Status { get; set; }
}
