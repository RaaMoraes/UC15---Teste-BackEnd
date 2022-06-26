using ProjetoTeste;
using Xunit;

namespace TestXUnit
{
    public class UnitTest1
    {
        [Fact]
        public void SomarDoisNumeros()
        {
            //Arrange
            double numero1 = 1;
            double numero2 = 2;
            double verificacao = 3;

            //Act
            var soma = Operacoes.Somar(numero1, numero2);

            //Assert
            Assert.Equal(verificacao, soma);
        }


        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(2, 1, 2)]
        public void SomarDoisNumeLista(double numero1, double numero2, double verificacao)
        {
            //Act
            var soma = Operacoes.Somar(numero1, numero2);

            //Assert
            Assert.Equal(verificacao, soma);

        }
    }

  
}