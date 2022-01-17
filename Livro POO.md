#                                    Livro Orientação a Objetos 👩🏽‍🚀

​                       ![](https://media2.giphy.com/media/AQRapWCgC7dThyVEYb/giphy.gif?cid=ecf05e47g71icdsmvdpj9c17vielqtj02m9v3sr8z0qoiikm&rid=giphy.gif&ct=g)

####                                                                                              

####  O livro pode ser encontrado [aqui.](https://www.casadocodigo.com.br/products/livro-oo-conceitos)

#### Capítulo 2 : Uma breve história da Orientação a Objetos: 📚

- #### A orientação a objetos nasce na década de 1960, na Noruega;

- #### O principal pioneiro para a Orientação a Objetos foi o conceito de *Simulação*;

- #### Em POO, simulação quer dizer simular eventos que ocorrem no dia a dia dentro da computação;

- #### Keith Tocher, em 1967 finaliza o conceito de simulação e através de modelos matemáticos, descreve como os computadores entendem a lógica de simulação dos eventos diários;

-  #### A simulação discreta usa eventos lógicos e matemáticos para representar mudanças do estado através do tempo. A POO se deriva dela porque se preocupa com a mudança de estado, alterações de informações ao longo do processamento. Aprecia a troca de informações para gerar informações.

- #### A primeira linguagem de programação orientada a objetos se chama *SIMULA 67*;

- #### SmallTalk-71 é criada com o propósito de unificar a orientação a objetos para ser compilada em diferentes sistemas, já que as linguagens já existentes eram para uso do próprio sistema em que foram criadas;

### 🦩O Paradigma de Programação Estruturada defende que é possível através de 3 estruturas básicas, representar todo e qualquer processo do mundo real. São eles:

1. #### *Sequência:* O programa é uma sequência finita de passos. Deve ser executado linearmente, um comando após o outro. Todos os passos devem ser feitos para programar o algoritmo desejado. 

2. #### *Decisão:* Um determinado conjunto de código pode ou não ser executado. É necessário testes lógicos para a tomada de decisão. (IF/ELSE - SWITCH/CASE)

3. #### *Iteração*: Uma determinada parte do código pode ser executada uma quantidade finita de vezes, dentro de um looping. (FOREACH, DO-WHILE, WHILE, FOR, REPEAT-UNTIL)

#### 0️⃣Inicialmente, para problemas simples, pode-se acreditar que somentes estas 3 estruturas são o suficiente para manter um programa. Mas quanto maior a complexidade do sistema, menos útil a programação sequencial se torna. 

#### 1️⃣Dentro da Orientação a Objetos temos o conceito de Reutilização. Dessa forma, podemos criar trechos de códigos universais que podem ser chamados e executar funções automaticamente. Isso evita a duplicação de código, deixa a estrutura mais limpa e organizada e evita falhas. Elimina a necessidade de importações de bibliotecas e torna o processo mais limpo.

#### 2️⃣O conceito de Coesão passa que uma unidade de código somente deve executar funções e atividades e possuir informações relacionadas ao que ela se propõe a fazer. Isso quer dizer que não deve se misturar responsabilidades e manter as obrigações muito separadas e organizadas.

#### 3️⃣O conceito de Acoplamento é o termo para quantificar os relacionamentos entre as unidades de código, para que quando acopladas, possam executar o programa de forma precisa e eficiente. O acoplamento anda muito junto com a coesão. Com códigos coesos podemos fazer acoplamentos mais eficientes, dividindo responsabilidades semelhantes.

# Introdução a Orientação a Objetos 🥰

### Abstração:

#### Se dá ao fato de termos um molde para qual podemos evoluir posteriormente. Exemplo é uma fábrica de cadeira, onde temos o molde inicial e podemos usá-lo para fazermos diferentes cadeiras.

### Reutilização:

#### Conseguimos deixar o programa mais limpo através de reutilização de códigos. Isso pode ser feito através de heranças, onde herdamos comportamentos de classes dentro de outras para a não repetição de códigos. Associação é quando uma classe utiliza partes de outra classe. Essa troca evita repetições desnecessárias.

### Encapsulamento:

#### Quando precisamos apenas de resultados com fórmulas complexas já prontas. Também cria uma casca em volta do objeto, impedindo alterações externas. 



##     CLASSE🕵🏽‍♀️

#### É a unidade mínima e inicial da orientação a objetos. É uma estrutura que abstrai um conjunto de objetos com características semelhantes. Ela determina o comportamento do objeto através dos métodos e o estado através dos atributos. A classe define, é a base com tudo o que é necessário para a criação de um objeto. Ela é um molde, que diz como as informações são trabalhadas e manipuladas.

#### A classe também pode ser definida como a abstração de uma entidade, seja ela física ou abstrata de coisas que existem no mundo real. Classes com nome pobremente dados podem gerar problemas de entendimentos futuros no código. Ela deve ser bem definida e só conter atributos e métodos que lhe dizem respeito.

![](https://github.com/majuliah/livrosLidos/blob/main/img/print23.png?raw=true)

##     ATRIBUTO 🐲

#### Informações que são manipuladas dentro das classes. São as características, os valores, informações de uma classe. São as informações que uma determinada classe pode manipular.

![](https://github.com/majuliah/livrosLidos/blob/main/img/print24.png?raw=true)

##     MÉTODO 🤹🏽‍♀️

#### São as ações que as classes vão executar. Eles exigem um retorno e assim como os atributos, devem ser específicos e bem definidos. Os métodos manipulam os atributos. São responsáveis por definir e executar certos comportamentos. 

#### Void: É a forma de informarmos que o método não vai retornar nada.

![](https://github.com/majuliah/livrosLidos/blob/main/img/print25.png?raw=true)





#### Podemos, dentro de uma única classe, ter quantos métodos precisarmos ou desejarmos. Os métodos também podem trabalhar em conjunto entre si, sendo chamados um dentro do outro. Mas, além disso, existem dois métodos especiais:



## Dois métodos especiais✨:

#### Como já foi dito, podemos ter quantos métodos precisarmos, mas existem os métodos **construtores** e **destrutores**.

### CONSTRUTOR🚜: 

#### O método construtor constrói, cria o objeto da classe em questão. Sempre que precisar criar um objeto da classe, o construtor é iniciado. É partindo do construtor que será possível criar um objeto daquela classe e dessa forma manipular os atributos e métodos de forma efetiva. Construtores provém valores iniciais que o objeto precisa ter no começo, antes de ser instanciado. O nome de um construtor é idêntico ao da classe e nele se omite o retorno, até mesmo o void. 

#### Se um construtor pertence a uma determinada classe e a função dele é criar objetos a partir dela, logo seu retorno será objetos do tipo da classe. Por isso não precisamos definir retorno algum. Em C# e JAVA, os construtores são implícitos, assim podemos utilizar eles até mesmo sem declarar.

![](https://github.com/majuliah/livrosLidos/blob/main/img/print26.png?raw=true)

### DESTRUTOR:

#### Ao contrário do construtor, o destrutor desfaz um método construtor. Ele serve para simplesmente eliminar o método ou desfazer cargas de processamento que se tornaram inutilizadas após um período de processamento. A mesma regra de implícito dos construtores também de aplicam aos destrutores. 



![](https://github.com/majuliah/livrosLidos/blob/main/img/print27.png?raw=true)





## SOBRECARGA DE MÉTODO: 🐇

#### A sobrecarga de método é o fato de precisarmos de diferentes parâmetros para os processamentos. Ou seja, sempre que a quantidade, ordem ou tipo dos parâmetros muda, temos uma sobrecarga de métodos. O exemplo abaixo simula a área de um quadrilátero. Para diferentes tipos, temos diferentes operações:

![](https://github.com/majuliah/livrosLidos/blob/main/img/print28.png?raw=true)

#### Atributos e métodos também são chamados de membros. Sempre que se ouvir membros da classe ou membros do objeto, estamos nos referindo a eles.

# O OBJETO🎃:

### O objeto é a instância de uma classe. Isso significa que:

#### A classe é a base, a abstração de um objeto. Criamos as classes para servirem de base para a instanciação de um objeto. (A classe é uma abstração e o Objeto é uma classe instanciada). O objeto é o conceito de uma coisa do mundo real, podendo ser concreta, como um cartão, uma planta, ou abstrata, como uma compra, uma viagem, etc. 

#### O operador new instancia o objeto e armazena na variável e depois nos referimos ao objeto pelo nome da variável.

#### Na orientação a objetos, quando queremos verificar igualdade, utilizamos o método EQUALS. Não utilizamos os operadores == porque o Equals verifica se os objetos estão apontando para o mesmo local da memória. 

#### Toda vez que um new é executado, um novo lugar na memória é reservado para o objeto. E sendo assim, a == retornaria false. 

#### É comum querermos saber se o objeto é instanciado da mesma classe e por isso os equals são muito eficientes. 



## A Representação numérica de um Objeto*️⃣:

#### Em linguagens orientadas a objeto, o hash de um objeto é muito útil. O hash é um número aleatório gerado que representa o estado do objeto, os valores de seus atributos em determinado momento. Esse número é muito importante para pesquisas que utilizam o padrão table hash, ou tabelas de dispersão.  Dessa forma, o equals auxilia no trabalho de pesquisa do hash. Existem diversas formas de obter o hashcode, mas aqui usaremos a mais comum em Orientação a Objetos em C#. O cálculo do hash deve ser em cima dos mesmos atributos que foram passados no Equals. 

#Retornar na página 74 à 78 para entender o hashcode e como calculá-lo



## A Representação padrão de um Objeto 🆎:

#### É quando selecionamos quais os atributos melhor definem aquele objeto. Não é necessário especificar todos os atributos, mas aqueles mais importantes. Exemplo de uma classe livro, um objeto com a representação padrão seria a exibição do Nome do Livro e o seu Autor. Só por estes atributos é possível identificá-lo. 



## Os Tipos de Atributos e Métodos🎆:





 







####  











 

























