using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;
using RabbitMQ.Client.MessagePatterns;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectionFactory cf = new ConnectionFactory();
            var con = cf.CreateConnection();
            var model = con.CreateModel();

            SimpleRpcClient client = new SimpleRpcClient(model);
            
        }
    }
}
