

namespace Controle_Clientes {

    public class PessoaJuridica : Clientes {

        public string Cnpj { get; set; }
        public string ie { get; set; }

        public override void Pagar_Imposto(float v) {
            float valor = v;
            float valorImposto = valor * 20/100;
            float total = valorImposto;

        
        }
    }
}
