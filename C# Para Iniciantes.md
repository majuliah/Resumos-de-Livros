# Livro C# para iniciantes🧐

### Ele pode ser encontrado através deste [link](https://livrocsharp.com.br) e é gratuito , podendo ser distribuído livremente.🍃

### ![](https://media1.giphy.com/media/SKyeoZj4B5RCg/giphy.gif?cid=790b761120d5b38535c3cd17264a4bc4e9779ade0f9f7c97&rid=giphy.gif&ct=g)

## Capítulo 1 (introdução)📔:

#### Softwares são o resultado de uma compilação de computador. São programas de celulares, computadores e outras plataformas que nos ajudam a automatizar tarefas repetitivas no dia a dia e garantir confiabilidade ao executa-las.  A demanda por profissionais que produzam softwares cresceu bastante nos últimos anos e o mercado expandiu, já que toda empresa atual necessita ao menos de um software para auxiliar nos negócios. 

#### O primeiro passo para se iniciar em uma carreira de desenvolvimento é a escolha da plataforma e da linguagem. Tendo isso em mãos, podemos seguir para o próximo passo. 

#### O C# é uma linguagem de programação moderna, robusta, tipada e Orientada a Objetos. Com ela é possível criar aplicativos de computadores e celulares, sites para a web, suporte para aplicativos em nuvem, inteligência artificial, sistemas embarcados, jogos e muito mais. Ele tem raízes na linguagem C, C++ e foi criada pela Microsoft com o objetivo de desenvolver sistemas para Windows e ao longo do tempo foi evoluindo e hoje é suportada e utilizada para plataformas como Linux e Mac. Além disso todo o ecossistema é open-source.

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

![](https://github.com/majuliah/livrosLidos/blob/main/img/print5.png?raw=true)

#### 🌍 No print acima, só temos as propriedades da classe que podem ser utilizadas, mas não temos os métodos, que são as ações própriamente ditas para serem executadas. Os métodos representam as ações dos atores. Agora vamos alterar os métodos para possibilitar a gerente aprovar as horas de um funcionário informando o CPF do funcionário. 

![](https://github.com/majuliah/livrosLidos/blob/main/img/print6.png?raw=true)



## **OBJETOS**🐱‍👓

#### As classes são abstrações da vida real dentro de um programa, ou seja, descrevem através de códigos quais os atores e as ações refletidas ao mundo real. Sabemos que as classes tem métodos(ações) e propriedades mas não sabemos como o computador trata o processamento dessas informações e aqui entram os ***Objetos***. Um objeto nada mais é que a compilação do código escrito e sendo colocado na memória para que seja interpretado e executado. 

#### O processo de criar o objeto e alocá-lo na memória é denominado ***Instanciamento de Classe***.  Aqui temos um exemplo de código deste processo:



![](https://github.com/majuliah/livrosLidos/blob/main/img/print7.png?raw=true)

#### A palavra new no C# é reservada por analisar o código feito na classe e então disponibilizar na memória do computador para utilização. Basicamente a palavra new cria o objeto.  Após instanciar a classe (criar o objeto), é possível analisar quais atributos e métodos estão vinculados. Podemos acessar com um . no fim da variável. 

![](https://github.com/majuliah/livrosLidos/blob/main/img/print8.png?raw=true)



## **VARIÁVEIS**🐱‍👓

#### Variáveis são pequenos espaços da memória em que você pode atribuir valores. Elas podem ser alteradas ao longo do processamento do programa. No C# as variáveis tem tipos específicos e precisamos atribuir a elas estes tipos.



## Capítulo 3 (Funções internas do C#)📔:

#### Métodos internos nos permitem manipular textos, datas, operações matemáticas e precisamos destas funcionalidades para resolver problemas no dia a dia.

- ## Funções de texto:

  #### Usadas para manipular *strings*. Podemos limpar espaços, obter quantidade de caracteres, transformar tudo para minúscula ou maiúscula, trocar conteúdos e centenas de outras possibilidades. Faremos alguns exemplos, e como estamos usando funcionalidades somente do console, a interação para exibir informações na tela se dá através dos comandos ***Console.WriteLine***("Expressão aqui dentro"); No entando, o código fica muito grande e podemos contornar isso na lista de using e referenciar o namespace deste comando de forma estática e usar apenas o WriteLine("Expressão"). Isso está explícito na primeira linha do programa. Somente pode ser utilizado na MAIN(arquivo principal) E tudo que estiver dentro do namespace citado poderá usar a froma abreviada do console, deste jeito:

  ![](https://github.com/majuliah/livrosLidos/blob/main/img/print9.png?raw=true)

  

- ## ***TRIM***

  #### Método que retira todos os espaços em branco antes e depois de uma expressão. Mas para espaços no meio da expressão, precisamos escrever um método que faça isto e não é o caso do TRIM. Geralmente é utilizado em cadastros onde usuários precisam entrar com informações ou até mesmo em caso de trazer informações de outros arquivos de texto, CSV, Excel, dados exportados de banco de dados... Nos ajuda muito a capturar apenas expressão em si.

  ![](https://github.com/majuliah/livrosLidos/blob/main/img/print10.png?raw=true)

  

  	#### Como o C# não aceita mais de um SVM (Static Void Main) por projeto, precisamos abrir o arquivo com a extensão csproj e adicionar uma linha <StartupObject> nomeDoNamespace.funcoesTexto</> e DEBUGAR o arquivo. Assim o C# executará normalmente aquele arquivo.  

  

  - ## LENGTH

    #### Método que conta a quantidade de caracteres ou espaços da memória usadas para formar aquela string. Conta quantidade de caracteres incluindo espaços. É bastante usado quando queremos definir um tamanho limite de caracteres que um usuário pode entrar. Um exemplo são os endereços. Geralmente são usados 50 caracteres para endereçar, e se passar disso os dados não são gravados, só são gravados os 50 primeiros. Vamos testar na variável empresa:

    ![](https://github.com/majuliah/livrosLidos/blob/main/img/print11.png?raw=true)

  

  - ## TOUPER / TOLOWER

    #### Transforma todas as expressões em somente maiúsculo. Usado em casos de formatação, onde queremos chamar atenção de nomes, cargos ou informações importantes. Basta informar a cadeia desejada seguida do método ToUpper().

    #### ToLower transforma a sentença em minúsculo. Também usado para formatações de textos e conversões dos valores de variáveis. Cadeia desejada seguida de ToLower();

    ![](https://github.com/majuliah/livrosLidos/blob/main/img/print12.png?raw=true)

    

    #### Importante ressaltar que para a linguagem C#, comparar expressões com conteúdos iguais, nem sempre teremos resultados iguais. 

    ![](https://github.com/majuliah/livrosLidos/blob/main/img/print13.png?raw=true)

    

    #### No caso dois, se a variável que está tudo em maiúsculo passar pela função ***toLower***, e ficar com tudo minúsculo, ela vai ser igual a variavel ***nomeLower***? Sim. 

    

    ![](https://github.com/majuliah/livrosLidos/blob/main/img/print14.png?raw=true)

    #### No caso três: Estamos comparando entre as duas variáveis***.Equals***. Mas no entando, está explícito para ignorar maiúsculas e minúsculas. O uso do ***StringComparison*** nos permite definir o tipo de comparação. No caso o tipo de comparação é o ***OrdinalIgnoreCase***.

    #### Importante ressaltar que quando fazemos interações com o usuário em mecanismos de pesquisa, convém converter tudo para ***Upper*** ou ***Lower*** e depois comparar para que o resultado não seja diferente. Melhor ainda é definir o tipo de comparação com o ***StringComparsion***. 

    

    - ## REMOVE

      #### Serve para pegar uma quantidade de caracteres à esquerda de uma expressão. Exemplo, os 10 primeiros caracteres. Vamos pegar a variável empresa e pedir apenas os 5 primeiros caracteres da sentença. 

      ![](https://github.com/majuliah/livrosLidos/blob/main/img/print15.png?raw=true)

      #### Ele retornou "Meu" como o pedido no remove. Depois disso fizemos um array com 3 nomes completos e montamos um looping para que retornasse apenas o primeiro nome de cada elemento.  A cada interação do looping ele pega o nome completo e pesquisa a posição do espaço em branco. Por exemplo, o primeiro nome tem 8 letras, então ele usa o remove para extrair somente a quantidade de caracteres antes do espaço.

    - ## REPLACE

    #### Usado para substituir cadeias de expressões. São dois parâmetros: qual texto iremos substituir e qual o conteúdo da substituição; Casos comuns são para tratamentos de dados, como por exemplo troca de endereços.

    ![](https://github.com/majuliah/livrosLidos/blob/main/img/print16.png?raw=true)

    

  - ## SPLIT

    #### Muito usado em situações de tratamento de dados de arquivos de texto onde é preciso separar cadeias de caracteres através de um caractere chave. Mais usado é o espaço, mas pode ser qualquer outra coisa, como uma vírgula por exemplo.

    ![](https://github.com/majuliah/livrosLidos/blob/main/img/print17.png?raw=true)

    #### 

     #### No exemplo nós criamos uma variável nivelLivro e atribuímos a ela uma sentença(uma frase). Depois criamos um vetor blocos e dentro do vetor atribuímos as palavras da frase nivelLivro. Então toda palavra vai para uma posição no vetor. Ele reconhece que é uma palavra porque toda vez que dá espaço ele capta aquela string. 
    
    #### Então fizemos um forEach. Para cada expressão dentro do array blocos, nós vamos printar a palavra. Depois usamos o Count()  para contar quantos elementos tem dentro daquele array.

  

  

  - ## SUBSTRING

    #### Método substring extrai um texto se você infomar qual a posição inicial. Pode-se ou não informar o tamanho do texto que se quer captar e se não informarmos, todo o texto a partir da primeira posição informada será capturado.  Veja o caso da variável nivelLivro:

    ![](https://github.com/majuliah/livrosLidos/blob/main/img/print18.png?raw=true)

    #### Pegamos o conteúdo e ditamos que a posição inicial era 5 e a final 14, o que resultou na frase "livro é basi". Agora vejamos o caso do array de compras, como fazemos para extrair somente os nomes das frutas, sem as quantidades? 

    #### ![](https://github.com/majuliah/livrosLidos/blob/main/img/print19.png?raw=true) 
  
    ## O que aconteceu aqui? 🤔
  
    #### Criamos um looping foreach. Cada iteração a gente precisa saber qual a posição do primeiro espaço em branco, e para isso usamos o fruta.IndexOf(" "). Aqui estamos pedindo o índice do espaço em branco dentro do frutas. Somando +1, estamos querendo a próxima posição, ou seja, o nome da fruta. Depois do espaço vem o nome das frutas então é isso que estamos fazendo. Então temos a posição inicial da sentença que queremos. Como não estamos informando quantos caracteres queremos, o Substring retorna o nome completo da fruta. Em outras palavras, pegamos qualquer coisa após o número (hehehe) 
  
    ## Agora um desafio. Como fazer para somar todas as quantidades de frutas contidas na cesta? 🤔
  
    ![](https://github.com/majuliah/livrosLidos/blob/main/img/print20.png?raw=true)
  
  #### Aqui nós fizemos: Criamos uma variável para receber a quantidade. A quantidade recebe ela mesma mais a conversão do primeiro caractere da sentença para inteiro. o limite é o espaço, então ele só vai pegar o número. Que é da primeira posição até o espaço. Como já sabemos que as quantidades estão na primeira posição, conseguimos montar esta lógica. 
  
  

- ## ISNULLOREMPTY:

  #### Este método verifica se a string está nula ou vazia. Muito usado com interação com usuários, a fim de garantir que ele insira os dados requeridos. Também usados em casos de manipular um objeto entre as camadas de acesso a dados e interface. 
  
  ### No C#, o uso de dois && é para quando temos mais de duas condições a serem avaliadas. Quando a primeira condição não atende ao critério, as outras não chegam nem a ser lidas. Quando temos somente um &, as outras são avaliadas. É como se fosse uma barreira.
  
  
  
  ![](https://github.com/majuliah/livrosLidos/blob/main/img/print21.png?raw=true)



- ## FUNÇÕES DATAS:

  #### As funções datas nos permite manipular qualquer informação de uma data, contanto que esteja no modelo DateTime contendo o dia, mês e ano. Conseguimos fazer operações, adicionar, subtrair, dias, meses e anos, aplicar formatação customizada, obter a data e a hora completa do sistema operacional, converter isso pra texto, ler texto e converter em data e muito mais. 

- ## DateTime:

  #### No C#, uma hora, data, minuto, segundo e ticks dependem do datetime. Todos estes são conhecidos, exceto os Ticks que é um tipo Long que permite atribuir um  número para: MILISEGUNDO E ***NANOSEGUNDO***.

  1. 	#### Uma data é composta por um dia (1 a 31), um mês (1 a 12) e um ano (valor inteiro). A entrada será na ordem de Ano, mês e dia, reespectivamente.

  2. #### Precisamos fazer formatação das datas:

  3. ![](https://github.com/majuliah/livrosLidos/blob/main/img/print22.png?raw=true)

  

  

  - ## TODAY
  - Function that works



























##  











 

####  































