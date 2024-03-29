#                                    Livro Orientação a Objetos 👩🏽‍🚀🪐

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

### 🦩O Paradigma de Programação Estruturada defende que é possível através de 3 estruturas básicas representar todo e qualquer processo do mundo real. São eles:

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

#### É comum querermos saber se o objeto é instanciado da mesma classe e por isso os *equals* são muito eficientes. 



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

####   O Downcast🛬 é o inverso do up, sendo assim, a superclasse é convertida em subclasse e embora seja permitido, é desencorajado este tipo de operação pois podem ocorrer especializações distintas através de uma generalização. Se voltarmos no conceito do hospital, todo médico e gerente é um funcionário, mas nem todo funcionário é médico ou gerente por exemplo. Existem diversos tipos de funcionários e cada um precisa de sua classe referência. A seguir os códigos que ilustram: 

![print37](https://github.com/majuliah/livrosLidos/blob/main/img/print37.png?raw=true)

 #### Aqui o downcast funciona porque a variável funcionario1 armazena um objeto Gerente, embora seu tipo seja Funcionario. É válido porque Gerente herda de funcionario, e na primeira linha foi feita um upcast e na segunda linha um downcast. Na quarta linha é possível encontrar um erro que se dá por a terceira linha ter a variável funcionario2 que armazenam o objeto funcionario e, como dito anteriormente, nem todo funcionario é um gerente.

![img38](https://github.com/majuliah/livrosLidos/blob/main/img/print38.png?raw=true)

 

## Polimorfismo💀☠️👻:

#### A exemplificação de polimorfismo é a necessidade e capacidade de alterar o comportamento de uma classe para que a mesma se adeque ao que está proposto a ser feito.  

#### Em determinado momento em meio a hierarquia de classes, um mesmo método precisará se comportar de maneira diferente dependendo do objeto instanciado, que se dá pela flexibilidade que a hierarquia de classes deseja fornecer.  A vantagem do polimorfismo é utilizar objetos diferentes e ainda executar a mesma ação polimórfica.  

#### O polimorfismo é utilizado de melhor forma quando aplicado para alterar métodos abstratos, que como visto anteriormente, é obrigatório a sua utilização na herança. Dessa forma podemos somente criar assinaturas dos métodos e personalizar as sequências de códigos dentro de subclasses. A seguir um exemplo:

```c#
class Anestesista : Medico
{
    override void Operar()
    {
    //passos seguidos por um anestesista    
    }
}

class Obstetra : Medico
{
    override void Operar()
    {
        //passos executados por um obstetra
    }
}

class Pediatra : Medico
{
    override void Operar()
    {
        //passos seguidos por um pediatra
    }
}
```

#### Acima podemos perceber que o uso do polimorfismo só necessita de um método abstrato da superclasse. A relação entre polimorfismo e herança se dá porque, para existir polimorfismo é necessário que tenha herança, algo herdado para ser alterado, personalizado. 

#### Somente através do polimorfismo que conseguimos prover comportamentos para os métodos criados, partindo da necessidade que a subclasse tenha de moldar um método que seja mais coerente. Só é recomendado o uso do polimorfismo se necessário. 

#### A sobescrita se dá quando algo é reescrito. Também é utilizada quando é necessário alterar um comportamento herdado e dessa forma o método é redefinido. Dessa forma os métodos da superclasse são substituídos pelos métodos da subclasse.   

### 																		

```tex
							  POLIMORFISMO vs. SOBRESCRITA
```

#### Do ponto de vista da implementação, o polimorfismo e sobrescrita são a mesma coisa. Mas conceitualmente são diferentes. Uma sobrescrita reescreve algo existente que no caso é o método padrão da superclasse que podemos alterar de acordo com a necessidade. No polimorfismo não há necessidade de haver um comportamento padrão porque geralmente o método que sofrerá polimorfismo é abstrato, que visto anteriormente, necessita ser instanciado. 

#### Desta forma, uma sobrescrita é um polimorfismo porque estamos propondo algo novo de acordo com a subclasse, mas o contrário é falso, um polimorfismo não é necessariamente uma sobrescrita porque se estamos trabalhando com método abstrato, não há necessidade de redefinição.  



## Associação🦕🦎:

#### A associação ocorre quando uma herança não é a melhor opção para o problema apresentado, pois ela serve apenas para o reúso. Como nos exemplos anteriores, um anestesista herda da classe médico porque anestesista é um médico. Se precisarmos inserir endereço a estas classes, fazer uma subclasse herdar da classe endereço não é a solução para o problema.  Como um anestesista não é um endereço e um anestesista necessita de um endereço, a associação surge como a solução. As classes e objetos podem se associar com outras classes e objetos quantas vezes forem necessárias. A associação permite que o objeto cumpra o papel de coesão. 

## Tipos de associação: agregação, composição e dependência🦎🪢:

### Associações podem ser realizadas de forma estrutural e comportamental. 

 ### Associação estrutural pode ter dois tipos: agregação e composição 

#### Associação estrutural de Agregação: Na associação estrutural, as associações ocorrem na estrutura da classe, ou seja, nos atributos. Assim um atributo de uma classe é do tipo de outra classe, então todos os atributos e métodos de uma classe estão dentro de um único atributo da classe associada. Na classe médico podemos ter um atributo endereço que é do tipo da classe Endereço. Assim o atributo da classe médico terá acesso a todos os membros da classe Endereço. 

```c#
abstract class Medico : Funcionario
{
    Date CRM;
    //aqui está a associação 
    Endereco endereco;
    
    void Operar()
    {
        //ações necessárias a uma operação
    }
}
```



#### A associação estrutural do tipo composição ocorre quando há um relacionamento do tipo parte todo, isso significa que a associação só pode existir se houver um objeto. Um endereço não pode existir sem um médico, e unicamente a um médico. Não deverá estar associado a outros objetos. A do tipo agregação não ocorre com o parte todo e pode ser compartilhada entre objetos distintos, por exemplo a instituição em que um médico estudou. 



```c#
class Parto : Procedimento
{
    //associação agregação
    Sala sala;
}
```



#### Assim como polimorfismo e sobrescrita, a associação de composição e agregação são escritas da mesma forma mas possuem significados diferentes. Do ponto de vista tratado na UML, essa diferença existe. 

#### A associação comportamental, no caso a dependência é quando lidamos com métodos e não com atributos. Diz respeito ao parâmetro ou a instanciação de um objeto dentro dos métodos.



## As características de uma associação: unária, múltipla, cardinalidade e navegabilidade

#### Uma associação unária é quando um atributo é de seu próprio tipo, ele se relaciona com ele mesmo. 

#### Uma associação múltipla é quando vários tipos de classe são utilizados na associação. Um exemplo é a classe Parto que possui atributos como Sala e um vetor de médicos no tipo Medico.

```c#
class Parto : Procedimento
{
	Medico[] medicos = new Medico[]{new Anestesista(), new Obstetra(),      new Pediatra()};
	Sala sala;
}
```

#### Nesta classe vemos a cardinalidade. A cardinalidade serve para identificar quantos objetos uma associação possui. Aqui temos exatamente 3 médicos e uma sala envolvidos no procedimento. Cardinalidades podem possuir quantidade fixa ou não.

#### Por fim a navegabilidade se dá por uni ou bidirecional. Unidirecional determina que a associação ocorre somente de um lado, e um exemplo é a classe Parto, onde criou um atributo em parto para o tipo Sala. Caso fosse o contrário, saber qual procedimento uma sala receberá, deveríamos ter um vetor de parto na classe Sala e dessa forma seria possível detectar a navegabilidade que no caso seria bidirecional, onde as duas classes envolvidas possuíam referência uma a outra.

```c#
class Parto : Procedimento
{
	Medico[] medicos = new Medico[]{new Anestesista(), new Obstetra(), 						 new Pediatra()};
	Sala sala;
}
class Sala
{
	Parto[] partos;
}
```



## Interfaces🎰:

#### Em algumas aplicações orientadas a objetos que necessitam de modelagens elaboradas, eventualmente será preciso determinar conjuntos de métodos que devem ser utilizados obrigatoriamente. Como os métodos serão utilizados obrigatoriamente, não importa quem os definiu. Tal obrigatoriedade de utilização se chama interface.

#### Quando uma classe implementa uma interface, ela se compromete a realizar todos os comportamentos que a interface disponibiliza. Um exemplo de interface é a prestação de contas de um hospital ao ministério da saúde. Existe um padrão de informações que devem ser enviadas e ambos sabem disso, e a troca de informação entre hospital e ministério se dá através de uma interface. O ministério disponibiliza um conjunto de métodos, obrigatoriedades ao hospital que fornece as informações. Quando outro hospital for enviar as informações, utilizará a mesma interface, e como os métodos foram definidos para obter as informações é irrelevante ao ministério, somente as informações finais são essenciais.  

```c#
interface IDemonstrativoOperacional
{
    double DisponibilizarFaturamentoMensal();
    Procedimento[] InformarProcedimentoExecutados();
}
```

```c#
class TransmissaoDeDadosMinisterio : IDemonstrativoOperacional
{
    public double DisponibilizarFaturamentoMensal()
    {
        //implementação específica para o hospital poder informar o 		   faturamento mensal
    }
    
    public Procedimento[] InformarProcedimentoExecutados()
    {
       //implementação específica para o hospital poder informar os 		   procedimentos executados
    }
}
```

#### A palavra reservada para criar uma interface é *interface* e para utilizar, é o mesmo procedimento que uma herança, através dos dois pontos : .

#### Anteriormente vimos que quando a classe implementa a interface, necessitam realizar a implementação do método. Na interface, esses métodos não estavam implementados e quando implementados na classe, o corpo é enfim definido. 

#### Um método de uma interface é abstrato, termo discutido na sessão de polimorfismo. Ele não necessita da palavra reservada abstract e sua ideia é fornecer o contrato de implementação sem se preocupar com a implementação em si.

#### Além disso, uma interface se comporta como uma classe abstrata, porém mais restritiva, pois foi visto que em classes abstratas não é necessário o uso de métodos abstratos.

#### Caso necessário, é possível definir atributos nas interfaces, porém eles sempre serão públicos, estáticos e constantes. Estático é definido no corpo, constante significa que o valor não se altera e o valor inicial deve ser definido no momento de sua criação. Em c# um atributo constante possui a palavra reservada readonly.

```c#
double readonly numeroAleatório = 2;
```



#### Na parte dos conceitos de herança, foi especificado que em c# não é possível herdar de mais de uma classe, ou seja, herança múltipla. Quanto as interfaces, é suportado a implementação de quantas forem necessário.

```c#
interface IUm
{
    //coisas da interface IUm
}

interface IDois
{
    //coisas da interface IDois
}
```



```c#
class Classe1 : Ium, IDois
{
    //implementação da classe
}
```



#### Assim, podemos mesclar herança de classe com interfaces. Com interfaces podemos definir subtipos e tipos e a diferença é que na herança utilizamos métodos já pré-definidos e na interface temos a limitação de possuir somente a assinatura dos métodos. 

####  

```c#
class Classe1 : CLasse0, IUm, IDois 
{
 //implementação da classe que emula herança múltipla com interfaces
}
```

# Conceitos Organizacionais 📑:

#### Com conceitos organizacionais conseguimos agrupar classes que possuem conceitos similares e classes que compartilham a mesma finalidade. Isso também limita acesso a membros da classe, organizando sua utilização dentro do código. 

#### Um pacote é uma organização física ou lógica que separa classes com responsabilidades distintas e com isso se espera que a aplicação seja mais organizada, possibilitando separar classes de finalidades e representatividade diferentes.

#### Em C#, os pacotes possuem nomes de namespaces. Pode ocorrer de forma lógica e não física e pastas e subpastas podem ser criadas. 

```c#
namespace entidades
{
	abstract class Medico : Funcionario 
	{
		...
	}
}
namespace entidades
{
    class Obstetra : Medico 
    {
		...
	}
}
namespace integracaoMinisterio;
{
	interface IDemonstrativoOperacional 
    {
	...
	}
}
namespace integracaoMinisterio
{
	class TransmissaoDadosMinisterio : IDemonstrativoOperacional 
    {
		...
	}
}
```

#### Inicialmente com as palavras namespaces não serão criadas pastas no sistema de arquivo mas fará a separação lógica para separação de classes diferentes.

 

```c#
using entidades.Medico;
namespace integracaoMinisterio
{
	class TransmissaoDadosMinisterio : IDemonstrativoOperacional 
    {
		...
	}
}
```

#### Aqui estamos acessando uma classe e o namespace em que ela se encontra.



## Visibilidade

#### Visibilidade ou modificadores de acesso, possuem a finalidade de controlar o acesso e manipulação de classes, atributos e métodos e tem a obrigação de definir até que ponto um membro pode ser utilizado. Public, Protected e Private são as palavras reservadas para a visibilidade dos membros.  Para classes o livro só abordou a visibilidade pública.

- #### Private: Visibilidade mais restritiva, permite que atributos e métodos só sejam manipulados em seu local de definição, ou seja, na classe em que estão sendo implementados. 

  ```c#
  public class Beneficiario
  {
  	private String nome;
  	DateTime dataNascimento;
  	private String tipoBeneficiario;
  	Endereco endereco;
  	// gets/sets
  	private void Idade()
  	{
  		//cálculo da idade a partir da data de nascimento.
  	}
  }
  public class TestePrivate
  {
  	private Beneficiario beneficiario;
  	//1
  	String nome = beneficiario.nome;
      //2
  	beneficiario.Idade();
  }
  
  ```

  #### nas linhas 1 e 2 o código apresenta erro pois foram definidos como private, então só são acessíveis dentro da classe Beneficiario e na classe TestePrivate é impossível acessa-los. Em C# um atributo é private por padrão.

  

- #### Protected: Só podem ser manipulados no local de criação e em classes que herdem da mesma. Só podem ser manipulados na classe e na subclasse.

  ```c#
  namespace entidades
  {
  	public class Funcionario
  	{
  		protected String nome;
  		protected void Metodo1()
  	{
  	// implementação desejada
  }
  }
  namespace entidades
  {
  	public class Medico : Funcionario {
  	private void Metodo() {
  	//1
  	String texto = nome;
  	//2
  	Metodo1();
  	}
  }
  
  namespace entidades
  {
  	public class Paciente
  	{
  		private void metodo()
  	{
  	//3
  	String texto = nome;
  	//4
  	metodo1();
  }
  ```

  

- #### Public: Todos os membros definidos nessa visibilidade são acessíveis de qualquer lugar independentemente de relacionamento das classes. Tornar todos os membros de uma classe acessíveis possibilita acessos indevidos  e o uso dessa visibilidade deve ser utilizado com cuidado para não ferir conceitos da orientação a objetos. 

  ```c#
  public class Endereco
  {
  	public String logradouro;
      public int numero;
  	public String bairro;
  	public String Logradouro;
      {
  	get { return logradouro; }
  	set { logradouro = value; }
      }
  //demais get/set
  }
  ```

  #### Para a orientação a objetos, são somente estes 3 modificadores de acesso, mas o c# possui outros como o internal que possibilita membros serem utilizados em qualquer lugar do projeto e o limita apenas ao projeto em questão.

  # Utilização 🥊:

  #### Antes de começar a codificação, e importante ter conhecimento em UML. Aqui podemos aplicar os conceitos identificando onde os podemos utilizar de forma correta. Neste capítulo analizaremos o sistema do hospital, aplicando inserção de domínio para que posteriormente possa ser codificado.
  
  ![modelagem do sistema](https://github.com/majuliah/Resumos-de-Livros/blob/main/img/print39.png?raw=true) 

#### Após modelar e definir as entidades do sistema, devemos criar os atributos e métodos para as respectivas classes.

```
	Pessoa
		- String nome
		- DateTime dataNascimento
		- Endereco endereco
	Endereco
    	- String logradouro
    	- int numer
    	- String bairro
    	- String CEP
    	- String Cidade
	Paciente
    	- String CPF
    	- Plano plano
     Plano
    	- String nomeAgencia
    	- double valorMensalidade
    Medico
    	- String CRM
    	- Especialidade[] especialidades
    	- double valorHora
    Especialidade
    	- String nome
    Consulta
    	- Paciente paciente
    	- Medico medico
    	- Datetime dataConsulta
    	- String receituario
    	- double valorCOnsulta
    Procedimento
    	- Paciente paciente
    	- Medico[] medico
    	- DateTime data
    	- Sala sala
    	- String observacoes
    	- double valor
    	- int tempoDuracao
    Sala
    	-string tituloSala
    	-int numeroSala
    	-int andarSala
```



#### Assim como os atributos, os métodos também possuem visibilidade. 

```
    Paciente
    	+ void cadastrar(Paciente paciente)
    	+ void alterar(Paciente paciente)
    	+ void excluir(Paciente paciente)
    	+ Paciente consultar(String CPF)
    	+ Paciente[] consultar(String nome, DateTime dataNascimento)
    Medico
    	+ void cadastrar(Medico medico)
    	+ void alterar(Medico medico)
    	+ void exlcuir(Medico medico)
    	+ Medico consultar(int CRM)
    	+ Medico[] consultar(String nome)
    Consulta
    	+ void marcar(Medico medico, Paciente paciente, DateTime data)
    	+ void cancelar(Procedimento procedimento)
		+ pesquisarPorPaciente(Paciente paciente)
	Procedimento
	    + void marcar(Medico medico, Paciente paciente, DateTime data)
    	+ void cancelar(Procedimento procedimento)
	    + Procedimento[] pesquisarPorMedico(Medico medico)
    	+ abstract double calcularTotal()
    ~ITransmissaoDadosMinisterioSaude()
    	_ void gerarDados()	
```

#### Quando criados os métodos, algumas classes não foram citadas e isso ocorre porque nem toda classe tem uma importância dentro do sistema, como Plano por exemplo. No hospital, não há sentido em haver um plano que não esteja atrelado a um paciente e neste caso ao se criar o paciente, o plano será criado junto. 

#### A mesma forma se aplica a endereço e especialidade, levando em consideração os respectivos relacionamentos. 

#### A classe Pessoa é abstrata e generaliza conceitos de médico e paciente, alcançando subtipificação e reúso dos atributos e devido a isto a classe possui apenas métodos básicos que permitem a geração de cadastro, pesquisa, inclusão e consulta como previsto em sistemas orientados a objetos. Procedimento que é uma classe abstrata também possui métodos abstratos.

#### Finalmente, a interface criada possui apenas método responsável por transmitir dados e este processo será feito de acordo com regras do hospital em questão. 

####  

### Codificação 👩‍💻

#### Existem duas vertentes para codificar aplicações: Business Object e Domain Model. 

#### No Business Object, a grande característica da Orientação a Objetos é quebrada, que é a aglutinação de dados e comportamentos da mesma unidade de código. Isso significa que atributos e métodos ficam separados. Esta opção é usada quando é desejado obter alta reusabilidade dos comportamentos mas não deve haver interferência no modelo de entidades da aplicação.  No caso do hospital, se pegássemos a classe Paciente, seriam criadas duas classes, a Paciente e a PacienteBO ou PacienteBusiness, que conteria somente os métodos para manipular os pacientes. Nesta abordagem, a obrigatoriedade da criação de gets e sets que possibilitariam a manipulação dos atributos fora da entidade terminaria por ferir outra característica da Orientação a Objetos, que é o encapsulamento. Utilizar gets e sets para manipular atributos, mesmo que provados pode resultar em comportamentos adversos posteriormente, e por isso é dito que é programar de forma estruturada usando Orientação a Objetos.

#### Mesmo com ressalvas, é uma forma muito utilizada de programação e ocorre porque facilita o processo de codificação, torna o código menos complexo e facilita o entendimento. Quanto mais relacionamentos existirem entre as entidades da aplicação, mais essa abordagem mostrará o seu valor. A seguir um exemplo de codificação desta abordagem:

```c#
public class CarrinhoDeCompras
{
	private String codigo;
	private Produto[] produtos;
    
	public String Codigo
	{
         get {return this.codigo;}
		set {this.codigo = value;}
	}
	public Produto[]
	{
		set {this.produtos = value;}
		get {return this.produtos;}
	}
}
public class CarrinhoDeComprasBO
{
	public Produtos[] listarProdutos
	{
		//lógica de obter todos os produtos a partir de um
		//repositório de dados
	}
    public void adicionarProduto(Produto produto)
	{
		//lógica de adicionar um novo produto. Esta deve se
		//preocupar se o produto novo não já existe.
	}
	public void removerProduto(Produto produto)
	{
		//lógica de remover o produto do carrinho.
	}
	public void esvaziar(Produto produto)
	{
		//lógica de remover todos os produtos de uma vez
	}
	public void finalizarPedido
	{
		//lógica de gerar uma venda a partir do carrinho
	}
}
```



#### Ao não utilizar o Business Object e evitar o modelo anêmico, seguimos 100% os preceitos da Orientação a Objetos, juntando os dados e comportamentos. Com isso, os métodos de manipulação dos atributos e os atributos ficarão juntos na mesma classe, e uma só é criada, no caso do Paciente do sistema do hospital.

#### Nesta abordagem preza-se a não criação de get e set de forma indiscriminada e estes devem ser uma exceção. Com isso, geramos menor acoplamento entre as classes da aplicação, pois diminuímos a quantidade de classes e consequentemente de relacionamentos. Também não possuímos um modelo de domínio pobre, limitando a simples get e set e atributos. 



 ## 							Boas práticas na Utilização de Orientação a Objetos 👩‍💻

![img](https://media.tenor.com/Sq7rY9NKKd4AAAAC/oscars-standing-ovation.gif)

#### Embora tenha sido estudado os conceitos da orientação a objetos, na aplicabilidade é necessário cautela. A prática levará a outros níveis igualmente importantes para sempre entender como e quando aplicar os conceitos. A seguir algumas boas práticas na utilização da orientação a objetos:

## 1 - Se preocupe com a coesão e acoplamento🦢:

#### A mais básica e mais importante das boas práticas. Classes não coesas e com alto acoplamento geram insucesso nos projetos, trabalhe com alta coesão e baixo acoplamento. A falta de coesão leva a classes que misturam responsabilidades. Um exemplo de classe não coesa:

```c#
class Venda
{
	private String nomeCliente;
	private String cpfCliente;
	private String enderecoEntrega;
	private int cep;
	private Debito pagamento;
	private Produto[] produtos;
	private String nomeVendedor;
	private double comissaoVendedor;
}
```

#### Aqui é possível que a classe Venda possui muitas características que não dizem respeito diretamente a ela mesma. Uma classe mais coesa seria:

```c#
public class Venda
{
	private Cliente cliente;
	private Endereco endereco;
	private Debito pagamento;
	private Produto[] produtos;
	private Vendedor vendedor;
}
```

#### Neste caso, associações ajudaram a deixar a classe mais enxuta e com o conceito de coesão. Mas ainda existe melhorias neste exemplo, que seria o acoplamento. Neste exemplo a classe venda depende muito de outra classe, a Debito. Caso a enda precise ter outra forma de pagamento, teria de se realizar uma grande alteração para aceitar a nova modalidade no cartão. 

#### Acoplamentos devem existir pois é uma das características básicas da Orientação a objetos, troca de mensagens. Então a solução seria tornar o acoplamento fácil e flexível. Um bom acoplamento possibilita manutenções sem grandes impactos e sem efeitos colaterais e para esta situação, a melhor forma seria criar uma classe abstrata ou interface e os tipos de pagamento herdariam ou implementariam esta em questão. Venda não dependeria diretamente de Debito, Cartão e etc, e sim de um pagamento genérico que pode mudar conforme a necessidade do negócio. 

#### Assim poderíamos alterar a forma de pagamento sem grandes alterações na venda se necessário. A utilização de herança, interface, polimorfismo ajudará a tornar esse acoplamento mais flexível. Qualquer momento a forma de pagamento pode ser mudada, sem afetar a classe Venda. O importante é ter em mente que devemos tornar o acoplamento flexível. 



## 2- Utilizar Strings com cautela 🐰:

#### Uso indiscriminado de strings na definição de atributos pode gerar conflitos. Portanto, é necessário se atentar aos tipos de dados.

```c#
public class Cliente
{
	private String nome;
	private String dataAniversario;
	private String sexo;
	private String endereco;
}
//uso indevido de strings
```

```c#
public class Cliente
{
	private String nome;
	private Date dataAniversario;
	private Sexo sexo;
	private Endereco endereco;
}
// uso coerente dos tipos de dados, uma realidade mais alinhada com os conceitos de manipulação
```



## 3 -Objetividade, não tente prever o futuro 🧙‍♀️:

#### Classes não devem ser genéricas demais para que sejam reaproveitadas em todos os contextos possíveis a fim de reaproveitar código, isso prejudica a qualidade do programa. Devemos seguir o Kip It Simple, Stupid, ou seja, criar algo simples e funcional. Quando classes são genéricas demais, os entendimentos ficam prejudicados e elas podem não ter sentido algum e mesmo assim estarem presentes em todo lugar, e acoplamentos altos serão criados, subclasses e classes se associarão a ela e quando for necessário fazer modificações, todo o sistema será afetado.

#### Utilizar herança só com o intuito de reúso é um equivoco, sua grande vantagem é o uso de subtipos , conceitos reais do dia a dia e deve ser utilizado no momento certo.  Uma modelagem eficiente supre as necessidades do momento e são facilmente evoluídas futuramente. 

####  

## 4- Construa métodos mais eficientes🐃:

#### Para criar métodos mais eficientes, é necessário ficar atento a 3 fatores:

1. #### Tamanho: Quanto mais linhas tem um método, mais difícil de entender. Uma boa prática é dividi-lo em partes menores. 

2. #### Repetição de Código: Mesmo com outras melhorias, a repetição de código é um problema a ser evitado. Dentro de sua prórpia classe há diversas situações em que podemos reutilizar códigos como um cálculo matemático por exempo.

3. #### Parâmetros: Passar muitos parâmetros para o método é uma inconsistência e deve ser desestimulada. Quanto mais parâmetros desassociados e em grande quantidade, mais acoplamento se cria com este método. Se algum dia um parâmetro realmente necessário precisar ser adicionado, provavelmente precisarão ser corrigidos vários pontos da aplicação. 

   

 ## 5- Conheça e use coleções 🐇:

#### Arrays, muto utilizados nos exemplos acima, são estruturas limitadas que possuem dificuldades de manipulação, como tamanho fixo, dificuldade de pesquisa e controle de inserção de itens.

#### Tamanho fixo: arrays são criados com seus tamanhos fixos, e se em algum momento for necessário mudar o número de posições, um novo vetor deverá ser criado e depois transferir os valores de um para outro. Se um vetor conter muitas posições, este trabalho será muito custoso, complicado e demorado. Utilizar uma estrutura que possibilite um maior dinamismo é uma boa opção, como os exemplos de listas.

#### Dificuldade de pesquisa: Para encontrar um elemento do vetor, todos os valores devem ser lidos em ordem até que seja encontrado. Isso pode demorar dependendo do tamanho que o vetor tiver. Esta situação poderia ser melhorada.

#### Controle de Inserção: se for necessário averiguar se um item já existe, o mesmo problema acima se repetirá, e se o vetor estiver cheio, será necessário criar outro.  

#### As coleções evitam estas situações, não só com vetores mas com outras estruturas. Estas estruturas passam mais flexibilidade, saber quais são as coleções que ajudarão a otimizar o seu código e sua produção é um bom caminho para um sistema limpo e livre de falhas.

## 6- Sobrescreva equals, hashcode e tostring📜:

#### Embora não seja obrigatório, é importante sobrescrever estes 3 métodos e vai além de boa prática, pois isso evita resultados inesperados. Em seguida, veremos o resultado de não sobrescrever os métodos:

```c#
//List
listaNomes.Remove(new Aluno("Pikachu"));
listaNomes.Contains(new Aluno("Charmander"));
//Dictionary
dictionary.Remove("A3");
dictionary.ContainsValue(new Aluno("Lorelay"));
//HashSet
alunos.Remove(new Aluno("Beiçola"));
alunos.Contains(new Aluno("Berth"));
```

#### Se espera que os métodos acima obtenham sucesso e as remoções sejam realizadas com sucesso e pesquisas com o método contais retornem true. Se o método Equals e o hashcode não forem implementados, todas as chamadas falharão. Isso se dá porque o tipo ALuno é definido pelo programador e a linguagem não sabe o que isso significa e apenas aceitam suas definições, então elas não sabem o que torna um aluno igual ao outro. Fazer a comparação com os atributos de um objeto resultará em falhas futuras e o encapsulamento é ferido pois a lógica de igualdade ficará exposta no código o tornando frágil e propício a erros. 



## 7- As vezes é melhor associar ao invés de herdar 🎃:

#### A verdadeira utilização da herança não é a reutilização mas sim criar subtipos e podemos ter reúso sem haver herança. 

```c#
public class carrinhoCompras : List
{
	...
}
```

#### Embora possa parecer a melhor opção pelo array possibilitar armazenar vários objetos, além de ser possível reutilizar todas as facilidades de manipulação de objetos como inserir, excluir, atualizar, etc, vários erros serão apresentados posteriormente, tais como:

- ####  Quebra semântica: Carinho de compras não é uma lista e herança é para criar subtipos, o reúso é apenas uma consequência;

- #### Quebra de encapsulamento: Classes que herdam se tornam uma versão mais específica da superclasse e com isso, a classe que herda tem todos os membros e estado, gerando uma grave quebra de encapsulamento. 

- #### Forte acoplamento: A herança gera acoplamento e uma subclasse é filha de uma superclasse dependendo fortemente dela para existir e caso alterações sejam feitas na classe mãe, as filhas se afetarão gerando mais comportamentos inesperados.

- #### O que fazer: A herança deve ser usada no lugar certo e na hora certa e muitas classes são projetadas somente para serem herdadas. A seguir como o código ficaria com as melhorias:

- ```c#
  public class CarrinhoCompras
  {
  	private List<produto> produtos;
  	...
  }
  ```

  

## 8- Se for o caso, evite a herança ou pelo menos a sobrescrita⚠️:

#### Com todo o tópico 7, uma dúvida surge: Como evitar que determinadas classes não sejam herdadas e evitar situações adversas? As classes não devem ser herdadas e os mecanismos de impossibilitar isto é utilizando o sealed. A hierarquia de classes é finalizada nas classes em que elas foram usadas. 

```c#
public sealed class String : IComparable, ICloneable, IConvertible
, IComparable<string>, IEnumerable<char>, IEnumerable, IEquatable<
string>
{
	//exemplo da palavra reservada sealed
}
```

#### Quando a classe deve ser herdada mas os métodos não devem ser sobrescritos, o sealeds deve ser implantados neles:

```c#
public class MinhaClasse
{
	public sealed void Metodo1()
	{
		...
     }
	public void Metodo2()
	{
		...
	}
}
```

#### Acima vemos uma classe que pode ser utilizada e seus métodos selados 😏 Em c#, o sealed só pode ser aplicado em classes e métodos e a criação de constantes não é uma forma de proibir a herança.



## 9- Se preocupe com o encapsulamento ⛳:

#### Encapsulamentos indicam uma boa qualidade do uso da orientação a objetos. Diversas trocas de mensagens acontecerão e pra realizar as trocas os métodos devem ser executados e justamente nestas criações que devemos ter cuidado. Outra preocupação é o estado interno dos objetos. Aplicações mal protegidas criam dependência entre classes porque os métodos não desempenham bem a função de esconder as complexidades de implementação e atributos terminam sendo acessados diretamente. 

- #### Defina as visibilidades de forma adequada: Classes devem, via de regra, serem públicas e criar classes protegidas só é possível em uma classe interna. Ler mais sobre na documentação do C#. Atributos e métodos devem sempre ser privados para garantir a proteção de informações.  

- #### Cuidado com os usos de get e set: Embora muito usados, eles facilmente quebram o encapsulamento porque mesmo definindo um atributo como privado, se for criado um método set, de nada adiantará a privacidade definida. Bastará chamar o set e impor o valor. 

  1. ### Ao invés de set, faça uma sobrecarga do construtor: Sempre bom uma classe ter um construtor padrão (vazio) devido ao uso de frameworks e afins. É melhor um construtor enviando os valores já desejados do que o uso excessivo de gets e sets. 

  2. ### Ao invés de get, faça métodos de negócios: não exponha diretamente o valor do atributo para depois realizar um processamento com ele. O melhor é disponibilizar o processamento em si e este é um princípio chamado Tell, dont ask que quando menos encapsulado um código, mais pergunta se faz. Um exemplo básico:

     ```c#
     if (paciente.Fatura.DataPagamento != null)
     {
     	//pacienta pagou o plano de saude, então pode ser atendido.
     }
     ```

     ### A lógica de saber se o paciente pode ser atendido depende diretamente da data do pagamento e além disto, se mais alguma verificação necessitar ser feita futuramente para determinar o atendimento, mais pontos espalhados na aplicação. Um código que melhora a situação:

     ```c#
     //Na classe `Paciente`
     public bool PodeSerAtendito
     {
     	get {return this.Fatura.DataPagamento != null;}
     }
     	if (paciente.PodeSerAtendido())
     	{
     			//processamento necessário
     	}
     }
     ```

     

  3. ### Se for o caso, blinde o estado do objeto definitivamente: Classes imutáveis criam objetos imutáveis, e dependendo da ocasião, é necessário que um objeto mantenha seus valores até o fim de sua vida.

## Saiba usar interface e classe abstrata no momento certo🦐:

#### Uma dúvida comum é quando utiliar classes abstratas ou interface e embora sejam bem parecidas, existem situações em que cada uma se aplica melhor. 

-   Classe abstrata: deve ser molde para outras classes. Implementação direta do conceito de abstração e devido a isto não pode ser instanciada. Pode ou não definir métodos abstratos.
- Interface: Definição de um contrato ou obrigatoriedade de implementação do serviços providos. Somente as assinaturas dos métodos estão disponíveis deixando para quem implementa a interface prover o comportamento necessário. Por padrão, todos os métodos devem ser públicos e abstratos, ou seja, nenhuma implementação permitida.

#### Embora interfaces sejam utilizadas para emular herança múltipla, esta não é sua finalidade e quem realmente foi criada para ter subtipos são as classes abstratas. Não é um erro emular interfaces para herança e somente devemos ter cuidado para este fim. Emular heranças com interfaces gera forte acoplamento. E o perigo é que deixamos para os implementadores os métodos das interfaces. Quando uma interface for implementada e depois necessitar de alteração, posteriormente todas as suas implementações terão de ser atualizadas. Isso porque como sua definição diz, há uma obrigatoriedade de implementação dos serviços providos. 

 

## 11- Usar e abusar das facilidades fornecidas por linguagens orientadas a objetos 🪄.

## 12 - Conheça e utilize as  convenções de codificação da linguagem escolhida🎡.



~Depois da Orientação a Objetos:

- Padrões de projetos: Design Patterns

- Refatoração

- Programação Orientada a Aspectos

- Frameworks: NHibernate: uso de banco de dados relacional, NLog: controle de logs de aplicações

  











 



 







####  











 

























