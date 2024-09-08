

using MediatR;

namespace GloboTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesWithEvents
{
    public record GetCategoriesWithEventsQuery(bool IncludeHistory) : IRequest<List<CategoryEventListVm>>;
}
