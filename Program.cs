﻿// See https://aka.ms/new-console-template for more information
using Cadastro.Classes;

// PessoaFisica novaPf = new PessoaFisica();
Endereco novoEnd = new Endereco();

// novaPf.nome = "William";
// novaPf.DataNascimento = "13/12/1995";
// novaPf.cpf = "12345678900";
// novaPf.rendimento = 500.0f;

novoEnd.logradouro = "Dolores Alcaras Caldas";
novoEnd.numero = 8975;
novoEnd.complemento = "Apto 50";
novoEnd.EndComercial = false;

// novaPf.endereco = novoEnd;

// Console.WriteLine(@$"
// Nome: {novaPf.nome}
// Endereço: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}
// Maior de idade: {novaPf.ValidarDataNascimento(novaPf.DataNascimento)} 
// ");

/*
novaPf.nome = "William";
Console.WriteLine(novaPf.nome);
*/


// Console.WriteLine(novaPf.ValidarDataNascimento("01/01/2000"));
// Console.WriteLine(novaPf.ValidarDataNascimento(new DateTime(2000,01,01)));

PessoaJuridica metodoPj = new PessoaJuridica();
PessoaJuridica novaPj = new PessoaJuridica();

novaPj.endereco = novoEnd;

novaPj.nome = "NomePj";
novaPj.cnpj = "00.000.000/0001-00";
novaPj.RazaoSocial = "Razão Barão de Limeira";
novaPj.rendimento = 5000.5f;

Console.WriteLine(@$"
Nome: {novaPj.nome}
Razão Social:{novaPj.RazaoSocial}
CNPJ: {novaPj.cnpj}
CNPJ é válido: {metodoPj.ValidarCnpj(novaPj.cnpj)}
");
