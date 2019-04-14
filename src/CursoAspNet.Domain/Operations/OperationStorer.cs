using CursoAspNet.Domain.Dto;
using CursoAspNet.Domain.Orders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoAspNet.Domain.Operations
{
    public class OperationStorer
    {
        private readonly IRepository<Operation> _OperationRepository;
        private readonly IRepository<Order> _OrderRepository;

        public OperationStorer(IRepository<Operation> operationRepository, IRepository<Order> orderRepository)
        {
            _OperationRepository = operationRepository;
            _OrderRepository = orderRepository;
        }

        public void Store(OperationDto dto)
        {
            var order = _OrderRepository.GetById(dto.OrderId);
            DomainException.When(order == null, "Invalid Order");

            var operation = _OperationRepository.GetById(dto.Id);
            if (operation == null)
            {
                operation = new Operation(order, dto.Nope, dto.Nseq, dto.Dope);
                _OperationRepository.Save(operation);
            }
            else
                operation.Update(order, dto.Nope, dto.Nseq, dto.Dope);

        }
    }
}
