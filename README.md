# Принцип DRY (Don't repeat yourself)
Цей принцип у коді був використаний, оскільки в реалізованих класах дублювання коду відсутнє. Крім того, можу стверджувати, що мій проєкт відповідає фразі: «Кожна частинка знання повинна мати єдине, однозначне і надійне представлення в системі».


# Fail First
Даний шаблон проєктування відповідає за негайну обробку помилок у програмному коді замість того щоб намагатися продовжити його виконання. Мій код у цілому відповідає цьому принципу, використовується в тих фрагментах коду, де потрібно унеможливити неправильне використання операцій із числами, зокрема в класі Money при встановленні відповідних значень цілої частини та копійок (метод SetValues): 
[Відповідний фрагмент коду](https://github.com/koretskyiii/DesignPatterns_Koretskyii/blob/90d5fdef0a305088ab85ff86293fe2e03e63c4f4/lab1/ClassLibrary/Money.cs#L17C1-L25C10), а також в класі Product при операції зниження ціни: [фрагмент](https://github.com/koretskyiii/DesignPatterns_Koretskyii/blob/90d5fdef0a305088ab85ff86293fe2e03e63c4f4/lab1/ClassLibrary/Product.cs#L20C2-L27C10).


# KISS
Код є досить простим та зрозумілим, не перевантажений складними конструкціями, також використовувались максимально зрозумілі та інтуїтивні назви класів та методів. Питання може викликати тільки ця [умова](https://github.com/koretskyiii/DesignPatterns_Koretskyii/blob/90d5fdef0a305088ab85ff86293fe2e03e63c4f4/lab1/ClassLibrary/Product.cs#L22C13-L22C149), але суб'єктивно мені вона не видається критично перевантаженою, щоб її модифікувати. 

# YAGNI
Не використовується код який не потрібен у межах даного завдання - як приклад можна навести метод класу Product (товар) [DecreasePrice](https://github.com/koretskyiii/DesignPatterns_Koretskyii/blob/90d5fdef0a305088ab85ff86293fe2e03e63c4f4/lab1/ClassLibrary/Product.cs#L22C13-L22C149), який реалізовує функціонал зменшення ціни (що прямо вимагалося у завданні), але реалізації інших операцій із ціною товару відсутні. Це дозволяє не нагромаджувати код, який скоріше за все, ніколи або в близькому майбутньому не використається. 


# Composition  over Inheritance
Цей принцип стверджує, що система має бути побудована як комбінація простих об’єктів, а не використовуючи складні ієрархії наслідування. Мій код частково відповідає цим вимогам. У класі **Product**  є властивість *Price*, що має клас **Money** ([фрагмент](https://github.com/koretskyiii/DesignPatterns_Koretskyii/blob/90d5fdef0a305088ab85ff86293fe2e03e63c4f4/lab1/ClassLibrary/Product.cs#L12C8-L12C49)), клас **Warehouse** складається зі списку об’єктів класу **WarehouseItem** ([фрагмент](https://github.com/koretskyiii/DesignPatterns_Koretskyii/blob/90d5fdef0a305088ab85ff86293fe2e03e63c4f4/lab1/ClassLibrary/Warehouse.cs#L11C8-L11C70)), а клас **Reporting** містить об’єкт класу **Warehouse** ([фрагмент](https://github.com/koretskyiii/DesignPatterns_Koretskyii/blob/90d5fdef0a305088ab85ff86293fe2e03e63c4f4/lab1/ClassLibrary/Reporting.cs#L11C8-L11C37)), з яким проводить такі дії, як реєстрація надходження товарів або їх відвантаження, звіт з інвентаризації.


# Program to Interfaces not Implementations
Частково, проте не в повній мірі використовується. Створено інтерфейс ICurrency, який відповідає за властивість [CurrencyCode](https://github.com/koretskyiii/DesignPatterns_Koretskyii/blob/90d5fdef0a305088ab85ff86293fe2e03e63c4f4/lab1/ClassLibrary/ICurrency.cs#L11C8-L11C44) (тобто визначник валюти) для класу Money та похідних (Dollar, Euro, та інших підкласів якими можна буде розширити нашу існуючу систему: гривня, фунти, тощо). Проте я не впевнений що одного інтерфейса може вистачити щоб точно стверджувати що мій проєкт на 200% відповідає даному принципу

# Single-Responsibility Principle 
Кожен клас виконує одну задачу – Money відповідає за [операції з коштами](https://github.com/koretskyiii/DesignPatterns_Koretskyii/blob/90d5fdef0a305088ab85ff86293fe2e03e63c4f4/lab1/ClassLibrary/Money.cs#L17C8-L17C65), Product (товар) за операції з відповідними товарами (у даному контексті [зниження ціни на товар](https://github.com/koretskyiii/DesignPatterns_Koretskyii/blob/90d5fdef0a305088ab85ff86293fe2e03e63c4f4/lab1/ClassLibrary/Product.cs#L20C8-L27C10)), 	[Warehouse](https://github.com/koretskyiii/DesignPatterns_Koretskyii/blob/90d5fdef0a305088ab85ff86293fe2e03e63c4f4/lab1/ClassLibrary/Warehouse.cs#L9C1-L22C6) містить інформацію про товари що є на складі, а WarehouseItem відповідає за [опис одиниці товару](https://github.com/koretskyiii/DesignPatterns_Koretskyii/blob/90d5fdef0a305088ab85ff86293fe2e03e63c4f4/lab1/ClassLibrary/WarehouseItem.cs#L11C1-L15C55). Reporting тут же займається звітністю – [реєструє/видаляє  товари на складі](https://github.com/koretskyiii/DesignPatterns_Koretskyii/blob/90d5fdef0a305088ab85ff86293fe2e03e63c4f4/lab1/ClassLibrary/Reporting.cs#L18C1-L26C10), а також проводить [звіт з інвентаризації](https://github.com/koretskyiii/DesignPatterns_Koretskyii/blob/90d5fdef0a305088ab85ff86293fe2e03e63c4f4/lab1/ClassLibrary/Reporting.cs#L28C1-L36C10). Тому можна сказати що цього принципу було дотримано.


# Open-Closed Principle
Мій код відповідає цьому принципу - як приклад можна навести клас Money та спеціалізовані підкласи [Dollar](https://github.com/koretskyiii/DesignPatterns_Koretskyii/blob/90d5fdef0a305088ab85ff86293fe2e03e63c4f4/lab1/ClassLibrary/Dollar.cs#L9C4-L16C6) та [Euro](https://github.com/koretskyiii/DesignPatterns_Koretskyii/blob/90d5fdef0a305088ab85ff86293fe2e03e63c4f4/lab1/ClassLibrary/Euro.cs#L9C2-L16C6), що дозволяє таким чином розширювати функціонал, але не модифікувати вихідний клас [Money](https://github.com/koretskyiii/DesignPatterns_Koretskyii/blob/90d5fdef0a305088ab85ff86293fe2e03e63c4f4/lab1/ClassLibrary/Money.cs#L4C3-L31C6). Також інтерфейс [ICurrency](https://github.com/koretskyiii/DesignPatterns_Koretskyii/blob/90d5fdef0a305088ab85ff86293fe2e03e63c4f4/lab1/ClassLibrary/ICurrency.cs#L9C2-L13C6) дозволяє додавати нові валюти без зміни вже існуючого коду. 


# Liskov Substitution Principle
Якщо поглянути на клас Money та підкласи Dollar та Euro, то останніми двома можна замінити вихідний клас (Money), при цьому не змін у роботі програми. Це відповідає принципу підстановки, отже в цьому фрагменті можемо говорити з твердою упевненістю що ми дотримались правил третього закону SOLID.


# Interface Segregation Principle
У мене всього один інтерфейс [ICurrency](https://github.com/koretskyiii/DesignPatterns_Koretskyii/blob/90d5fdef0a305088ab85ff86293fe2e03e63c4f4/lab1/ClassLibrary/ICurrency.cs#L9C2-L13C6), і він досить спеціалізований та виконує лише одне завдання (визначає валюту), тому нема потреби розбивати його на ще менші. Цьому принципу моя реалізація завдання не відповідає. 

# Dependency Inversion Principle
Принцип DIP відповідає за те щоб:
1. високорівневі модулі не залежали від низькорівневих модулів - в моїй структурі коду є чітка ієрархія, де загальний високорівневий клас Money визначає всі загальні методи та поведінку, які наслідують його похідні класи
2. Абстракції не повинні залежати від деталей. Деталі повинні залежати від абстракцій - та сама ситуація, що у попередньому пункті. Інтерфейс ICurrency та клас Money встановлюють правила та структуру, а класи Dollar та Euro займаються безпосередньою реалізацією. Відповідно, від конкретних реалізацій більш високорівневі модулі не залежать узагалі. 
Загалом цього принципу у коді було дотримано. 🤠





