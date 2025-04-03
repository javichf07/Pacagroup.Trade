using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Pacagroup.Trade.Aplication.Interface.Persistence;

namespace Pacagroup.Trade.Application.UseCases.Features.Orders.Queries.GetOrder
{
    public class GetOrderHandler : IRequestHandler<GetOrderQuery, GetOrderResponseDTO>
    {
        private readonly IApplicationDbContext _applicationDbContext;
        private readonly IMapper _mapper;

        public GetOrderHandler(IApplicationDbContext applicationDbContext, IMapper mapper)
        {
            _applicationDbContext = applicationDbContext;
            _mapper = mapper;
        }

        public async Task<GetOrderResponseDTO> Handle(GetOrderQuery request, CancellationToken cancellationToken)
        {
            var order = await _applicationDbContext.Orders.FirstOrDefaultAsync(x => x.Id.Equals(request.Id), cancellationToken);
            var response = _mapper.Map<GetOrderResponseDTO>(order);

            return response;
        }
    }
}
