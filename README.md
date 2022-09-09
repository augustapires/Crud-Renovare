# Crud-Renovare

![TelaInicialProjeto](https://user-images.githubusercontent.com/112721730/189253695-1850ba0e-07eb-4d98-9174-5dfb0968cac0.png)

## 💻 Sobre o projeto
Desenvolvimento de um projeto CRUD dotNet Básico utilizando o acesso ao banco de dados SQL e linguagem C#.<br>
Este tem como objetivo cadastrar imóveis para auxiliar empresas imobiliárias.

## 🚀 Começando

Essas instruções permitirão que você faça uma cópia do projeto em operação na sua máquina local para fins de desenvolvimento e testes.

## 📋 Pré-requisitos
```
Visual Studio 2022
Microsoft SQL Server
```

## 🛠️ Código da criação da tabela no SQL
```
create table ImoveisRenovare(
[ID] int not null primary key,
[Tipo] varchar(20) not null,
[Modalidade] varchar(20) not null,
[Endereco] varchar(100) not null,
[Numero] int not null,
[Complemento] varchar(50),
[CEP] varchar(15) not null,
[Cidade] varchar (30) not null,
[UF] varchar (10) not null,
[Area] int not null,
[Quartos] int not null,
[Vagas] int not null,
[Banheiros] int not null);
```
## ✒️ Criação
Desenvolvido por: Augusta Ramos Pires<br>
Data: 08/09/2022
