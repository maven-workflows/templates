# Java Spring Boot Template

Este é um template para criar aplicações Java utilizando o framework Spring Boot. Ele foi projetado para ser flexível e fácil de usar, permitindo que desenvolvedores iniciem rapidamente novos projetos com uma estrutura bem definida.

## Recursos do Template

- **Estrutura de projeto organizada**: Segue as melhores práticas do Spring Boot.
- **Configuração inicial**: Inclui dependências essenciais para desenvolvimento de APIs REST e testes.
- **Exemplo de controlador REST**: Um exemplo funcional para ajudar no desenvolvimento inicial.
- **Testes unitários configurados**: Inclui exemplos de testes para garantir a qualidade do código.
- **Pronto para integração com Backstage**: Pode ser usado como base para serviços gerenciados no Backstage.

## Estrutura do Projeto

```
. 
├── src 
│   ├── main 
│   │   ├── java 
│   │   │   └── com.example.template 
│   │   │       ├── TemplateApplication.java # Classe principal da aplicação 
│   │   │       └── HelloController.java # Exemplo de controlador REST 
│   │   ├── resources 
│   │   │   └── application.properties # Configurações da aplicação 
│   ├── test 
│   │   ├── java 
│   │   │   └── com.example.template 
│   │   │       ├── HelloControllerTest.java # Testes unitários para o controlador 
│   │   │       └── TemplateApplicationTests.java # Testes para a aplicação 
├── pom.xml # Configuração do Maven 
└── README.md # Documentação do template
```

## Pré-requisitos

Certifique-se de ter os seguintes softwares instalados:

- **Java**: Versão 17 ou superior.
- **Maven**: Para gerenciar dependências e construir o projeto.
- **Git**: Para controle de versão.

## Como Usar

### Passo 1: Clonar o Template

Clone este repositório para sua máquina local:

```bash
git clone https://github.com/seu-usuario/seu-repositorio.git
```

### Passo 2: Configurar o Projeto

Atualize os seguintes arquivos conforme necessário:

- `pom.xml`: Configure o `groupId`, `artifactId` e `version` do projeto.
- `application.properties`: Adicione configurações específicas da sua aplicação.

### Passo 3: Executar a Aplicação

Navegue até o diretório do projeto e execute os comandos abaixo:

```bash
mvn spring-boot:run
```

A aplicação estará disponível em [http://localhost:8080](http://localhost:8080).

### Passo 4: Testar a Aplicação

Execute os testes unitários para garantir que tudo está funcionando corretamente:

```bash
mvn test
```

## Exemplos de Uso

### API REST

O template inclui um exemplo de controlador REST (`HelloController`) com os seguintes endpoints:

- `GET /hello`: Retorna uma mensagem de boas-vindas.
- `GET /names`: Retorna uma lista de nomes.

### Configuração de Propriedades

O arquivo `application.properties` permite configurar facilmente:

- Porta do servidor (`server.port`).
- Configurações de banco de dados (se necessário).

## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou enviar pull requests.

## Licença

Este projeto está licenciado sob a MIT License.