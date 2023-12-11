using System.Windows.Input;

namespace BMICalc.Components;

public partial class ImageFrameComponent : ContentView
{
    public event EventHandler Tapped;

    public static readonly BindableProperty TextProperty =
    BindableProperty.Create(nameof(Text), typeof(string), typeof(ImageFrameComponent));

    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    public static readonly BindableProperty BorderColorProperty =
    BindableProperty.Create(nameof(BorderColor), typeof(Color), typeof(ImageFrameComponent), defaultValue:Color.FromArgb("#474747"));

    public Color BorderColor
    {
        get => (Color)GetValue(BorderColorProperty);
        set => SetValue(SourceProperty, value);
    }


    public static readonly BindableProperty SourceProperty =
    BindableProperty.Create(nameof(Source), typeof(ImageSource), typeof(ImageFrameComponent));

    public ImageSource Source
    {
        get => (ImageSource)GetValue(SourceProperty);
        set => SetValue(SourceProperty, value);
    }

    public static readonly BindableProperty CommandProperty =
    BindableProperty.Create(nameof(Command), typeof(ICommand), typeof(ImageFrameComponent));

    public ICommand Command
    {
        get => (ICommand)GetValue(SourceProperty);
        set => SetValue(SourceProperty, value);
    }

    public static readonly BindableProperty CommandParameterProperty =
    BindableProperty.Create(nameof(CommandParameter), typeof(object), typeof(ImageFrameComponent));

    public object CommandParameter
    {
        get => (object)GetValue(SourceProperty);
        set => SetValue(SourceProperty, value);
    }

    public ImageFrameComponent()
	{
		InitializeComponent();
        Content.BindingContext = this;
	}

    void TapGestureRecognizer_Tapped(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
        Command?.Execute(CommandParameter);
        Tapped?.Invoke(this, EventArgs.Empty);
    }
}
