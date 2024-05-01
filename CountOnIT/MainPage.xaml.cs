using CountOnIT.Data;

namespace CountOnIT
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage(DataMock write, DataMock read)
        {
            InitializeComponent();
            Console.WriteLine("KÆMPEE TEST");
            write.Write();
            read.Read();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            //if (count == 1)
                //CounterBtn.Text = $"Clicked {count} time";
           // else
                //CounterBtn.Text = $"Clicked {count} times";

            //SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
