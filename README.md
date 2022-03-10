# Desafio para candidatos da Stefanini

## 1. Estudo de caso

![image](https://user-images.githubusercontent.com/29407031/156945886-01367072-7991-4f13-b54a-f7be7812a393.png)

Criar o CRUD para a modelagem de pessoa e cidade;

## 2. Arquitetura

A API precisa ser entregue em .NET Core, podendo utilizar a nossa arquitetura de exemplo ou outra que vocês construírem, e nesse cenário a arquitetura também será validada (SOLID, Clean Code e API REST é imprescindível).
O frontend pode ser entregue com qualquer tipo de framework/lib javascript de qualquer versão (temos preferência a Angular e Vue.js).

## 3. Requisitos do ambiente

- Docker com suporte a contêiner Linux;
- Porta 5434 do MSSQL liberada (Caso dê conflito, mudar para uma de sua escolha);
- Visual Studio 2022 ou Visual Studio Code;
- .NET Core 6;

## 4. Entregáveis 

A não entrega do obrigatório o candidato será desclassificado e todos os artefatos precisam estar em um repositório GIT público;

#### 4.1. Obrigatório

- API .NET Core executando e com todas as API’s funcionando;
- Swagger funcionando;

#### 4.2. Desejável

- Migration SQL funcionando no projeto;
- Frontend com todas as integrações e os comportamentos básicos funcionando;
- Link acessível com o projeto publicado na Azure/AWS/GCP;

## 5. Dicas

- A arquitetura de exemplo conta com um projeto docker-compose pronto e configurado para executar a aplicação, incluindo o provisionamento de uma instância MS SQL para mesma. Caso tenha dificuldades para executar o projeto com Docker, ignore o mesmo e execute o Projeto web, mudando apenas a connection string e apontando para uma instância válida do banco de dados.

## 6. Questionário

- Após a entrega do desafio, colabore com a sua opinião: https://forms.gle/jU1RCX5UsBGPieaP8




