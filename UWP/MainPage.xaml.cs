namespace WorkingWithMaps.UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();
            Xamarin.FormsMaps.Init("Am4-WsSh9-5v2vWH5ceEDF5nupf8ifwRmjuQ3CL9yZ3o7h2l81yqr9KIM7Jn3XpX");
            this.LoadApplication(new WorkingWithMaps.App());
        }
    }
}
