
function gerarStringAleatoria(tamanho) {
  const caracteres = 'ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789';
  let resultado = '';
  
  for (let i = 0; i < tamanho; i++) {
    const indice = Math.floor(Math.random() * caracteres.length);
    resultado += caracteres[indice];
  }
  
  return resultado;
}

function gerarValorAleatorio(tamanho) {
  const caracteres = '0123456789';
  let resultado = '';
  
  for (let i = 0; i < tamanho; i++) {
    const indice = Math.floor(Math.random() * caracteres.length);
    resultado += caracteres[indice];
  }
  
  return resultado;
}


describe('template spec', () => {
  it('passes', ()=> {
    cy.visit('http://127.0.0.1:5500/cadastroProd.html')
    const nome = gerarStringAleatoria(4);
    const preco = gerarValorAleatorio(4)
    const quantidade = gerarValorAleatorio(4);
    cy.get('#registerName').type(nome)
    cy.get('#registerPrice').type(preco)
    cy.get('#registerQuantity').type(quantidade)
    cy.get('.btn').click()
  })
})