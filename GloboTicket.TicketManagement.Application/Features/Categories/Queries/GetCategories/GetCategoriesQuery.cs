
using MediatR;

namespace GloboTicket.TicketManagement.Application.Features.Categories.Queries.GetCategories
{
    public record GetCategoriesQuery : IRequest<List<CategoryListVm>>;
}
