# Livro C# para iniciantes🧐

### Ele pode ser encontrado através deste [link](https://livrocsharp.com.br) e é gratuito , podendo ser distribuído livremente.🍃

### ![](https://media1.giphy.com/media/SKyeoZj4B5RCg/giphy.gif?cid=790b761120d5b38535c3cd17264a4bc4e9779ade0f9f7c97&rid=giphy.gif&ct=g)

## Capítulo 1 (introdução)📔:

#### Softwares são o resultado de uma compilação de computador. São programas de, celulares, computadores e outras plataformas que nos ajudam a automatizar tarefas repetitivas no dia a dia e garantir confiabilidade ao executa-las.  A demanda por profissionais que produzam softwares cresceu bastante nos últimos anos e o mercado expandiu, já que toda empresa atual necessita ao menos de um software para auxiliar nos negócios. 

#### O primeiro passo para se iniciar em uma carreira de desenvolvimento é a escolha da plataforma e da linguagem. Tendo isso em mãos, podemos seguir para o próximo passo. 

#### O C# é uma linguagem de programação moderna, robusta, tipada e Orientada a Objetos. Com ela é possível criar aplicativos de computadores e celulares, sites para a web e jogos para diversas plataformas. Ele tem raízes na linguagem C, C++ e foi criada pela Microsoft com o objetivo de desenvolver sistemas para Windows e ao longo do tempo foi evoluindo e hoje é suportada e utilizada para plataformas como Linux e Mac. Além disso todo o ecossistema é open-source.  Com o C# podemos criar softwares em sistemas nuvem, websites, aplicações web, portais e muitos outros.

#### Para realizar os exemplos deste livro, eu usarei a IDE [Raider](https://www.jetbrains.com/pt-br/rider/) da JetBrains.

![Rider: o IDE .NET de plataforma cruzada da JetBrains](https://resources.jetbrains.com/storage/products/rider/img/meta/rider_logo_300x300.png)

#### Além de linguagens de programação e IDE's, é necessário utilizar frameworks (abstração de funcionalidades que são criadas e distribuídas pela comunidade dev pra uso das funcionalidades e recursos do ambiente de compilação). No caso do C# será utilizado o [.NET](https://www.youtube.com/watch?v=hlgm_1Bzt-4) , que atualmente é uma iniciativa da Microsoft de criar somente um ambiente unificado de desenvolvimento e execução de sistemas. Todo código gerado em .NET pode ser executado em qualquer dispositivo que tenha o framework instalado. Basicamente, o .NET Framework possui duas ferramentas principais, o **CLR** *-Common Language Runtime-* que é um ambiente de execução independente de linguagem. Ele executa diversas delas e fornece gerenciamento de memória, controle e exceção, manipulação de processos concorrentes, reflexão, segurança serviços de compilação pra arquiteturas específicas e etc. Além do **CLR**, temos o **CIL** *-Common Intermediate Language-* que é uma linguagem de baixo nível (nível de máquina, a que o computador entende). É um código Orientado a Objeto e executado por uma máquina virtual.  

## Funciona da seguinte forma:🐱‍🏍

#### Programadores escrevem o código-fonte em alguma linguagem, como C#, F#, entre outras. Esse código é transformado em um Assembly IL Code que é convertido pra CLR. A CLR unifica todos os códigos de diferentes linguagens pra somente uma interpretação (como se um japonês falasse com um norueguês em uma linguagem como o inglês) e dessa linguagem é convertido pra linguagem de máquina, a que o computador entende e compila que é a do sistema nativo do SO. Assim que todo o processo foi executado, a execução do programa é feita pelo framework e o software consegue executar as instruções. Uma imagem que represente isso: 

![](https://github.com/majuliah/livrosLidos/blob/main/img/print1.png?raw=true)

Figura 3 retirada do livro.



## Capítulo 2 (Conceitos Básicos do C#)📔:

## **NAMESPACES**🐱‍👓

#### Eles são usados para o propósito de separação e organização de código. Geralmente podem conter os seguintes membros:

- [x] **Classes**
- [x] **Interfaces**
- [x] **Estruturas**
- [x] **Delegates**

#### Os namespaces servem pra organizar a nossa área de trabalho em uma IDE. Separamos arquivos por funções específicas e assim mantemos a organização. Nos ajudam a deixar diferentes tipos, mas relacionados no mesmo lugar. Se criarmos duas classes com o mesmo nome dentro de um namespace, haverá conflito. Você pode criar classes com o mesmo nome em diferentes namespaces. Aqui um exemplo de erro por duplicação de nomes de classes em um mesmo namespace:

![](https://github.com/majuliah/livrosLidos/blob/main/img/print2.png?raw=true)

#### Como podemos ver, temos dentro de um mesmo namespace duas classes Program. Basta alterar o nome da classe que não haverá mais erro 🐱‍🏍

![](https://github.com/majuliah/livrosLidos/blob/main/img/print3.png?raw=true)

#### Agora podemos criar novas classes em namespaces e chamá-las para dentro de outras namespaces como a seguir:

![](https://github.com/majuliah/livrosLidos/blob/main/img/print4.png?raw=true)

#### Desse jeito, informamos ao programa em qual namespace estamos buscando as informações que queremos usar no namespace atual. Uma boa prática recomendada por devs e pela própria Microsoft é colocar o nome dos projetos da seguinte forma:                                                                                                                                                                                                                          ***NomeDaEmpresa.NomeDoProjeto.CamadaDoProjeto.Funcionalidade*** 



## **CLASSES**🐱‍👓

#### Antes de começarmos, usaremos alguns conceitos de UML para entendermos classes, como ATORES que significa toda e qualquer pessoa que utiliza o software que está sendo desenvolvido. Por exemplo, uma funcionária do caixa, ou uma gerente. Os processos são todas as ações executadas por este ator. A análise de domínio de negócio nos ajuda a saber quem é quem e o que faz. No programa, as classes são a forma de representarmos estes atores e processos.

#### 🗺️A classe é uma abstração do mundo real. Ela modela quais atores e ações executam as tarefas. Eles possuem características comuns como nome, idade, cpf e dessa forma, as classes precisam refletir estas propriedades. Criaremos uma classe para exemplo:







##  











 

####  































