using algarismosRomanos;
using Xunit;

namespace algarismosRomanosTeste;

public class AlgarismosRomanosTeste
{
    [Fact]
    public void DeveEntenderOSimboloI()
    {
        ConversorAlgarismosRomanos conversor = new ConversorAlgarismosRomanos();
        var result = conversor.Converte("I");

        Assert.Equal(result, 1);
    }

    [Fact]
    public void DeveEntenderOSimboloV()
    {
        ConversorAlgarismosRomanos conversor = new ConversorAlgarismosRomanos();
        var result = conversor.Converte("V");

        Assert.Equal(result, 5);
    }

    [Fact]
    public void DeveEntenderOSimboloX()
    {
        ConversorAlgarismosRomanos conversor = new ConversorAlgarismosRomanos();
        var result = conversor.Converte("X");

        Assert.Equal(result, 10);
    }

    [Fact]
    public void DeveEntenderOSimboloL()
    {
        ConversorAlgarismosRomanos conversor = new ConversorAlgarismosRomanos();
        var result = conversor.Converte("L");

        Assert.Equal(result, 50);
    }

    [Fact]
    public void DeveEntenderOSimboloC()
    {
        ConversorAlgarismosRomanos conversor = new ConversorAlgarismosRomanos();
        var result = conversor.Converte("C");

        Assert.Equal(result, 100);
    }

    [Fact]
    public void DeveEntenderOSimboloD()
    {
        ConversorAlgarismosRomanos conversor = new ConversorAlgarismosRomanos();
        var result = conversor.Converte("D");

        Assert.Equal(result, 500);
    }

    [Fact]
    public void DeveEntenderOSimboloM()
    {
        ConversorAlgarismosRomanos conversor = new ConversorAlgarismosRomanos();
        var result = conversor.Converte("M");

        Assert.Equal(result, 1000);
    }

    [Fact]
    public void DeveEntenderDoisSimbolos()
    {
        ConversorAlgarismosRomanos conversor = new ConversorAlgarismosRomanos();
        var result = conversor.Converte("II");

        Assert.Equal(result, 2);
    }

    [Fact]
    public void DeveEntenderQuatroSimbolosDoisADois()
    {
        ConversorAlgarismosRomanos conversor = new ConversorAlgarismosRomanos();
        var result = conversor.Converte("XXII");

        Assert.Equal(result, 22);
    }

    [Fact]
    public void DeveEntenderNumerosComoIX()
    {
        ConversorAlgarismosRomanos conversor = new ConversorAlgarismosRomanos();
        var result = conversor.Converte("IX");

        Assert.Equal(result, 9);
    }

    [Fact]
    public void DeveEntenderNumerosComplexosComoXXIV()
    {
        ConversorAlgarismosRomanos conversor = new ConversorAlgarismosRomanos();
        var result = conversor.Converte("XXIV");

        Assert.Equal(result, 24);
    }
}