using CountOnIT.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace CountOnIT.ViewModels
{
    public class ProductViewModel : INotifyPropertyChanged
    {
        #region Fields

        private ObservableCollection<ProductModel> productsInfo;
        private ProductModel selectedProduct;

        #endregion

        #region Properties
        public ProductModel SelectedProduct
        {
            get
            {
                return selectedProduct;
            }
            set
            {
                selectedProduct = value;
                OnPropertyChanged("SelectedItem");
            }
        }
        public ObservableCollection<Contact> ProductsInfo
        {
            get
            {
                return productsInfo;
            }
            set
            {
                productsInfo = value;
                OnPropertyChanged("ContactsInfo");
            }
        }

        #endregion

        #region Constructor
        public ContactsViewModel()
        {
            GenerateContacts();
        }
        #endregion

        #region Methods

        private void GenerateContacts()
        {
            ContactsInfo = new ObservableCollection<Contact>();
            ContactsInfo = new ContactsInfoRepository().GetContactDetails(20);
            PopulateDB();
        }

        private async void PopulateDB()
        {
            foreach (Contact contact in ContactsInfo)
            {
                var item = await App.Database.GetContactAsync(contact);
                if (item == null)
                    await App.Database.AddContactAsync(contact);
            }
        }
        private async void OnAddNewItem()
        {
            await App.Database.AddContactAsync(SelectedItem);
            ContactsInfo.Add(SelectedItem);
            await App.Current.MainPage.Navigation.PopAsync();
        }

        #endregion

        #region Interface Member

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #endregion
    }
}
