using MauiApp1.TiposPaginas.FTabbedPage;

namespace MauiApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //                                              //Pagina de tipo ContentPage utilizando Navegacion.
            //var navPage = new NavigationPage(new MainPage());
            //navPage.BarBackground = Colors.SpringGreen;
            //MainPage = navPage;

            //                                              //Pagina de tipo FlyoutPage.
            //MainPage = new FlayoutPageDemo();

            //                                              //Pagina de tipo TabbedPage
            MainPage = new TabbedPageDemo();
        }
    }
}