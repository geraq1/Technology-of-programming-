 ## Введение
 
Сегодня салоны красоты стали неотъемлемой частью нашего быта, существует огромное число салонов красоты и предлагаемых ними услуг.

Предприятия индустрии красоты имеют характерные отличительные признаки, определяющие их класс, тип и направление. Это определяет ценовую политику организации, загруженность клиентами, правила поведения в коллективе и количество специалистов, подбор используемых методик и другие параметры салонного бизнеса. Услуги красивого бизнеса должны отвечать требованиям, общим для всех организаций, оказывающих эти услуги. Обязательными из них являются: высокое качество оказания услуг; эффективность той или иной процедуры; квалификация специалистов и мастеров оказывающих услуги.
## 1  Описание предметной области


## 1.1 Исследование предметной области

Салон красоты арендует площадь 125 кв. метров. Помещение включает: зону ресепшн с гардеробом и стойкой администратора (11 кв. м.), парикмахерский зал (26 кв. м.), помещение для мытья, окраски, завивки волос (12 кв. м.), зона для визажа и наращивания ресниц (8 кв. м.), кабинет маникюра и педикюра (12 кв. м.), косметический кабинет (12 кв. м.), массажный кабинет (16 кв. м.), солярий (15 кв. м.), подсобное помещение для хранения дезинфицирующих средств (3 кв. м.), комната отдыха (10 кв. м.).

Основными услугами салона красоты являются:

Парикмахерские услуги (мужская, женская, детская стрижка);

- Маникюр и педикюр (уход, наращивание, дизайн, коррекция);
- Косметологические услуги (уход за кожей и чистка лица, уход за бровями, уход за ресницами, эпиляция, демакияж, пилинг);
- Уход за кожей тела;
- Солярий;
- Продажа косметических средств.

## 1.2 Анализ предметов моделирования
 В процессе работа   парикмахерской участвует весь персонал и клиенты. Все начинается с того, что клиент выбирает услугу и специалиста. Затем происходит запись на прием. После этого клиент пользуется услугой салона и далее происходит оплата данной услуги.
#
#
#

## 1.3 Use case модель

Диаграмма вариантов использования

Диаграмма прецедентов или диаграмма вариантов использования в UML — диаграмма, отражающая отношения между акторами и прецедентами и являющаяся составной частью модели прецедентов, позволяющей описать систему на концептуальном уровне. 

Use case модель (см.рис. 1)

![image](https://user-images.githubusercontent.com/105608709/201178640-4a77ad2c-cf02-4a06-9621-b546e0a7ce32.png)


Рисунок 1  Use case модель

 

 ## 1.4 Создание BPMN модели.
Основная цель BPMN — создание стандартного набора условных обозначений, понятных всем бизнес-пользователям. Бизнес-пользователи включают в себя бизнес-аналитиков, создающих и улучшающих процессы, технических разработчиков, ответственных за реализацию процессов и менеджеров, следящих за процессами и управляющих ими. Следовательно, BPMN призвана служить связующим звеном между фазой дизайна бизнес - процесса и фазой его реализации.

Знаки, использующиеся в модели:

Начало ![](Aspose.Words.d321dc0a-afc4-4ce2-9588-b191deac4d38.001.png)		Конец ![](Aspose.Words.d321dc0a-afc4-4ce2-9588-b191deac4d38.002.png) 		     Шлюз (или)  	![](Aspose.Words.d321dc0a-afc4-4ce2-9588-b191deac4d38.003.png)	            Таймер ![](Aspose.Words.d321dc0a-afc4-4ce2-9588-b191deac4d38.004.png)            
			



Моделирование бизнес-процессов используется для донесения широкого спектра информации до различных категорий пользователей. Диаграммы бизнес-процессов позволяют описывать сквозные бизнес-процессы, но в то же время помогают читателям быстро понимать процесс и легко ориентироваться в его логике.

## BPMN-модель
Основной бизнес-процесс парикмахерской 


![as](https://user-images.githubusercontent.com/105608709/198399796-8e3ac7bf-8ba5-47f6-8fa3-ca01ed65b374.jpg)
Рисунок 2 BPMN-модель



















## Подпроцесс «Воспользоваться услугой»

Тут мы рассмотрим более подробно подпроцесс «Воспользоваться услугой». Все начинается с того что, задерживается специалист которого выбрал клиент, отсутствует или он на месте. Если специалист сегодня отсутствует, то услуга клиента переносится на другой день, если же специалист задерживается, клиенту предлагают его подождать, или же специалист на рабочем месте, то дальше выполняется  услуга которую выбрал клиент. (см рис. 3)











![](Aspose.Words.d321dc0a-afc4-4ce2-9588-b191deac4d38.006.png)
Рисунок 3 Подпроцесс «Воспользоваться услугой»

##  Подпроцесс «Оценки услуги»

Ситуация когда клиенту не понравилась услуга. Клиент подает жалобу на специалиста. Далее клиенту предлагают скидку на следующий прием в размере 50% или же исправление проделанной услуги. (см. рис. 4).



![](Aspose.Words.d321dc0a-afc4-4ce2-9588-b191deac4d38.007.png)

Рисунок 4 Подпроцесс «Оценки услуги»

## 1.5 ER-диаграмма

ER-диаграмма — это разновидность блок-схемы, где показано, как разные «сущности» (люди, объекты, концепции и так далее) связаны между собой внутри системы.

![image](https://user-images.githubusercontent.com/105608709/201200283-d8b1f5bb-591f-4d9c-af38-e953aad4a96e.png)
Риисунок 5 ER-диаграмма


## 1.6 Проблематика предметной области

Главной проблемой являются большие трудозатраты сотрудников на ведение учета работы салона, что может привести к появлению ошибок.



## 1.7 Сравнительный анализ
Методы решения проблемы больших трудозатрат сотрудников на ведение учета работы салона:
1. Наем большего числа сторудников 
2. Создание информационной системы

Плюсы и минусы ИС:

(+) Низкая стоимость содержания 

(+) Стабильная работа

(-) Невозможность решения нештатных задач

Плюсы и минусы наема сотрудников:

(+) Возможность решения нештатных задач

(+) Предложения по улучшению работы 

(-) Высокая стоимость содержания

(-) Нестабильное выполнение работы

(-) Необходима мотивация (премии, повышение зп и т.д)


