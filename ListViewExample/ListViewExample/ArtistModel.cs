using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace ListViewExample
{
    public class ArtistModel
    {
        public string Band { get; set; }
        public string Name { get; set; }
        public string Song { get; set; }

        public ArtistModel()
        {
        }
    }

    public class GroupedArtistModel : ObservableCollection<ArtistModel>
    {
        public string LongName { get; set; }
        public string ShortName { get; set; }
    }
}
