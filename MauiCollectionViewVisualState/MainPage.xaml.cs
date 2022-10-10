using System.Collections.ObjectModel;

namespace MauiCollectionViewVisualState;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = this;
    }

    public ObservableCollection<string> DataStrings { get; set; }
        = new ObservableCollection<string>
            {
                "AAAA","BBBB","CCCC","DDDD"
            };
    string _DataStrings_SelectedItem = null;
    public string DataStrings_SelectedItem
    {
        get { return _DataStrings_SelectedItem; }
        set 
        {
            _DataStrings_SelectedItem = value;
            OnPropertyChanged(nameof(DataStrings_SelectedItem));
            OnPropertyChanged(nameof(DataStrings_Text));
        }
    }
    public string DataStrings_Text
    {
        get
        {
            return DataStrings_SelectedItem;
        }
    }
    private void ButtonStrings_Clicked(object sender, EventArgs e)
    {
        DataStrings_SelectedItem = DataStrings[1];
    }
}
