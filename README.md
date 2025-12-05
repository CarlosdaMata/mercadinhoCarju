<h1>Dupla</h1>
<h3>Carlos Eduardo da Mata Coelho</h3>
<h3>Ana Julia Marques do Prado</h3>

<h1>Explicação</h1>

<h4>Produto.cs<h4/>
<p>Define a classe de domínio Produto que representa um produto no sistema.</p>
<p>Declara propriedades: Prodid (int), Prodnome, etc...</p>
<p>É utilizado o método get set</p>

<h4>HomeController.cs</h4>

<p>Define ações e rotas para páginas como Home, Index, Sobre, Contato, etc. Controla o fluxo entre o usuário e as views.</p>

<p>HomeController: Nome do controller.</p>
<p>Index(): Ação executada quando o usuário acessa / ou /Home/Index.</p>
<p>return View(): Renderiza a View correspondente</p>

<h4>appsettings.json</h4>

<p>Cria a string de conexão</p>

<h4>ProdutoController</h4>

<p>Faz a conexão com o mysql e envia os dados para o banco</p>
