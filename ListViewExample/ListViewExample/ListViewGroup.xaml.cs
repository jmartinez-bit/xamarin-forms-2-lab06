using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace ListViewExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewGroup : ContentPage
    {
        private ObservableCollection<GroupedArtistModel> grouped { get; set; }
        public ListViewGroup()
        {
            InitializeComponent();
			grouped = new ObservableCollection<GroupedArtistModel>();
			var rock = new GroupedArtistModel() { LongName = "Rock", ShortName = "R" };
			var pop = new GroupedArtistModel() { LongName = "Pop", ShortName = "P" };
			var shoegazing = new GroupedArtistModel() { LongName = "Shoegazing", ShortName = "S" };
			rock.Add(new ArtistModel() { Name = "Eddie Vedder", Band = "Perl Jam" });
			rock.Add(new ArtistModel() { Name = "Roger Waters", Band = "Pink Floyd" });
			rock.Add(new ArtistModel() { Name = "Bono", Band = "U2" });
			pop.Add(new ArtistModel() { Name = "Adam Levine", Band = "Maroon 5" });
			pop.Add(new ArtistModel() { Name = "Sigrid Raabe", Band = "Sigrid" });
			pop.Add(new ArtistModel() { Name = "Molly Rankin", Band = "Alvvays" });
			shoegazing.Add(new ArtistModel() { Name = "Rachel Goswell", Band = "Slowdive" });
			shoegazing.Add(new ArtistModel() { Name = "Anthony Gonzalez", Band = "M83" });
			shoegazing.Add(new ArtistModel() { Name = "Johan Duncanson", Band = "The Radio Dept." });

			grouped.Add(rock); grouped.Add(pop); grouped.Add(shoegazing);
			lstView.ItemsSource = grouped;
		}
    }
}