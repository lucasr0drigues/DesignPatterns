using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class ConcreteReplicaBuilder : IBuilder
    {
        private ProductReplica _product = new ProductReplica();

        public ConcreteReplicaBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _product = new ProductReplica();
        }

        public void BuildPartA()
        {
            _product.Add("PartA1Replica");
        }

        public void BuildPartB()
        {
            _product.Add("PartB1Replica");
        }

        public void BuildPartC()
        {
            _product.Add("PartC1Replica");
        }

        public ProductReplica GetProductReplica()
        {
            ProductReplica result = _product;

            Reset();

            return result;
        }
    }
}
