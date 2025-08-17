using System.Collections.ObjectModel;

namespace HabitStreak.Views;

public partial class HabitsPage : ContentPage
{
    public ObservableCollection<HabitItem> Habits { get; } = new();

    public HabitsPage()
    {
        InitializeComponent();
        BindingContext = this;
    }

    private async void OnAddHabitClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LogHabitPage());
    }
}

public class HabitItem
{
    public string Name { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public string Details { get; set; } = string.Empty;
    public string Story { get; set; } = string.Empty;
}