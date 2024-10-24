using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web_app_domain;
using web_app_performance.Model;
using web_app_repository;

namespace Test
{
    public class ProdutoRepositoryTest
    {
        [Fact]
        public async Task ListarProdutos()
        {
            //Arrange
            var produtos = new List<Produto>
            {
                new Produto()
                 {
                    Id = 1,
                    nome = "Produto 1",
                    preco = 22.3,
                    quantidade_estoque = 4,
                    data_criacao = "08/08/2004"
                },
                  new Produto()
                  {
                    Id = 2,
                    nome = "Produto 2",
                    preco = 22.3,
                    quantidade_estoque = 4,
                    data_criacao = "14/10/2024"
                },
            };

            var productRepositoryMock = new Mock<IProdutoRepository>();
            productRepositoryMock.Setup(u => u.ListarProdutos()).ReturnsAsync(produtos);
            var productRepository = productRepositoryMock.Object;

            //Act
            var result = await productRepository.ListarProdutos();

            //Assert
            Assert.Equal(produtos, result);

        }


        [Fact]
        public async Task SalvarProduto()
        {
            //arrange 
            var produto = new Produto()
            {
                Id = 2,
                nome = "Produto 2",
                preco = 22.3,
                quantidade_estoque = 4,
                data_criacao = "14/10/2024"
            };

            var productRepositoryMock = new Mock<IProdutoRepository>();
            productRepositoryMock.Setup(u => u.SalvarProduto(It.IsAny<Produto>())).Returns(Task.CompletedTask);
            var productRepository = productRepositoryMock.Object;

            //act
            await productRepository.SalvarProduto(produto);

            //assert
            productRepositoryMock
          .Verify(u => u.SalvarProduto(It.IsAny<Produto>()), Times.Once);
        }
    }
}
