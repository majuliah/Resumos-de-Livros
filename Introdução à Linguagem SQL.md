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

#### 









