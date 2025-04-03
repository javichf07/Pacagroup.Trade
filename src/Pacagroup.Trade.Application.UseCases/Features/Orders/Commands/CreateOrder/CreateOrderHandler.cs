using AutoMapper;
using MediatR;
using Pacagroup.Trade.Aplication.Interface.Persistence;
using Pacagroup.Trade.Domain.Entities;

namespace Pacagroup.Trade.Application.UseCases.Features.Orders.Commands.CreateOrder
{
    public class CreateOrderHandler : IRequestHandler<CreateOrderCommand, bool>
    {
        private readonly IApplicationDbContext applicationDbContext;
        private readonly IMapper mapper;

        public CreateOrderHandler(IApplicationDbContext applicationDbContext, IMapper mapper)
        {
            this.applicationDbContext = applicationDbContext;
            this.mapper = mapper;
        }

        public async Task<bool> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            
            var order = mapper.Map<Order>(request);
            await applicationDbContext.Orders.AddAsync(order,cancellationToken);

            if(await applicationDbContext.SaveChangesAsync(cancellationToken) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
