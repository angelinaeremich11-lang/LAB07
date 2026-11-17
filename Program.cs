using LAB07;

Document[] documents = new Document[10];

DateTime today = DateTime.Now;

documents[0] = new Order("Закупка оборудования", today, today.AddDays(2), "ORD-001", "Директор", "Купить 10 ПК");
documents[1] = new Order("Уборка территории", today, today.AddDays(10), "ORD-002", "Зам. директора", "Убрать листья");
documents[2] = new Letter("Коммерческое предложение", today, today.AddDays(5), "ООО Ромашка", "Наш отдел", "Скидки на товары");
documents[3] = new Letter("Жалоба клиента", today, today.AddDays(1), "Иванов И.И.", "Директор", "Плохое обслуживание");
documents[4] = new Payment("Оплата интернета", today, today.AddDays(3), "INV-101", 1500m, "Интернет за месяц");
documents[5] = new Payment("Оплата аренды", today, today.AddDays(4), "INV-102", 50000m, "Аренда офиса"); // Большая сумма
documents[6] = new Transfer("Передача ноутбука", today, today.AddDays(1), "Склад", "Отдел разработки", "Ноутбук Lenovo", 1, 80000m);
documents[7] = new Transfer("Передача документов", today, today.AddDays(7), "Бухгалтерия", "Архив", "Папка с отчетами", 5, 0m);
documents[8] = new Order("Совещание", today, today.AddDays(15), "ORD-003", "Руководитель", "Планерка");
documents[9] = new Letter("Спам", today, today.AddDays(30), "Неизвестный", "Всем", "Выиграйте миллион");

foreach (Document doc in documents)
{
    doc.CalculatePriority();
    Console.WriteLine(doc.ToString());
}

Document highestPriorityDoc = documents[0];
foreach (Document doc in documents)
{
    if (doc.Priority > highestPriorityDoc.Priority)
    {
        highestPriorityDoc = doc;
    }
}
Console.WriteLine(highestPriorityDoc.ToString());

Document closestDoc = documents[0];
foreach (Document doc in documents)
{
    if (doc.GetDaysToExecution() < closestDoc.GetDaysToExecution())
    {
        closestDoc = doc;
    }
}
Console.WriteLine(closestDoc.ToString());