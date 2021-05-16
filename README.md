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
    <li><a href="#tecnologias-implementadas-e-requisitos">Tecnologias implementadas</a></li>
    <li><a href="#cloud">Cloud</a></li>
     <li><a href="#cloud-link">Cloud Link</a></li>
    <li><a href="#acknowledgements">Acknowledgements</a></li>
  </ol>
</details>

<!--#about-the-project-->
## Sobre o projeto

Projeto de teste de conhecimento para criar uma api em .NET 5.0 utilizando as melhores práticas de desenvolvimento, para resolver o 
problema a seguir: 

```ruby
Nossos usuários têm custodia em vários tipos de investimentos, que vem de serviços distintos, para
isso devemos consolidar estes dados e devolver para canais diversos
```

## Como Executar

+ Clonar projeto repositorio git
+ Abrir Visual Staudio 2019 realizar docker build
+ Apos build e publicação acessar o link https://localhost:49159/swagger/index.html

## Tecnologias implementadas e requisitos:

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
 
Pela simplicidade do projeto e tempo de execução foi escolhido uma arquitetura monolitica, já o projeto tem poucas fronteiras.


## Cloud 
Primeira tentativa foi criar WEB API na Azure com Docker em um Container Linux igual no ambiente local podem na 
publicação Azure por causa do Container apresentava o seguinte erro:

> :warning: **#16 sha256:e8c613e07b0b7ff33893b694f7759a10d42e180f2b4dc349fb57dc6b71dcab00 <br />
#16 exporting layers <br />
#16 exporting layers 0.7s done <br />
#16 exporting manifest sha256:1546627a14eef28144f59a9d2c012cc58ee6d0898426f9d781daccda09719452 done <br />
#16 exporting config sha256:2d64152d42ec0c962c724c9e4575d93f3be96fc7b424b5870caeca7ff51033ef done <br />
#16 ERROR: invalid reference format: repository name must be lowercase <br />
error: failed to solve: rpc error: code = Unknown desc = invalid reference format: repository name must be lowercase <br />
Error: buildx call failed with: error: failed to solve: rpc error: code = Unknown desc = invalid reference format: repository name must be lowercase <br />**

Solução foi fazer a publicação em um ambiente Windows padrão(sem Container) na Azure

## Cloud Link
Link Cloud : https://webapiazurejulio.azurewebsites.net/Cliente


[linkedin-url]: https://www.linkedin.com/in/julio-andrade-0b740469/
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
