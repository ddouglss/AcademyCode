<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
</head>
<body>
  <h1>AcademyCode</h1>
 <p>
    Bem-vindo ao <strong>AcademyCode</strong>! Este é um projeto de uma plataforma de cursos online
    desenvolvida para programadores. Ele foi projetado com o objetivo de fornecer uma experiência
    interativa e intuitiva para usuários que desejam aprimorar suas habilidades em tecnologia.
  </p>
 

## <p>Repositório do Front-end </p> https://github.com/ddouglss/vue-code

  <h2>Visão Geral do Projeto</h2>
  <p>
    O <strong>AcademyCode</strong> utiliza tecnologias modernas e escaláveis para garantir a melhor
    experiência de navegação e usabilidade, tanto no front-end quanto no back-end.
  </p>
  <ul>
    <li><strong>Vue.js 3</strong> (Front-end): Framework JavaScript para criar interfaces modernas e dinâmicas.</li>
    <li><strong>.NET Core API</strong> (Back-end): Gerencia a lógica de negócios e fornece endpoints RESTful.</li>
    <li><strong>SQL Server</strong> (Banco de dados): Banco de dados relacional para persistência de dados.</li>
    <li><strong>Figma</strong> (Design): Criação de layouts para as telas do projeto.</li>
    <li><strong>Draw.io</strong> (Documentação): Diagramas para modelagem do banco de dados e arquitetura do sistema.</li>
  </ul>

  <h2>Funcionalidades Principais</h2>
  <h3>1. Funcionalidades Públicas (Index)</h3>
  <ul>
    <li>Carrossel com imagens e cards descritivos sobre os cursos.</li>
    <li>Informações sobre a importância dos cursos e seus benefícios.</li>
  </ul>

  <h3>2. Pós-Login</h3>
  <ul>
    <li><strong>Home de Cursos</strong>: Lista de cursos disponíveis para seleção.</li>
    <li><strong>Página "Minha Conta"</strong>:
      <ul>
        <li>Visualização e edição de dados do cliente.</li>
        <li>Conexão com uma API para manipulação de dados.</li>
      </ul>
    </li>
  </ul>

  <h3>3. Sistema de Autenticação</h3>
  <ul>
    <li>Login e Cadastro de usuários com validações.</li>
    <li>Navegação dinâmica baseada no estado de autenticação.</li>
  </ul>

  <h2>Arquitetura</h2>
  <ul>
    <li><strong>Back-end:</strong> API RESTful desenvolvida em .NET Core, seguindo princípios de arquitetura limpa e desacoplada.</li>
    <li><strong>Front-end:</strong> Interface com Vue.js 3 e integração com a API via chamadas assíncronas (fetch).</li>
    <li><strong>Banco de Dados:</strong> SQL Server com modelagem relacional para gerenciar usuários, cursos e dados associados.</li>
  </ul>

  <h2>Como Rodar o Projeto</h2>
  <h3>Pré-requisitos:</h3>
  <ul>
    <li>Node.js instalado</li>
    <li>.NET SDK 8 ou superior</li>
    <li>SQL Server configurado</li>
  </ul>

  <h3>Configuração do Front-End</h3>
  <ol>
    <li>Instale as dependências:
      <pre><code>npm install</code></pre>
    </li>
    <li>Inicie o servidor de desenvolvimento:
      <pre><code>npm run serve</code></pre>
    </li>
  </ol>

  <h3>Configuração do Back-End</h3>
  <ol>
    <li>Navegue até o diretório do projeto API.</li>
    <li>Configure a string de conexão para o SQL Server no <code>appsettings.json</code>.</li>
    <li>Rode o comando:
      <pre><code>dotnet run</code></pre>
    </li>
  </ol>

  <h3>Banco de Dados</h3>
  <p>
    Certifique-se de ter o banco de dados configurado com as tabelas necessárias antes de iniciar o projeto.
  </p>

  <h2>Links Importantes</h2>
  <ul>
    <li><a href="https://www.figma.com/design/qbgZjwHNS66Yo6doWT2c4n/AcademyCode?m=auto&t=YIPWM08WAoowu7qE-6" target="_blank">Protótipo no Figma</a></li>
    <li><a href="https://drive.google.com/file/d/1B4xEewxXhUN-cBfTUElTwzLO8gJ-ZZuQ/view?usp=sharing" target="_blank">Modelagem do Banco de Dados</a></li>
  </ul>

  <h2>Documentação Técnica do Projeto</h2>
  <h3>Estrutura de Pastas</h3>
  <ul>
    <li><code>/src</code>: Contém todo o código fonte do front-end.</li>
    <li><code>/api</code>: Código fonte da API em .NET Core.</li>
    <li><code>/docs</code>: Documentação e diagramas em Draw.io.</li>
  </ul>

  <h3>Endpoints da API</h3>
  <ul>
    <li><strong>Autenticação</strong>
      <ul>
        <li>POST <code>/api/Usuario/login</code>: Faz o login do usuário.</li>
        <li>POST <code>/api/Usuario/register</code>: Cadastro de novos usuários.</li>
      </ul>
    </li>
    <li><strong>Cursos</strong>
      <ul>
        <li>GET <code>/api/Cursos</code>: Lista todos os cursos disponíveis.</li>
        <li>GET <code>/api/Cursos/{id}</code>: Detalhes de um curso específico.</li>
      </ul>
    </li>
    <li><strong>Usuário</strong>
      <ul>
        <li>GET <code>/api/Usuario/{id}</code>: Retorna os dados do usuário logado.</li>
        <li>PUT <code>/api/Usuario/{id}</code>: Atualiza os dados do usuário.</li>
      </ul>
    </li>
  </ul>

  <h3>Banco de Dados</h3>
  <p>
    O banco segue uma modelagem relacional que inclui as seguintes tabelas principais:
  </p>
  <ul>
    <li><strong>Usuários</strong></li>
    <li><strong>Cursos</strong></li>
    <li><strong>Login</strong></li>
  </ul>

  <h2>Contribuição</h2>
  <p>
    Contribuições são bem-vindas! Se você encontrar algum problema ou tiver sugestões, fique à vontade
    para abrir uma issue ou enviar um pull request.
  </p>

  <h2>Contatos</h2>
  <p>
    Entre em contato pelo e-mail: <a href="mailto:ddouglss1999@gmail.com">ddouglss1999@gmail.com</a>
  </p>

  <p>Desenvolvido por <strong>Douglas Souza Silva</strong>.</p>
</body>
</html>
