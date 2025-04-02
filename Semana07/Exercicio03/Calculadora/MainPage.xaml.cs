using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace CalculadoraMAUI;

public partial class MainPage : ContentPage, INotifyPropertyChanged
{
    private string _currentNumber = "0";
    private string _previousNumber;
    private string _operation;
    private bool _isOperationSelected;

    public string CurrentNumber
    {
        get => _currentNumber;
        set
        {
            _currentNumber = value;
            OnPropertyChanged();
        }
    }

    public ICommand NumberCommand { get; }
    public ICommand OperationCommand { get; }
    public ICommand ClearCommand { get; }
    public ICommand CalculateCommand { get; }

    public MainPage()
    {
        InitializeComponent();
        BindingContext = this;

        NumberCommand = new Command<string>(AddNumber);
        OperationCommand = new Command<string>(SelectOperation);
        ClearCommand = new Command(Clear);
        CalculateCommand = new Command(Calculate);
    }

    private void AddNumber(string number)
    {
        if (CurrentNumber == "0" || _isOperationSelected)
        {
            CurrentNumber = number;
            _isOperationSelected = false;
        }
        else
        {
            CurrentNumber += number;
        }
    }

    private void SelectOperation(string operation)
    {
        _previousNumber = CurrentNumber;
        _operation = operation;
        _isOperationSelected = true;
    }

    private void Clear()
    {
        CurrentNumber = "0";
        _previousNumber = null;
        _operation = null;
    }

    private void Calculate()
    {
        if (_previousNumber == null || _operation == null)
            return;

        double.TryParse(_previousNumber, out double num1);
        double.TryParse(CurrentNumber, out double num2);

        double result = 0;

        switch (_operation)
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                result = num1 / num2;
                break;
        }

        CurrentNumber = result.ToString();
        _operation = null;
        _previousNumber = null;
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}