# Lista de Tarefas em ASP.NET MVC

Um projeto simples para gerenciar tarefas, desenvolvido em ASP.NET MVC com Entity Framework e SQLite.

## Funcionalidades

- Adicionar novas tarefas com título e data.
- Listar todas as tarefas cadastradas.
- Editar tarefas.
- Marcar tarefas como concluídas.
- Validação de campos obrigatórios.

## Tecnologias

- ASP.NET MVC
- Entity Framework Core
- SQLite
- Bootstrap (para estilização)

## Como Executar

1. Clone o repositório:
```bash
git clone https://github.com/fernandonline/lista-de-tarefas-ASP.NET-mvc.git
```

2. Navegue até a pasta do projeto:
```bash
cd lista-de-tarefas-ASP.NET-mvc
```

3. Reataure as dependências:
```bash
dotnet restore
```

4. Inicie o Servidor:
```bash
dotnet run
```

5. Acesse o projeto no navegador:
```bash
http://localhost:5031/
```

* Para a versão com SQLite, use o comando ``` dotnet ef database update ```, isso criará um arquivo TodoList.db na raiz que servirá como banco de dados.
