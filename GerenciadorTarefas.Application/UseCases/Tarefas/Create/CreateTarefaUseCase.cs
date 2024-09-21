using GerenciadorTarefas.Communication.Requests;
using GerenciadorTarefas.Communication.Responses;

namespace GerenciadorTarefas.Application.UseCases.Tarefas.Create;
public class CreateTarefaUseCase
{
    public ResponseTarefaRegistradaJson Execute(RequestTarefaJson request)
    {
        return new ResponseTarefaRegistradaJson
        {
            Id = 8,
            Name = request.Name
        };
    }
}
