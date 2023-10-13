namespace Unidad6_Ejercicio1
{
    public partial class MainPage : ContentPage
    {
        bool buttonCreated = false;

        public MainPage()
        {
            InitializeComponent();
        }

        private void button3(object sender, EventArgs e) {
            if(buttonCreated==false) {
                Button button3 = new Button()
                {
                    Text = "Button3",
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center,
                    MaximumHeightRequest = 70,
                    MinimumWidthRequest = 200,
                    FontFamily = "Verdana",
                    FontAttributes = FontAttributes.Bold,
                    FontSize = 16,
                    BorderColor = Microsoft.Maui.Graphics.Color.FromArgb("#FFFFFF00"),
                    BackgroundColor = Microsoft.Maui.Graphics.Color.FromArgb("#FF0000FF"),
                    TextColor = Microsoft.Maui.Graphics.Color.FromArgb("#FFFFFFFF"),
                    Margin = 30,
                };
                button3.Clicked += new EventHandler(btnClicked);
                buttonGroup.Children.Add(button3);
                buttonCreated = true;
            }

            void btnClicked(object sender, EventArgs e) {
                buttonGroup.Children.Remove(button1);
                button2.Text = "Creating controls at runtime is cool!";
            }

        }

    }
}