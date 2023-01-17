_Crea un proyecto GOAP en el que un conjunto de agentes lleven a cabo una serie de acciones que les permitan alcanzar sus objetivos. La temática es totalmente libre, por ejemplo se puede simular un pueblo con agentes de todo tipo (cocineros, panaderos, granjeros, mineros, herreros, banqueros, vendedores, ladrones, alguaciles, bomberos, ...). Como referencia, un proyecto con 3 tipos de agentes y 6 acciones en total es un aprobado. A partir de ahí,  se calificará en función de la complejidad del mismo._

---

He simulado un festival con varios conciertos. Para ello, existen tres agentes:
- Agente Singer: encargado de cantar para las masas. Existe uno por escenario, con diferentes comportamientos:
  - Ir a la entrada del escenario.
  - Subirse al escenario y cantar.
  - Bajarse del escenario e irse. En este punto, una vez llega al punto final, el agente se destruye, y se crea otro en su lugar.
- Agente Spectator: el gran público. Disfruta del festival. El amor de todos los cantantes. Este agente tiene los siguientes comportamientos:
  - Entrar al festival.
  - Ir a ver al cantante en cuestión.
  - Irse del festival. En este punto, una vez llega al punto final, el agente se destruye.
- Agente Drinker: común en todos los festivales, siempre hay un tipo de persona que disfruta del alcohol. Este agente tiene los siguientes comportamientos:
  - Entrar al festival.
  - Ir a beber cerveza.
  - Irse del festival. En este punto, una vez llega al putno final, el agente se destruye.
  
Para incorporar a los diferentes agentes se ha elaborado un mapa con los siguientes elementos:
- Escenario.
- Entrada al festival y entrada del cantante.
- Tienda de cerveza.
- Spawners para crear a los diferentes agentes.

![](/gif.gif)

A festival with several concerts was simulated. For this, there are three different agents:
- Singer agent: in charge of singing for the masses. There is one per stage, with the following behaviours:
  - Go to the stage entrance.
  - Get on stage and sing.
  - Get off the stage and leave. At this point, once the agent reaches the end point, it is destroyed and another one is created in its place.
- Spectator agent: the public. Enjoys the festival. This agent has the following behaviours:
  - Enter the festival.
  - Watch the singers.
  - Leave the festival. At this point, once it reaches the end poiint, the agent is destroyed.
- Drinker agent: common in all festivals, there is always a type of person who enjoys alcohol. This agent has the following behaviours:
  - Enter the festival.
  - Go and drink beer.
  - Leave the festival. At this point, once it reaches the end point, the agent is destroyed.
  
In order to implement the different agents, a map with the following elements had to be created:
- Stage
- Entrance to the festival and entrace for the singer to access the stage.
- Beer shop.
- Spawners to generate the different agents.
