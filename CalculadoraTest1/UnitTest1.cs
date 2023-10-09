namespace CalculadoraTest1;
using Calculadora;

public class UnitTest1
{
    [Theory]
    [InlineData(5, 5, 10)] 
    [InlineData(10, 5, 15)]
    public void SomaCalculadoraTest(int val1, int val2, int resultado)
    {
        Calculadora calc = new Calculadora();

        int resultadoCalc = calc.Somar(val1, val2);
        
        Assert.Equal(resultado, resultadoCalc);
    }
    
    [Theory]
    [InlineData(5, 5, 0)]
    [InlineData(10, 5, 5)]
    public void SubtracaoCalculadoraTest(int val1, int val2, int resultado)
    {
        Calculadora calc = new Calculadora();

        int resultadoCalc = calc.Subtrair(val1, val2);
        
        Assert.Equal(resultado, resultadoCalc);
    }
    
    [Theory]
    [InlineData(5, 5, 25)]
    [InlineData(10, 5, 50)]
    public void MultiplicacaoCalculadoraTest(int val1, int val2, int resultado)
    {
        Calculadora calc = new Calculadora();

        int resultadoCalc = calc.Multiplicar(val1, val2);
        
        Assert.Equal(resultado, resultadoCalc);
    }
    
    [Theory]
    [InlineData(5, 5, 1)]
    [InlineData(10, 5, 2)]
    public void DivisaoCalculadoraTest(int val1, int val2, int resultado)
    {
        Calculadora calc = new Calculadora();

        int resultadoCalc = calc.Dividir(val1, val2);
        
        Assert.Equal(resultado, resultadoCalc);
    }
    
    [Fact]
    public void DivisaoPorZeroCalculadoraTest()
    {
        Calculadora calc = new Calculadora();

        Assert.Throws<DivideByZeroException>(() => calc.Dividir(10, 0));
    }
    
    [Fact]
    public void HistoricoCalculadoraTest()
    {
        Calculadora calc = new Calculadora();
        

        List<string> historico = calc.Historico();
        
        Assert.Empty(historico);
    }
}