#                                    	Introdução a Linguagem SQL 🐣

​                       <img src="https://media4.giphy.com/media/v1.Y2lkPTc5MGI3NjExdzB1Y2V4OTJsZDQzMXJocGowYXB0cHFnZXFnOTV4ZjVlZGhvYWZkdSZlcD12MV9pbnRlcm5hbF9naWZfYnlfaWQmY3Q9Zw/2xnO6tTIYYFE2j3IqQ/giphy.gif" style="zoom: 80%;"/>



## 📑Capítulo 1: Por que aprender SQL?

#### A Structured Query Language é um meio de manipular e acessar dados de forma mais fácil, além de ser muito importante para coleta de dados para decisões empresariais. Dados nos últimos anos tem sido destaque e pessoas que possuem conhecimento sólido em SQL são muito requisitadas (palavras 2023).

## 📑Capítulo 2: Banco de dados:

### 👾O que é um banco de dados?

#### Definição ampla: qualquer coisa que colete e gerencie dados. Geralmente em áreas de TI, "banco de dados" se refere a um SGBDR que é um sistema de gerenciamento de banco de dados relacional que quer dizer que um conjunto de dados tem tabelas que se relacionam entre si.

### 👾Examinando bancos de dados relacionais 

#### semelhante a uma planilha do excel, um banco de dados relacional possui linhas e colunas que armazenam dados, onde uma tabela pode se relacionar com outra. Essa é a ideia básica por trás de um banco de dados relacional, onde as tabelas possuem campos que apontam para informações de outras tabelas. 

### 👾Por que tabelas separadas? 

 #### Por causa de um conceito conhecido como normalização, que consiste na separação dos diferentes tipos de dados em suas próprias tabelas para não aglomerar uma só tabela. Se houvessem dados todos em uma mesma tabela, isso seria redundante, tornando-a saturada, pouco eficiente e de difícil manutenção. Futuramente os relacionamentos serão vistos com a clausula *join*.

## 📑Capítulo 3: SQLite:

### 👾O que é SQLite? 

#### A situação ideal para o uso do SQLite é quando o fluxo de informações e acesso a elas é simples como um documento word. É indicado quando necessita de simplicidade e é uma boa solução para bancos de dados industriais. Como não possui servidor de gerenciamento de acesso, é adequado apenas para fluxos com apenas um usuário, então ele será usado neste treinamento. 



## 📑Capítulo 4: SELECT:

#### A instrução select é responsável por solicitar dados armazenados no banco e exibi-los. Neste capítulo será visto como selecionar colunas de uma só tabela e formar expressões com elas. 

### 👾Recuperando dados com o SQL

####  A primeira instrução SQL deste livro será:  `SELECT * FROM CUSTUMER`.  O comando select permite selecionar quais as colunas serão acessadas em uma tabela, então a query quer dizer um "selecione todas as colunas da tabela customer".

### 👾Expressões em instruções SELECT:

#### Também é possível executar outras expressões com o select, como uma expressão matemática. Se quisermos selecionar os valores da coluna Preço  da tabela Produto adicionando 7% do valor, a query seria: 

`SELECT  PRODUCT_ID, DESCRIPTION, PRICE, PRICE * 1.07 AS TAXED_PRICE FROM PRODUCT;` 

#### A coluna Taxed_price foi calculada dinamicamente na consulta, e ela não é armazenada no banco, somente é calculada e exibida como resultado da consulta. É um recurso importante do sql que permite armazenar dados em nível simples como somente exibir cálculos.  

#### Ao estudar a consulta, entendemos que do Taxed_Price foi foi gerado um valor para cada registro e demos um nome ao valor calculado através da palavra AS e isso é conhecido como ALIAS, uma forma de apelidar uma expressão ou coluna existente dentro da consulta.  Isso não muda o nome da coluna na tabela, somente na exibição.

`SELECT PRODUCT_ID, DESCRIPTION, PRICE AS UNTAXED_PRICE, PRICE * 1.07 AS TAXED_PRICE FROM PRODUCT;`

###### **Lembrar de sempre usar _ para separar espaços em brancos, ao contrário, gerará erros.

| Operador | Descrição                                        | Exemplo              |
| -------- | ------------------------------------------------ | -------------------- |
| +        | Soma dois números                                | STOCK + NEW_SHIPMENT |
| -        | Subtrai dois números                             | STOCK - NEW_SHIPMENT |
| /        | Divide dois números                              | STOCK / PALLET_SIZE  |
| *        | Multiplica dois números                          | PRICE * 1.07         |
| %        | Divide dois números e retorna o resto da divisão | STOCK % PALLET_SIZE  |



### 👾Concatenação de texto:

#### Expressões não são utilizadas apenas com números, também podem ser utilizadas com textos e outros tipos simples e quando é utilizada em textos se chama concatenação, que mescla os dados. No SQLite isso é feito com dois pipes. Vamos concatenar os campos city e state da tabela customer:

#### ` SELECT NAME, CITY || ', ' || STATE  AS LOCATION FROM CUSTOMER;`

#### ` SELECT NAME, STREET_ADRESS || ' ' || CITY || ', ' || STATE || ' ' || ZIP AS SHIPPED_ADDRESS FROM CUSTOMER;`



## 📑Capítulo 5: WHERE:

#### A partir de agora serão acrescidas cláusulas às consultas, como a de filtro conhecida como WHERE.  

### 👾Filtrando registros:

#### O banco em que trabalharemos contém uma tabela com 17 colunas. 

#### `SELECT * FROM station_data`;

#### A clausula where é uma forma de filtrar recursos de acordo com o critério desejado. 



### 👾Usando o WHERE com números:

#### Se estivermos precisando de dados referentes ao ano de 2010, seria muito fácil utilizar o where com um critério simples como este. Com isso, a consulta só retornará dados do ano de 2010:

#### `SELECT * FROM station_data WHERE year = 2010`;

#### O inverso disso seria:

#### `SELECT * FROM station_data WHERE year != 2010`;

#### Já o Between engloba as datas entre o intervalo especificado, as incluindo:

`SELECT * FROM station_data WHERE year BETWEEN 2005 and 2010`;



### 👾Instruções AND, OR, IN:

#### Se quisermos utilizar a instrução AND, podemos utilizar a query que retorna valores em que o ano seja maior ou igual a 2005 E menor ou igual 2010:

#### `SELECT * FROM station_data WHERE year >= 2005 AND year <= 2010`;

#### Se quiséssemos excluir  os anos 2005 e 2010 da consulta: 

#### `SELECT * FROM station_data WHERE year > 2005 AND year < 2010`;

#### AInda temos a opção OR onde pelo menos um dos critérios deve ser verdadeiro. Se quiséssemos registros dos meses 3,, 6, 9 ou 12, esta seria a instrução correta:

#### `SELECT * FROM station_data WHERE MONTH = 3 OR MONTH = 6 OR MONTH = 9 OR MONTH = 12`;

#### Uma alternativa para que a consulta não fique verbosa é utilizar a instrução IN que fornece uma lista válida de valores:

#### `SELECT * FROM station_data WHERE MONTH NOT IN (3, 6, 9, 12);`

#### E se não quiséssemos estes valores no retorno, basta adicionar o NOT:

#### `SELECT * FROM station_data WHERE MONTH NOT IN (3, 6, 9, 12);`

#### Também podemos executar operações para obtermos resultado, como esta query que retorna todos os meses cujo resto da divisão por 3 = 0, ou seja, cujo número do mês é divisível por 3:

#### `SELECT * FROM station_data WHERE MONTH % 3 = 0;`

### 👾Utilizando WHERE com texto:

#### Para executar a cláusula com texto, seguimos as mesmas regras que com os números (utilizando =, AND, OR, IN) só que devemos informar os valores entre aspas simples.

#### `SELECT * FROM station_data WHERE report_code = '513A63';`

#### Esta regra também se aplica a cláusula IN:

#### `SELECT * FROM station_data WHERE report_code IN ('513A63', '1F8A7B', 'EF616A');`

#### Existem outras instruções interessantes que usam funções como a length() que conta o número de caracteres de um valor específico. Se fosse aplicar um controle de qualidade onde os report_codes possuíssem 6 caracteres, esta função seria ideal.

#### `SELECT * FROM station_data WHERE length(report_code) != 6 `;

#### Outra operação importante é utilizando o LIKE onde o % representa qualquer número de caracteres e _ um único caractere. Se quiséssemos encontrar todos os relatórios que começam com a letra A, seguida por quaisquer caracteres, seria assim:

#### `SELECT * FROM station_data WHERE report_code LIKE 'A%';`

#### Agora se quiséssemos encontrar os códigos do relatório que tivessem B como primeiro caractere e C como o segundo, usaríamos o _ para a segunda posição e qualquer número de caracteres após o C:

#### `SELECT * FROM station_data WHERE report_code LIKE 'B_C%';`

###### ***Não confundir o uso do %, para operações matemáticas ele é um MOD e para operações com texto ele é um curinga de padrão de texto.

#### Existem outras funções de texto importantes que podem ser consultadas no apêndice ou em documentações. Aqui neste estudo ela será encontrada no arquivo QuerysExercices.



### 👾Utilizando WHERE com booleanos:

#### Sabemos que booleano são valores de verdadeiro ou falso, e geralmente em BD os falsos são 0 e os verdadeiros são 1, sendo que algumas plataformas permitem o uso explicito da palavra **true** ou **false**:

#### ` SELECT * FROM station_data WHERE tornado = true AND hail = true;`

#### Porém o SQLITE não permite a utilização desses valores, sendo necessário utilizar 0 e 1.

#### ` SELECT * FROM station_data WHERE tornado = 1 AND hail = 1;`

#### Todos os campos de uma clausula WHERE no fim das contas são do tipo booleano, então se quiséssemos uma query com true, não seria necessário passar o = 1. Porém a qualificação de condições falsas é necessário a passagem do parâmetro 0.

#### ` SELECT * FROM station_data WHERE tornado AND hail;` -> true

#### ` SELECT * FROM station_data WHERE tornado = 0 AND hail = 0;` -> false

#### Também é possível usar a palavra NOT que nega uma condição:

#### `SELECT * FROM station_data WHERE NOT tornado AND hail = 0;`



### 👾Manipulando NULL:

#### Valores nulos são aqueles que não possuem valor, nem o default para aquele tipo de dado. Ele é a ausência completa de qualquer conteúdo, e possuem valores nulos em colunas do sation_data. Valores nulos não podem ser atribuídos tradicionalmente com o "=", são necessários instruções ***IS NULL*** ou ***IS NOT NULL*** para identificar estes valoresPara obter todos os registros sem definição de profundidade da neve ~snow_depth~ podemos executar a consulta:

#### `SELECT * FROM station_data WHERE snow_depth IS NULL;`

#### Os valores nulos servem para notificar a capacidade de determinada área de identificar valores. Não seria coeso colocar 0 (para definir como false) se a coluna registra se houve ou não neve. Mas se uma estação não tivesse equipamento necessário para medir neve, mas nevasse? Colocar o 0 diria que não nevou, portanto o nulo é a melhor opção. A utilização de nulos é ambígua e dificilmente conseguimos determinar sua usabilidade em uma empresa, e é necessário ter uma documentação que informe o ponto de vista da tabela nula.

###### Valores nulos não devem ser confundidos com textos vazios '' ou textos com espaço em branco ' '. Estes são valores e não nulos. 

#### Os valores nulos são de difícil manipulação. Se quiséssemos que a precipitation fosse <= 0.5 ou nulo, como faríamos essa verificação já que nulo nem 0 é? Valores nulos raramente se qualificam e quase sempre ficam de fora das instruções where. Neste caso utilizamos o OR:

#### `SELECT * FROM station_data WHERE precipitation IS NULL OR precipitation <= 0.5;`

#### Uma forma elegante de criar um alias para caso o campo seja nulo, é a utilização da função coalesce(), onde passamos dois parâmetros: o primeiro é o campo em que tem possíveis valores nulos e o segundo é o valor que o campo vai assumir caso o número realmente seja nulo:

#### `SELECT * FROM station_data WHERE coalesce(precipitation, 0) <= 0.5;`

#### Esta função pode ser usada em outras funções como a select por exemplo, ela é útil caso queira melhorar a aparência de um relatório sem exibir os NULLS e sim um placeholder como (N/A), NONE, etc.

### 👾Agrupando condições:

#### Quando agrupar condições, é necessário atenção para que as condições sejam atendidas corretamente. Um exemplo:

#### ` SELECT * FROM station_data WHERE rain = 1 AND temperature <= 32 OR snow_depth > 0; `

#### Na query acima temos um problema, embora tecnicamente funcione. Há uma ambiguidade e o SQL por si só consegue interromper esta query. Isso porque não definimos corretamente qual condição pertence ao AND e quais pertencem ao OR. Dessa forma, é aconselhado agrupar as condições entre parênteses: 

#### `SELECT * FROM station_data WHERE (rain = 1 AND temperature <= 32) OR snow_depth > 0;`

#### O agrupamento em parênteses é crucial principalmente em querys mais avançadas. 

## 📑Capítulo 6: GROUP BY & ORDER BY:

#### Agregação de dados, cocnhecida como totalização, resumo ou agrupamento é a forma de criar um total de vários registros, com soma, mínimo, máximo, contagem, média... 

### 👾Agrupando registros:

#### Agregação simples: contar o número de registro da tabela:

#### `SELECT COUNT(*) AS record_cound FROM station_data`;

#### Count(*) significa contar os registros e podemos usar com outras funções como WHERE. Contaremos os registros que possuiam tornado:

#### `SELECT COUNT(*) AS record_count FROM station_data WHERE tornado = 1`;

#### Agora vamos separar a contagem por ano:

#### `SELECT year, COUNT(*) AS record_count FROM station_data WHERE tornado = 1`;

#### Com 3 mil registros retornados, podemos agrupar por ano:

#### `SELECT year, COUNT(*) AS record_count FROM station_data WHERE tornado = 1 GROUP BY Year`;

#### Dessa forma os dados tomam mais significado porque podemos comparar os totais de tornado ao longo dos anos. 

#### 

#### 

####

#### 

#### 

#### 

#### 

#### 

#### 

#### 

#### 

#### 

#### 

#### 

#### 

#### 

#### 

#### 

#### 

#### 

#### 

#### 

#### 

#### 

