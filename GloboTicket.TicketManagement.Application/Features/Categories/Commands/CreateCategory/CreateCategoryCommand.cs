
using MediatR;

namespace GloboTicket.TicketManagement.Application.Features.Categories.Commands.CreateCategory
{
    public record CreateCategoryCommand(string Name) : IRequest<CreateCategoryCommandResponse>;
}
