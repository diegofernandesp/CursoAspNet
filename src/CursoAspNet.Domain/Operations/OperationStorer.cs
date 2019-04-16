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

        public void Store(int id, int orderId, string nope, int nseq, string dope)
        {
            var order = _OrderRepository.GetById(orderId);
            DomainException.When(order == null, "Invalid Order");

            var operation = _OperationRepository.GetById(id);
            if (operation == null)
            {
                operation = new Operation(order, nope, nseq, dope);
                _OperationRepository.Save(operation);
            }
            else
                operation.Update(order, nope, nseq, dope);

        }
    }
}
