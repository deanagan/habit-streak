using System.Collections.ObjectModel;

namespace HabitStreak.Views;

public partial class ProgressPage : ContentPage
{
    public ObservableCollection<DateItem> DateItems { get; } = new();

    public ProgressPage()
    {
        InitializeComponent();
        BindingContext = this;
        LoadDates();
    }

    private void LoadDates()
    {
        var today = DateTime.Today;
        var startDate = today.AddDays(-21); // 3 weeks ago
        
        for (int i = 0; i <= 21; i++) // From 3 weeks ago up to today
        {
            var date = startDate.AddDays(i);
            if (date <= today) // Only add dates up to today
            {
                DateItems.Add(new DateItem
                {
                    Date = date,
                    IsToday = date.Date == today,
                    // TODO: Replace this with actual habit achievement data
                    IsAchieved = Random.Shared.Next(2) == 1 // Randomly set achieved for demo
                });
            }
        }
    }
}

public class DateItem
{
    public DateTime Date { get; set; }
    public bool IsToday { get; set; }
    public bool IsAchieved { get; set; }
}