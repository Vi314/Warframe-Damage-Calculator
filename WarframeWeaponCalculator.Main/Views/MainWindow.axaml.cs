using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace WarframeWeaponCalculator.Main.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    
    public void CalculateDamage(object source, RoutedEventArgs args)
    {
        var damage = TotalDamage.Value;
        var critMulti = CriticalDamage.Value;
        var critChance = CriticalChance.Value;
        decimal result = ((damage * critMulti) * (critChance / 100)) ?? default;
        CalculationResult.Text = $"\t\t {result:0.00} Damage Per Hit";
        Debug.WriteLine("Click!");
    }
}