using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoTeste;

namespace TestMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SomarDoisNumeros()
        {
            //Arrange - Prepara��es
            double pNum = 1;
            double sNum = 2;
            double verificacao = 3;

            //Act - A��o
            var soma = Operacoes.Somar(pNum,sNum);
            
            //Assert - Verifica��o
            Assert.AreEqual(verificacao, soma);
        }

        [DataTestMethod]
        //casos de teste
        [DataRow(1, 1, 2)]
        [DataRow(2, 2, 4)]
        [DataRow(2, 1, 2)]
        public void SomarDoisNumerosLista(double pNum, double sNum, double verificacao)
        {
            //Act - A��o
            var soma = Operacoes.Somar(pNum, sNum);

            //Assert - Verifica��o
            Assert.AreEqual(verificacao, soma);
        }
    }
}