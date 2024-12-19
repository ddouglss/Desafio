<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
</head>
<body>

   <h1>Anéis do Poder</h1>

   <p><strong>Projeto: </strong>Anéis do Poder é uma aplicação web desenvolvida com ASP.NET Core, Razor Pages e SQL Server. O objetivo do projeto é permitir o gerenciamento de informações sobre anéis de poder, com funcionalidades de CRUD (Criar, Ler, Atualizar, Deletar) para adicionar, visualizar e editar dados sobre cada anel.</p>

   <h2>Tecnologias Utilizadas</h2>
    <ul>
        <li><strong>ASP.NET Core</strong>: Framework web utilizado para desenvolvimento de aplicações modernas e escaláveis em C#.</li>
        <li><strong>Razor Pages</strong>: Arquitetura baseada em páginas para renderização dinâmica de conteúdo, simplificando a criação de páginas web em comparação com o MVC tradicional.</li>
        <li><strong>Entity Framework Core</strong>: ORM (Object-Relational Mapper) utilizado para manipulação do banco de dados de maneira fácil e eficiente.</li>
        <li><strong>SQL Server</strong>: Banco de dados relacional utilizado para persistir os dados da aplicação, armazenando informações sobre os anéis de poder.</li>
        <li><strong>Bootstrap</strong>: Framework CSS utilizado para tornar a interface da aplicação responsiva e visualmente atraente.</li>
    </ul>

   <h2>Funcionalidades</h2>
    <p>A aplicação permite realizar as seguintes operações sobre os anéis de poder:</p>
    <ul>
        <li><strong>Criar</strong>: O usuário pode adicionar novos anéis, preenchendo informações como o nome do anel, seu poder, o forjador e a imagem associada.</li>
        <li><strong>Ler</strong>: A aplicação exibe todos os anéis cadastrados no banco de dados em uma lista, com a possibilidade de visualizar detalhes de cada um.</li>
        <li><strong>Atualizar</strong>: O usuário pode editar os dados de um anel existente, como o nome, poder, forjador e imagem.</li>
        <li><strong>Deletar</strong>: O usuário pode excluir anéis do sistema, removendo-os permanentemente do banco de dados.</li>
    </ul>

  <h2>Detalhamento da Implementação</h2>

   <h3>1. CRUD com Razor Pages</h3>
    <p>O projeto foi estruturado com Razor Pages, que é uma abordagem simplificada do ASP.NET Core, focada na criação de páginas independentes. Com Razor Pages, o código de backend (C#) e o código de frontend (HTML) estão diretamente conectados, tornando a implementação de funcionalidades como o CRUD mais direta e menos complexa do que o modelo tradicional MVC.</p>

  <h4>Operações CRUD</h4>
    <p>As operações CRUD (Create, Read, Update, Delete) foram implementadas de maneira a permitir que os dados dos anéis sejam manipulados diretamente pelo usuário.</p>
    
  <ul>
        <li><strong>Create (Criar)</strong>: Na página inicial, existe um formulário para cadastrar novos anéis de poder. O usuário preenche os campos como nome, poder, forjador e imagem, e ao submeter o formulário, os dados são armazenados no banco de dados.</li>
        <li><strong>Read (Ler)</strong>: Todos os anéis cadastrados são exibidos na página principal. Cada anel possui informações como nome, poder e forjador. O usuário pode visualizar esses dados diretamente na interface.</li>
        <li><strong>Update (Atualizar)</strong>: O usuário pode editar qualquer um dos anéis cadastrados, modificando seus dados através de um formulário que pré-preenche as informações atuais, permitindo que o usuário altere as propriedades do anel.</li>
        <li><strong>Delete (Deletar)</strong>: Cada anel possui a opção de ser excluído, removendo-o permanentemente do banco de dados.</li>
    </ul>

  <h3>2. Uso do Entity Framework Core com SQL Server</h3>
    <p>Para persistir os dados, utilizei o Entity Framework Core (EF Core), que é um ORM (Object-Relational Mapper) que facilita a interação com bancos de dados relacionais. O EF Core foi configurado para utilizar o SQL Server, onde as informações sobre os anéis de poder são armazenadas.</p>

   <h4>Estrutura do Banco de Dados</h4>
    <p>O banco de dados contém uma tabela chamada <code>Ring</code>, que armazena as informações de cada anel. A estrutura da tabela é composta pelas seguintes colunas:</p>
    <ul>
        <li><strong>ID</strong> (int): Identificador único do anel.</li>
        <li><strong>Nome</strong> (string): Nome do anel de poder.</li>
        <li><strong>Poder</strong> (string): Descrição do poder do anel.</li>
        <li><strong>ForjadoPor</strong> (string): Nome do forjador do anel.</li>
        <li><strong>Imagem</strong> (string): Caminho para a imagem associada ao anel.</li>
    </ul>
    
  <h4>Comandos para Atualizar o Banco de Dados</h4>
    <p>Para criar ou atualizar a estrutura do banco de dados, utilizei as migrações do Entity Framework. Aqui estão os comandos que foram utilizados:</p>
    <ul>
        <li>Para criar uma migração inicial:</li>
        <pre><code>dotnet ef migrations add InitialCreate</code></pre>
        <li>Para aplicar a migração e atualizar o banco de dados:</li>
        <pre><code>dotnet ef database update</code></pre>
    </ul>

  <h3>3. Explicação do Fluxo de Dados</h3>
    <p>O fluxo de dados na aplicação segue a lógica do ASP.NET Core com Razor Pages:</p>
    <ul>
        <li>O usuário interage com a interface da aplicação, preenchendo formulários ou visualizando listas de anéis.</li>
        <li>Quando o formulário é submetido (por exemplo, ao adicionar ou editar um anel), a página envia os dados para o backend, onde o Entity Framework Core manipula esses dados e interage com o banco de dados SQL Server.</li>
        <li>Após as operações de CRUD, a aplicação redireciona o usuário para a página principal, onde a lista atualizada de anéis é exibida.</li>
    </ul>

   <h2>Conclusão</h2>
    <p>Este projeto demonstra a utilização de tecnologias modernas de desenvolvimento web com ASP.NET Core, Razor Pages e Entity Framework Core, com foco no gerenciamento de dados de maneira simples e eficiente. O projeto foi projetado para mostrar a capacidade de implementar um sistema de CRUD completo com integração a um banco de dados relacional (SQL Server), além de garantir uma interface limpa e responsiva utilizando Bootstrap.</p>

   <p>Este é um exemplo prático das minhas habilidades em desenvolvimento web, manipulação de dados e trabalho com tecnologias .NET.</p>

   <h2>Desenvolvido</h2>
    <p>Douglas Souza SIlva.</p>

</body>
</html>
