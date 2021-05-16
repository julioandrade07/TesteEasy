[![LinkedIn][linkedin-shield]][linkedin-url]

# Projeto de API Cliente - EasyInvest

<details open="open">
  <summary>Sumario</summary>
  <ol>
    <li>
      <a href="#sobre-o-projeto">Sobre o Projeto</a>
      <ul>
        <li><a href="#como-executar">Como executar</a></li>
      </ul>
    </li>
    <li><a href="#tecnologias-implementadas">Tecnologias implementadas</a></li>
    <li><a href="#cloud">Cloud</a></li>
    <li><a href="#acknowledgements">Acknowledgements</a></li>
  </ol>
</details>

<!--#about-the-project-->
## Sobre o projeto

Projeto de teste de conhecimento para criar uma api em .NET utilizando as melhores práticas de desenvolvimento, para resolver o 
problema a seguir: 

```ruby
Nossos usuários têm custodia em vários tipos de investimentos, que vem de serviços distintos, para
isso devemos consolidar estes dados e devolver para canais diversos
```

## Como Executar

+ Clonar projeto reposiotiro git
+ Abrir Visual Staudio 2019 realizar docker build
+ Abrir https://localhost:49159/swagger/index.html

## Tecnologias implementadas:

- ASP.NET 5.0 (with .NET Core 5.0)
- ASP.NET MVC Core 
- Swagger UI with JWT support
- Docker
- Linux


## Architecture:

Durante a análise do projeto 3 opções de arquitera me surgiram: 

+ Clean architecture
+ Monolithic
+ Arquitetura em Camadas 
 
Pela simplicidade do projeto e tempo de execução foi escolhido um arquitetura monolitica, já o projeto tem poucas fronteiras.


## Cloud 

Primeira tentativa foi criar api Azure
http://api-julio-andrade.azurewebsites.net/swagger/index.html


[linkedin-url]: https://www.linkedin.com/in/julio-andrade-0b740469/
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
