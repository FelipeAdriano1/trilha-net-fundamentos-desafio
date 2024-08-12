## Desafio de projeto ⚔️
Este desafio faz parte do bootcamp Aprofundamento C# da plataforma DIO. O objetivo é aplicar os conhecimentos adquiridos no módulo de fundamentos.

## Contexto 📃
Você foi contratado para construir um sistema para um estacionamento, que será usado para gerenciar os veículos estacionados e realizar suas operações, como por exemplo adicionar um veículo, remover um veículo (e exibir o valor cobrado durante o período) e listar os veículos.

## Proposta 📌
A proposta é construir um sistema de estacionamento que permita cadastrar um veículo, remover um veículo, listar um veículo específico e listar todos os veículos.

A classe contém três variáveis, sendo:

**precoInicial**: Tipo decimal. É o preço cobrado para deixar seu veículo estacionado.

**precoPorHora**: Tipo decimal. É o preço por hora que o veículo permanecer estacionado.

**veiculos**: É uma lista de string, representando uma coleção de veículos estacionados. Contém apenas a placa do veículo.

A classe contém três métodos, sendo:

**AdicionarVeiculo**: Método responsável por receber uma placa digitada pelo usuário e guardar na variável **veiculos**.

**RemoverVeiculo**: Método responsável por verificar se um determinado veículo está estacionado, e caso positivo, irá pedir a quantidade de horas que ele permaneceu no estacionamento. Após isso, realiza o seguinte cálculo: **precoInicial** * **precoPorHora**, exibindo para o usuário.

**ListarVeiculos**: Lista todos os veículos presentes atualmente no estacionamento. Caso não haja nenhum, exibir a mensagem "Não há veículos estacionados".

Por último, deverá ser feito um menu interativo com as seguintes ações implementadas:
1. Cadastrar veículo
2. Remover veículo
3. Listar veículos
4. Encerrar

## Ferramentas ⚙️
A linguagem utilizada foi `C#` no `Visual Studio`

## Resultados 🎯
O sistema é utilizado através do console.
Todos os métodos e classes citados na seção `Proposta` foram implementados e testados sendo possível adicionar, remover e listar um veículo. 
