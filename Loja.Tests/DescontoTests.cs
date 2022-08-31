namespace Loja.Tests;

public class DescontoTests
{
    [Fact]
    public void Quando_o_produto_eh_vermelho_o_desconto_eh_de_10_porcento()
    {
    //Preparar
    var desconto = new Desconto();
    
    //Executar
    var valor = desconto.Calcule(Cor.Vermelho);

     //Verificar
    Assert.Equal(10, valor);
    }
}