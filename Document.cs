public enum DocumentStatus {Registered, InProgress, Completed, Cancelled}

public enum DocumentPriority {Low, Medium, High, Urgent}

public class Document
{
    public string Title { get; set; }
    public DateTime RegistrationDate { get; set; }
    public DateTime ExecutionDate { get; set; }
    public DocumentStatus Status { get; set; }
    public DocumentPriority Priority { get; set; }

    public Document(string title, DateTime registrationDate, DateTime executionDate)
    {
        Title = title;
        RegistrationDate = registrationDate;
        ExecutionDate = executionDate;
        Status = DocumentStatus.Registered;
        Priority = DocumentPriority.Low;
    }
    public int GetDaysToExecution()
    {
        TimeSpan difference = ExecutionDate - DateTime.Now;
        return (int)difference.TotalDays;
    }
    public virtual void CalculatePriority()
    {
        int daysLeft = GetDaysToExecution();

        if (daysLeft < 3) Priority = DocumentPriority.Urgent;
        else if (daysLeft < 7) Priority = DocumentPriority.High;
        else if (daysLeft < 14) Priority = DocumentPriority.Medium;
        else Priority = DocumentPriority.Low;
    }
    public override string ToString()
    {
        return $"{GetType().Name}: {Title}, Статус: {Status}, Приоритет: {Priority}, Дней до срока: {GetDaysToExecution()}";
    }
}