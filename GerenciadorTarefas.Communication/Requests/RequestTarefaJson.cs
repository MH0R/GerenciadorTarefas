using GerenciadorTarefas.Communication.Enum;

namespace GerenciadorTarefas.Communication.Requests;
public class RequestTarefaJson
{
    public string Name { get; set; } = String.Empty;
    public string Description { get; set; } = String.Empty;
    public DateTime DateLimit { get; set; }
    public PriorityType Priority { get; set; }
    public StatusType Status { get; set; }
}
