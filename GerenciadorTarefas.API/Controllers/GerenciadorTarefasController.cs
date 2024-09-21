using GerenciadorTarefas.Application.UseCases.Tarefas.Create;
using GerenciadorTarefas.Application.UseCases.Tarefas.Delete;
using GerenciadorTarefas.Application.UseCases.Tarefas.GetAll;
using GerenciadorTarefas.Application.UseCases.Tarefas.GetById;
using GerenciadorTarefas.Application.UseCases.Tarefas.Update;
using GerenciadorTarefas.Communication.Requests;
using GerenciadorTarefas.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorTarefas.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class GerenciadorTarefasController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof (ResponseTarefaRegistradaJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof (ResponseErrorsJson), StatusCodes.Status400BadRequest)]

    public IActionResult CreateTask([FromBody] RequestTarefaJson request)
    {
        var response = new CreateTarefaUseCase().Execute(request);

        return Created(string.Empty, response);
    }

    [HttpGet]
    [ProducesResponseType(typeof(ResponseTodasTarefasJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]

    public IActionResult GetAllTasks()
    {
        var response = new GetAllTarefasUseCase().Execute();

        if (response.Tarefas.Any())
        {
            return Ok(response);
        }

        return NoContent();
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseTarefa), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]

    public IActionResult GetTaskById (int id)
    {
        var response = new GetTarefaByIdUseCase().Execute(id);
        return Ok(response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]

    public IActionResult UpdateTask(int id, [FromBody] RequestTarefaJson request)
    {
        var useCase = new TarefaUpdateUseCase();

        useCase.Execute(id, request);

        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]

    public IActionResult DeleteTask(int id)
    {
        var useCase = new DeleteTarefaUseCase();
        useCase.Execute(id);

        return NoContent();
    }

}
