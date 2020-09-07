# HarryPotterDextraProject


### Para iniciar o projeto mude a connection string, inicie a API e a UI

## Home

![alt text](https://github.com/LucasEInacio/HarryPotterDextraProject/blob/dev/src/HarryPotterProject.UI/app/assets/home.png)

## Character view

1 - Nesta página encontra-se a tela de consulta dos personagens já inseridos e o botão para adicionar um novo. Contendo filtros de Casa e Nome. Ao lado de cada registro há botões para executar as ações na entidade.

![alt text](https://github.com/LucasEInacio/HarryPotterDextraProject/blob/dev/src/HarryPotterProject.UI/app/assets/character-grid.png)

2 - Clicando em Add, pode-se adicionar um novo registro. Os campos obrigatórios ficam em vermelho quando já tocados e não válidos.

![alt text](https://github.com/LucasEInacio/HarryPotterDextraProject/blob/dev/src/HarryPotterProject.UI/app/assets/character-insert.png)

3 - Ao clicar em View será buscado por Id o registro e os controles serão desabilitados para alteração.

![alt text](https://github.com/LucasEInacio/HarryPotterDextraProject/blob/dev/src/HarryPotterProject.UI/app/assets/character-view.png)

4 - Ao clicar em Edit será buscado por Id o registro e poderá ser alterado.

![alt text](https://github.com/LucasEInacio/HarryPotterDextraProject/blob/dev/src/HarryPotterProject.UI/app/assets/SearchId-Edit.png)


## Tecnologias utilizadas

## Backend

- AspNetCore 3.1
- C#
- Entity Framework Core
- Polly (Retry, Circuit Breaker)
- WebApi padrão Rest
- Injeção de Dependência
- Arquitetura em camadas
- Testes de Unidade
- Flunt Notifications

## FrontEnd

- AngularJs
- JavaScript
- BootStrap
- HTML
- CSS

## Pontos de melhoria

- Exibir caixas de confirmação para salvar e excluir os registros.
- Exibir toast para alertar o usuário das ações executadas.

## Desenvolvido por Lucas Inácio