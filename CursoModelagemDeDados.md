#              Notas do curso de modelagem de dados

<img src="https://media1.giphy.com/media/UEGwYCVTBFa9tJEf66/giphy.gif?cid=ecf05e47zyyh536qny7tgrdjx6kk5h1i2swv6fq266vdi3iw&rid=giphy.gif&ct=g size" style="zoom:75%;" />





##                                                             Modelagem de dados parte 1:

#### 🦩**Banco de dados Relacional:**

##### Um banco de dados é uma coleção de dados relacionados entre si. Os dados são fatos que podem ser gravados de maneira implícita. Um BD representa alguns elementos do mundo real, as vezes sendo chamados de mini-mundo. Uma coleção de dados randômica NÃO pode ser considerada um banco de dados relacional.

##### Um Sistema de Gerenciamento de Banco de Dados (SGBD) é uma COLEÇÃO de PROGRAMAS que permite a manutenção e gerenciamento do banco de dados. É portanto um sistema de software em geral que facilita os processos de definição, construção, manutenção e manipulação dos dados de um Banco de Dados entre vários usuários. 

##### Query: Consulta

##### Update: Atualizar

##### Buffering: Armazenamento Temporário



#### BIG DATA ou NOSQL(Not Only Sequal )

##### São bancos de dados não tradicionais que armazenam quantidade absurda de dados ou dados não convencionais como mídia(fotos, músicas, vídeos, etc -> [pinterest, twitter, youtube]). 

##### Meta Dados: É a definição de especificar tipos de valores e restrições de dados armazenados (PRECO: **int not null**)

##### Abstração de dados: Permite que o dado que é organizado e o dado que é armazenado ajam diferentes. Assim podemos separar em modelos de alto nível e baixo nível. Entre eles temos o modelo de dados representativo que ocultam os dados e representações sobre eles. 

##### Um relacionamento representa algo que existe no mundo real.

##### Esquema de banco de dados: É a representação, a base onde os dados vão ser armazenados. É a descrição do Banco de Dados e espera-se que nunca mude. Somente mudam os dados armazenados dentro do banco de dados. As regras de negócio são dificilmente representadas no diagrama do esquema.  

##### Os dados no banco de dados se modificam com frequência. A evolução do esquema se dá quando há a necessidade de alteração do esquema para satisfazer o novo modelo de negócios.  O estado atual do banco de dados tem de satisfazer a estrutura e restrições especificadas no modelo lógico e esquema.

##### As **entidades** representam um objeto do mundo real com existência independente. Pode possuir existência física ou conceitual como copo ou curso, compra, pedido, empresa, carro, etc. Os ATRIBUTOS descrevem as entidades. Exemplo: 

#####                                                              ![](https://github.com/majuliah/livrosLidos/blob/main/img/print33.png?raw=true)  

#### Atributos Simples e Atributos Compostos, Atributos de Valor Único e Atributos Multivalorados:

#### Atributos Simples: Atributos com somente um valor. Exemplo de atributo simples é nome, idade, data de nascimento, etc.

#### Atributos Compostos: Atributos compostos são atributos com mais de um valor. O exemplo é endereço, filiação, etc.

#### Atributos de Valor Único: São atributos com somente um valor, é um atributo simples.

#### Atributos Multivalorados: São atributos com mais de um valor para o mesmo atributo, como por exemplo número de telefone. Uma pessoa pode ter mais de um meio de comunicação, como fixo ou móvel.



##### Atributos armazenados são aqueles que nós cadastramos, como por exemplo nome. 

##### Atributos derivados são aqueles que referenciam outros valores, como idade. Ele depende da data de nascimento para ser calculada e a data atual. 

#### Relacionamento entre as entidades: É uma ligação que fazemos entre elas. 

#### Grau de relacionamento: A quantidade de Entidades relacionadas, envolvidas no relacionamento.

#### Funcionário - TRABALHA EM - Departamento

#### Fornecedor - FORNECE - Peças - PARA UM - Projeto 

#### Relacionamento recursivo é quando uma entidade se relaciona com ela mesma

## Cardinalidade:

​                    muitos para um            muitos para muitos

## 1: N          N : 1          1 : 1          N : M

um para muitos               um para um



## Tipos de Cardinalidade:

## Total: 

### Quando uma entidade necessita de outra para existir. Exemplo: 

#### Um funcionário não pode existir sem estar ligado a um departamento. OU . Um departamento não existe se não existir pelo menos um funcionário. (Funcionário depende de Departamento e Departamento depende de funcionário)



## Parcial:

### Quando uma entidade não necessita de outra entidade, mas o contrário sim. Exemplo:

#### Um projeto não existe sem um gerente. MAS. Um funcionário existe sem gerenciar um projeto.

![](https://github.com/majuliah/livrosLidos/blob/main/img/print34.png?raw=true)

#### Funcionário só pode trabalhar em um departamento. A menor relação que ele pode ter é 1 e a maior que ele pode ter é um porque um funcionário só pode trabalhar em um departamento (De acordo com este minimundo, com essa regra de negócio)

#### Departamento tem que ter no mínimo 1 funcionário para existir, mas ele pode ter N funcionários. 

#### Quando vemos o mínimo > 0, é porque a cardinalidade é TOTAL, não importa qual o máximo. 

#### PODEMOS CONVERTER ATRIBUTOS DE RELACIONAMENTO PARA ATRIBUTOS DE ENTIDADE: os relacionamentos as vezes podem conter atributos que podem ser convertidos para atributos de entidade. Ele somente pode migrar para o lado em que há 1 : X de cardinalidade. Se ambos atributos forem 1 : X, então poderá ir para qualquer atributo. 

#### ENTIDADE FRACA -> É a entidade que não tem uma chave única que a defina. 

#### RELACIONAMENTO DE IDENTIFICAÇÃO -> Quando um atributo de uma entidade necessita de um atributo de outra entidade. Exemplo: dependente depende do CPF do funcionário para ser identificado.

#### GENERALIZAÇÃO / ESPECIALIZAÇÃO -> Podemos  atribuir algumas propriedades particulares para um conjunto de atributos. Será HERDADO tudo do atributo pai. Exemplo: FUNCIONÁRIO pode ser tipo CONTRATADO ou TERCEIRIZADO. Tanto contratado quanto terceirizado vão receber os atributos impostos em Funcionário, mais os seus próprios. 

#### ENTIDADE ASSOCIATIVA: Quando uma entidade 1 : N se associa, se relaciona com outra entidade 1 : N







#### ![](https://github.com/majuliah/livrosLidos/blob/main/img/print35.png?raw=true)

#                           Modelagem de dados parte 2:





























