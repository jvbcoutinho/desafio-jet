# Desenvolvedor(a) Full-stack .NET Core (Remoto) | JET e-Business

## Estrutura básica da loja:

**Página principal**

- [x] A loja precisa ter uma página principal com a listagem dos produtos com as informações de preço nome e imagem.
- [x] Cada produto deve possuir um botão que permitirá adicionar o produto na cesta de compras da loja.

**Página de cesta de compras**

- [x] A cesta de compras deve listar todos os produtos escolhidos e seus respectivos preços. Não esqueça de permitir que o cliente altere a quantidade dos produtos que deseje comprar.

**Página de identificação do cliente**

- [x] Ao finalizar a compra o cliente deve ser direcionado para a página de identificação do cliente solicitando nome, e-mail e telefone.

**Página de pedido realizado**

- [x] Após a identificação do cliente deve ser exibido a página do pedido com o número do pedido, dados do cliente e produtos selecionados com seus respectivos valores.


## Arquitetura do projeto:

- [x] A camada de front-end da loja pode ser realizada utilizando Asp.net MVC 5 ou Angular. (fique a vontade para utilizar bootstrap)

` O layout foi feito utilizando Bootstrap e foram utilizados componentes do Angular Material.`

` Tomei a liberdade de utilizar o Angular material pois estou mais habituado a trabalhar com ele do que com bootstrap.`

- [x] O front deve se comunicar com o repositório de dados utilizando api rest que precisam ser criadas utilizando .net Core 2.2 ou superior.

`Api rest criada em camadas utilizando .net 5`

- [x] Para a camada de repositório de dados pode-se utilizar dados estáticos (in memory) ou algum banco de dados relacional (ex. MySql, PostgreSql, SqlServer ) ou bancos nosql como MongoDB, Cassandra e Redis.

`Foi utilizado banco de dados SqlServer com hospedagem no Azure`


## Entrega do projeto:

- [x] Versione seu projeto em algum repositório ex. Github, Bitbucket, AzureDevops

- [x] Publique seu projeto!

`Webapi publicada no Azure com integração através do GitHub Actions`

`SPA publicada no Azure com integração através do GitHub Actions`


## Link de acesso:

`https://lively-ground-082895b0f.azurestaticapps.net/`
