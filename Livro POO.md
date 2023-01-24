#                                    Livro Orientação a Objetos 👩🏽‍🚀

​                       ![](https://media2.giphy.com/media/AQRapWCgC7dThyVEYb/giphy.gif?cid=ecf05e47g71icdsmvdpj9c17vielqtj02m9v3sr8z0qoiikm&rid=giphy.gif&ct=g)

####                                                                                              

####  O livro pode ser encontrado [aqui.](https://www.casadocodigo.com.br/products/livro-oo-conceitos)

#### Capítulo 2 : Uma breve história da Orientação a Objetos: 📚

- #### A orientação a objetos nasce na década de 1960, na Noruega;

- #### O principal pioneiro para a Orientação a Objetos foi o conceito de *Simulação*;

- #### Em POO, simulação quer dizer *simular eventos que ocorrem no dia a dia* dentro da computação;

- #### Keith Tocher, em 1967 finaliza o conceito de simulação e através de modelos matemáticos descreve como os computadores entendem a lógica de simulação dos eventos diários;

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

#### A classe é a base, a abstração de um objeto. Criamos as classes para servirem de base para a instanciação de um objeto. (A classe é uma abstração e o Objeto é uma classe instanciada). O objeto é o conceito de uma coisa do mundo real, podendo ser concreta, como um cartão, uma planta, ou abstrata, como uma compra, uma viagem etc. 

#### O operador **new** instancia o objeto e armazena na variável e depois nos referimos ao objeto pelo nome da variável.

#### Na orientação a objetos, quando queremos verificar igualdade, utilizamos o método EQUALS. Não utilizamos os operadores == porque o **Equals** verifica se os objetos estão apontando para o mesmo local da memória. 

#### Toda vez que um new é executado, um novo lugar na memória é reservado para o objeto. E sendo assim, a == retornaria false. 

#### É comum querermos saber se o objeto é instanciado da mesma classe e por isso os equals são muito eficientes. 



## A Representação numérica de um Objeto*️⃣:

#### *Em linguagens orientadas a objeto, o hash de um objeto é muito útil. O hash é um número aleatório gerado que representa o estado do objeto, os valores de seus atributos em determinado momento. Esse número é muito importante para pesquisas que utilizam o padrão table hash, ou tabelas de dispersão.  Dessa forma, o equals auxilia no trabalho de pesquisa do hash. Existem diversas formas de obter o hashcode, mas aqui usaremos a mais comum em Orientação a Objetos em C#. O cálculo do hash deve ser em cima dos mesmos atributos que foram passados no Equals.* 

###### Retornar na página 74 à 78 para entender o hashcode e como calculá-lo



## A Representação padrão de um Objeto 🆎:

#### É quando selecionamos quais os atributos melhor definem aquele objeto. Não é necessário especificar todos os atributos, mas aqueles mais importantes. Exemplo de uma classe livro, um objeto com a representação padrão seria a exibição do Nome do Livro e o seu Autor. Só por estes atributos é possível identificá-lo. 



## Os Tipos de Atributos e Métodos🎆:

### **Existem os de instância e os estáticos.** 

### ATRIBUTOS🦵:

#### Os atributos de instância, são os atributos que contem no objeto e só podem ser utilizados pelo objeto. Em uma classe pessoa, por exemplo, o atributo nome é um exemplo. Mesmo se houver dois objetos com atributos iguais, eles ainda seriam diferentes instâncias da classe, dois casos isolados um do outro, não tendo relação alguma entre si. Embora definidos na classe, só podem ser utilizados pelo objeto. Só poderão ser utilizados e acessados a partir da instância de uma classe.

#### Já o atributo estático é um elemento da CLASSE e não do objeto. Eles são utilizados somente dentro da classe e não é uma boa prática acessa-los pelo objeto. Dessa forma, os comportamentos deles são totalmente opostos ao de instância. Isso quer dizer que seus valores não alteram, porque eles pertencem à classe antes mesmo de existir um objeto. Com isso, objetos distintos terão o mesmo valor para determinado atributo. Usando ainda o mesmo exemplo da classe Pessoa, seria um atributo NumeroDeOlhos. Independente da pessoa, ela terá dois olhos, então este atributo poderia ser estático. Para definirmos um atributo estático, temos de informar que ele é estático, da seguinte forma:

![](https://github.com/majuliah/livrosLidos/blob/main/img/print29.png?raw=true)

### MÉTODOS🏃‍♀️:

#### Os métodos de instância são definidos na classe, mas utilizados via objeto. Como métodos não armazenam valores e sim executam operações, mesmo com objetos distintos ele terá o mesmo comportamento. Ele só pode ser requisitado através do objeto. Por default, todo método é de instância, e para criá-los é da mesma forma:

![](https://github.com/majuliah/livrosLidos/blob/main/img/print30.png?raw=true)

### Independentemente do objeto que será instanciado, o comportamento para todos será o mesmo, que é "falar" Olá.

#### Já o método estático, é um membro da CLASSE e não do objeto, e não pode ser acessado pelo memso. Ele executa uma ação e ela será a mesma independente do objeto. E assim como no atributo, para definirmos um método estático, é necessário informar:

![](https://github.com/majuliah/livrosLidos/blob/main/img/print31.png?raw=true)

#### Os métodos estáticos são para casos onde não precisamos criar um objeto para obtermos aquela operação. Exemplos disso são funções matemáticas como a Math. Com elas não precisamos criar um objeto para obter o cálculo de uma raiz quadrada, por exemplo, com o Math.Pow().

# Mensagens:

#### Uma mensagem é a chamada para ativar um método de instância ou estático. Então quando requisitamos a execução de um método, é chamado de mensagem.

# capítulo 6 - Conceitos Relacionais 🦑

#### Eles são os possibilitadores da criação de classes a partir ou com ajuda de outras classes. Aqui se encaixa os assuntos de **herança**, **associação** e **interface**.

## Herança :🐓🐤🥚

#### É a possibilidade de representar algo que já existe! 

#### Nós herdamos coisas de nossos pais, que herdaram de nossos avós, que herdaram de nossos bisavós e por aí vai. Na Orientação a Objetos, quando queremos herdar, nós fazemos uma classe herdar de outra classe. 

#### Isso quer dizer que uma subclasse herda atributos e métodos de uma superclasse, e a subclasse pode prover seus próprios membros. Ela é uma extensão, ou subtipo de uma superclasse. 

#### É preciso deixar claro que a herança só funciona entre ***classes***. Objetos só existem em tempo de execução, impossibilitando a sua alteração estrutural, portanto **NÃO** existe um objeto herdar algo de outro. As classes, como são de tempo de desenvolvimento ou compilação, podem ter estruturas novas e consequentemente objetos a partir delas. 

#### A herança pode ocorrer em quantos níveis forem necessários porém é uma boa prática termos 4 níveis, porque quanto mais níveis, mais complexo será a compreensão. 

#### Os fundamentos de reúso, vistos anteriormente, é diretamente ligado à herança e também a abstração. Quanto mais abstrata uma classe é, maior a sua usabilidade e reúso.

### Quando uma classe HERDA da outra, ela pode conter NOVOS membros mas não poderá excluir. Quando usamos a herança, dizemos que  um conceito  "é do tipo" de outro conceito. Isso fideliza a possibilidade de representar algo do mundo real na qual estamos modelando.  Quanto mais se sobe na hierarquia, mais geral, e quanto mais desce, mais específico. 

### Só devemos utilizar a herança se a resposta da pergunta "Uma coisa é outra" for verdadeira e um exemplo é um hospital. Uma classe pessoa é criada e as demais herdadas dela. Um médico é uma pessoa? Se sim, então ele pode herdar de pessoa.  Se não for, JAMAIS devemos usar herança. Só utilizamos herança quando o modelo em questão nos traz otimização. 

#### Em C# a herança é feita através dos dois pontos (class Medico : Pessoa) e dessa forma podemos ver que Pessoa é a superclasse e Medico é a subclasse. Em alguns momentos, uma subclasse pode ser a superclasse de outra. Basta mudar o ponto de referência que a hierarquia das classes podem mudar.

#### Na herança uma subclasse tem acesso a todos os membros da superclasse? Sim e Não: No momento podemos dizer que sim, mas na hora em que vermos sobre visibilidade, responderemos que não.



## Tipos de Classes 🎍:

#### Além dos tipos super e subclasse, temos o conceito de abstrata e concreta. 

#### Classe abstrata tem como objetivo principal ser 100% o conceito de abstração. Representam conceitos tão genéricos que não vale a pena trabalhar com eles diretamente, só através de heranças. Estão TÃO incompletos que só devem ser manipulados através de suas subclasses, seus subtipos. Por ter essa característica de serem incompletas, não podem ser instanciadas, não criamos os objetos a partir delas, e ao tentarmos usar o operador new, um erro do compilador informará que a classe não pode ser instanciada. 

#### Elas costumam estar no TOPO da hierarquia, o exemplo do hospital ilustra que a classe Pessoa é uma classe abstrata e só a classe Medico ou Funcionários poderia ser instanciada. Nós inserimos a palavra reservada abstract para implementarmos uma classe abstrata:

![](https://github.com/majuliah/livrosLidos/blob/main/img/print32.png?raw=true)



## MÉTODOS ABSTRATOS ☘️:

#### Ele não deve possuir uma implementação, somente a sua assinatura. Um método abstrato só pode ser definido em uma classe abstrata, e **CLASSES abstratas** não precisam ter somente métodos abstratos, podem ter implementação de métodos normais. Para definirmos métodos abstratos, só adicionamos abstract antes, assim como nas classes. Sua explicação e implementação será  feita quando for explicado polimorfismo. Por padrão, um método não é abstrato e ao final dele, devemos fechá-lo com ; 

#### NÃO existem atributos abstratos, pois isso não faria sentido algum, já que eles servem para prover valores e definir estados do objeto. 

#### É bom procurar, após a leitura do livro, sobre classes anônimas e classes internas, pois são assuntos avançados.

#### **Uma classe concreta que herda de uma classe abstrata** e possuí métodos abstratos é **OBRIGADA** a fazer uso destes métodos. Isso de dá pelo fato de que por as classes abstratas serem de uso direto, se espera que os métodos sejam usados e para tornar isto possível e os comportamentos devem ser especificados. Já se uma classe abstrata herda de outra classe abstrata, os métodos não possuem a obrigatoriedade de utilização.



## Tipos de Herança🐺🐶:

#### Existem dois tipos, a simples e a múltipla:

#### A simples é quando uma subclasse tem apenas uma superclasse. Isso foi o que vimos no tópico acima, então não há necessidade de adentrar novamente no assunto.

#### Agora a múltipla se dá quando a subclasse necessita de mais de uma superclasse. No C#, por motivos de concordância nomilística, não é possível implementar heranças múltiplas. Já em linguagens como C++ é possível. Há um jeito de contornar a necessidade de heranças múltiplas mas só veremos adiante também.



## UP e Downcast 🛫🛬: 

#### Upcast🛫  é uma conversão onde a subclasse é promovida a superclasse, e como a classe filha é do tipo de sua mãe, é um tipo de conversão permitido. A seguir um exemplo: 

![img36](https://github.com/majuliah/livrosLidos/blob/main/img/print36.png?raw=true)

#### Com o código acima conseguimos notar que o upcast é implícito. Automaticamente as subclasses tornam superclasses e não precisamos de outras ações para realizar a operação. 

#### Quando falamos de casts em tipos primitivos de dados, realizamos operações como o cast de um int para um float que é feita de maneira simples. Isso ocorre porque um int cabe dentro de um float e assim é feito com objetos também. Se uma subclasse é subtipo de sua classe mãe, então ela cabe. Dessa forma é possível fazer upcast de maneira implícita com objetos. 

####   O Downcast🛬 é o inverso do up, sendo assim, a superclasse é convertida em subclasse e embora seja permitido, é desencorajado este tipo de operação pois podem ocorrer especializações distintas através de uma generalização. Se voltarmos no conceito do hospital, todo médico e gerente é um funcionário, mas nem todo funcionário é médico ou gerente,m por exemplo. Existem diversos tipos de funcionários e cada um precisa de sua classe referência. A seguir os códigos que ilustram: 

![print37](https://github.com/majuliah/livrosLidos/blob/main/img/print37.png?raw=true)

 #### Aqui o downcast funciona porque a variável funcionario1 armazena um objeto Gerente, embora seu tipo seja Funcionario. É válido porque Gerente herda de funcionario, e na primeira linha foi feita um upcast e na segunda linha um downcast. Na quarta linha é possível encontrar um erro que se dá por a terceira linha ter a variável funcionario2 que armazenam o objeto funcionario e, como dito anteriormente, nem todo funcionario é um gerente.

![img38](https://github.com/majuliah/livrosLidos/blob/main/img/print38.png?raw=true)

 

###### página 112 -> polimorfismo

























 

 





#### 

 



 







####  











 

























