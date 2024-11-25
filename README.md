Projeto em Angular 19 e .NET Framework 4.5 (VS 2019)

## How To Run
- Clone o projeto
Back-end:
- Abra o back-end: back > SinqiaExam > SinqiaExam.sln no Visual Studio 2019
- Rebuild + Clean na solução (isto irá restaurar os pacotes)
- Altere a ConnectionString "SinqiaExamDbConnection" no arquivo Web.config para as configurações do seu banco de dados
- No Package Manager Console, selecione o projeto "SinqiaExam.Data" e rode o comando "update-database"
- Rode o projeto

Front-end:
- Abra a pasta do front-end em um editor (por exemplo, Visual Studio Code): front > sinqia_exam_angular
- Rode o comando npm install
- Rode o comando ng serve

Rodando ambas as aplicações, todas as especificações deverão estar disponíveis.
