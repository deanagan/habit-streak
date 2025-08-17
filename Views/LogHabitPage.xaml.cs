using System.Windows.Input;

namespace HabitStreak.Views;

public partial class LogHabitPage : ContentPage
{
    public bool IsAchieved { get; set; }
    public string Details { get; set; } = string.Empty;
    public string Story { get; set; } = string.Empty;
    
    public ICommand SaveCommand { get; }

    public LogHabitPage()
    {
        InitializeComponent();
        BindingContext = this;

        SaveCommand = new Command(async () => await SaveHabitAchievement());
    }

    private async Task SaveHabitAchievement()
    {
        // TODO: Save the habit achievement to your data storage
        
        // For now, just show a confirmation and close the page
        await DisplayAlert("Success", "Habit logged successfully!", "OK");
        await Navigation.PopAsync();
    }
}
