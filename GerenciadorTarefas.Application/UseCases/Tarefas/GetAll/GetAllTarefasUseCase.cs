using GerenciadorTarefas.Communication.Responses;

namespace GerenciadorTarefas.Application.UseCases.Tarefas.GetAll;
public class GetAllTarefasUseCase
{
    public ResponseTodasTarefasJson Execute()
    {
        return new ResponseTodasTarefasJson
        {
            Tarefas = new List<ResponseTarefaShortJson>
            {
                new ResponseTarefaShortJson
                {
                    Id = 1,
                    Name = "Lavar a louça",
                    DateLimit = new DateTime(year: 2024, month: 09, day: 21),
                    Status = Communication.Enum.StatusType.Aguardando
                }
            }
        };
    }
}
