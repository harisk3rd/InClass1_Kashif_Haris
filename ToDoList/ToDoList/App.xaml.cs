using ToDoList.Views;
namespace ToDoList
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            Window window = new Window(new NavigationPage(new Views.ToDoItemPage()));

            window.Width = 480;
            window.Height = 640;

            return window;
        }
    }
}
