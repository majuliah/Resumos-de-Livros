# ✨DOCKER ESSENTIALS #DAY 1✨

![](https://media3.giphy.com/media/LiK9YTBGabS9JN6VcY/giphy.gif?cid=ecf05e47u51uti6rnoomqazbrowoerxbcdmm60guvnjlmvgi&ep=v1_gifs_search&rid=giphy.gif&ct=g)



## O que é container? 🧐

#### Agrupamento de uma aplicação junto de suas dependências. Compartilham o kernel do SO virtual ou físico de onde está sendo executado. É uma forma de isolar recursos para um determinado fim. A principal função do c-groups é o isolamento de recursos de hardware. Namespaces fazem os sistemas serem o mais isolados possíveis. Isolamentos: namespaces: filesystems, processor, networks, usuarios, só roda  o especificado| c-group: limita recursos computacionais (hardware).

#### CHroot, LXC, Jails, Solaris Zones, VPS, OpenVZ são ferramentas anteriores ao docker. 

#### Os containers são similares a maquinas virtuais, só que de forma integrada ao sustema operacional do host e mais leve. Geralmente a imagem de um container é bastante enxuta com somente o necessário para rodar a aplicação, que quando está em execução tem um overhead devido ao compartilhamento de recursos com o host. Diferente das mvs, nos containers não são necessários a emulação de sos, além de os recursos serem compartilhados, gerando capacidade de rodar mais containers em um único host. 

#### A portabilidade é outra vantagem dos containers, ele rodará em qualquer local que possua o docker. 

## Namespaces🧐

#### Isolamento de 

## Sistema de Camadas: Copy-On-Write🧐

#### 
