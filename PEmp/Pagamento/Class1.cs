using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEmp.Pagamento
{


    public static class Pagamento
    {

        public static void FormasPagamento(string[] pagamento)
        {
            pagamento = new string[2];
            pagamento[0] = "Dinheiro";
            pagamento[1] = "Cartão"; 
        }


    }

}
