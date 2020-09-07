using Multi_Launcher_V2.Model;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Multi_Launcher_V2 {
    public class Category {

        [XmlAttribute]
        public int Id { get; set; }

        [XmlAttribute]
        public string Name { get; set; }

        //private ListCollectionView _itemsCollectionView;

        public ObservableCollection<Item> Items { get; set; }

        [XmlIgnore]
        public ImageList ImageList { get; set; }

        public Category() {
            ImageList = new ImageList();

            InitializeItemCollection();
        }


        // Add corresponding image and category to added items
        private void OnItemAdded(object sender, NotifyCollectionChangedEventArgs eventArgs) {

            if (eventArgs.Action != NotifyCollectionChangedAction.Add) return;

            eventArgs.NewItems
                .Cast<Item>()
                .ToList()
                .ForEach(item => {
                    if (item.ImageId == null) item.ImageId = "defaultImg";

                    item.Image = FileManager.GetImgFromResource(item.ImageId);

                    ImageList.Images.Add(item.ImageId, item.Image);

                    item.Category = this;
                });
        }

        private void InitializeItemCollection() {
            Items = new ObservableCollection<Item>();
            Items.CollectionChanged += new NotifyCollectionChangedEventHandler(OnItemAdded);

            //_itemsCollectionView = CollectionViewSource.GetDefaultView(Items)
            //    as ListCollectionView;
        }

        // FIXME
        public void SortItems(SortOrder sortOrder) {

            //if (_itemsCollectionView != null) {
            //    _itemsCollectionView.IsLiveSorting = true;


            //    var comparer = Comparer<Item>.Create((x, y) =>
            //        sortOrder == SortOrder.Ascending
            //         ? x.Name.CompareTo(y.Name)
            //         : y.Name.CompareTo(x.Name));

            //    _itemsCollectionView.CustomSort = comparer;
            //    _itemsCollectionView.Refresh();
            //}
        }
    }
}
