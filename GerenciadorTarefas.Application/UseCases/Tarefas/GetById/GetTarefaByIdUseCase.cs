using GerenciadorTarefas.Communication.Responses;

namespace GerenciadorTarefas.Application.UseCases.Tarefas.GetById;
public class GetTarefaByIdUseCase
{
    public ResponseTarefa Execute(int id)
    {
        return new ResponseTarefa
        {
            Id = id,
            Name = "Lavar a Louça",
            DateLimit = DateTime.Now,
            Description = "Lavar a louça pra mulher não ficar brava",
            Priority = Communication.Enum.PriorityType.Alta,
            Status = Communication.Enum.StatusType.Aguardando
        };
    }
}
