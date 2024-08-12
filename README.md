# Sistema de Estacionamento (Desafio DIO) 🅿️

Este projeto faz parte do bootcamp **Aprofundamento C#** da plataforma DIO. O objetivo é aplicar os conhecimentos adquiridos no módulo de fundamentos, desenvolvendo um sistema de gerenciamento de estacionamento.

## Desafio de Projeto ⚔️

O desafio consiste em construir um sistema para gerenciar veículos estacionados, permitindo operações como adicionar, remover e listar veículos, além de calcular o valor cobrado pelo período de estacionamento.

## Contexto 📃

Você foi contratado para desenvolver um sistema de estacionamento que será utilizado para gerenciar os veículos estacionados e realizar operações como:
- Adicionar um veículo
- Remover um veículo (exibindo o valor cobrado durante o período)
- Listar os veículos

## Proposta 📌

A proposta é construir um sistema de estacionamento que permita:
- Cadastrar um veículo
- Remover um veículo
- Listar um veículo específico
- Listar todos os veículos

### Diagrama de Classe

!Diagrama de classe estacionamento

### Variáveis da Classe

- **precoInicial**: Tipo decimal. É o preço cobrado para deixar seu veículo estacionado.
- **precoPorHora**: Tipo decimal. É o preço por hora que o veículo permanecer estacionado.
- **veiculos**: É uma lista de string, representando uma coleção de veículos estacionados. Contém apenas a placa do veículo.

### Métodos da Classe

- **AdicionarVeiculo**: Método responsável por receber uma placa digitada pelo usuário e guardar na variável **veiculos**.
- **RemoverVeiculo**: Método responsável por verificar se um determinado veículo está estacionado, e caso positivo, irá pedir a quantidade de horas que ele permaneceu no estacionamento. Após isso, realiza o seguinte cálculo: **precoInicial** + (**precoPorHora** * horas), exibindo para o usuário.
- **ListarVeiculos**: Lista todos os veículos presentes atualmente no estacionamento. Caso não haja nenhum, exibir a mensagem "Não há veículos estacionados".

### Menu Interativo

O sistema deve apresentar um menu interativo com as seguintes opções:
1. Cadastrar veículo
2. Remover veículo
3. Listar veículos
4. Encerrar

## Ferramentas ⚙️

- **Linguagem**: `C#`
- **IDE**: `Visual Studio`

## Estrutura do Projeto

```plaintext
sistemaEstacionamento/
├── .vs/
├── Carros.cs
├── Estacionamento.cs
├── Program.cs
├── sistemaEstacionamento.sln
├── .gitignore
├── Diagrama_classes_classeCarros.png
├── Diagrama_classes_classeEstacionamento.png
└── README.md
