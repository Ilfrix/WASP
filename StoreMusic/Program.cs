using System;

namespace Music
{
    public interface IStoreItem
    {
        public double Price { get; set; }
        void DiscountPrice(int percent){}
    }
    class Disk : IStoreItem
    {
        protected string _name;
        protected string _genre;
        protected int _burnCout;
        public double Price { get; set; }
        public int BurnCout { get => _burnCout; set => _burnCout = value; }

        public Disk(string name, string genre)
        {
            _name = name;
            _genre = genre;
        }
        public virtual int DiskSize { get; set; }


        public virtual void Burn(params string[] values) {}

        public void DiscountPrice(int percent)
        {
            Price -= Price * percent / 100;

        }
    }

    class Audio : Disk
    {
        protected string _artist;
        protected string _recordingStudio;
        protected int _songsNumber;
        

        public Audio (string artist, string recordingStudio, int songsNumber, string name, string genre) : base(name, genre)
        {
            _artist = artist;
            _recordingStudio = recordingStudio;
            _songsNumber = songsNumber;
        }
        public int DiskSize()
        {
            return 8 * _songsNumber;
        }
        public void Burn(string artist, string recordingStudio, string songsNumber,string name, string genre)
        {
            _artist = artist;
            _recordingStudio = recordingStudio;
            _songsNumber = Convert.ToInt32(songsNumber);
            _name = name;
            _genre = genre;
            BurnCout += 1;
        }
        public override string ToString()
        {
            string result = "";
            result = $"{_name} {_genre} {_artist} {_recordingStudio} {_songsNumber} {_burnCout}";
            return result;
        }
    }

    class DVD : Disk
    {
        private string _producer;
        private string _filmCompony;
        private int _minutesCount;


        public DVD(string producer, string filmCompony, int minutesCount, string name, string genre) : base(name, genre)
        {
            _producer = producer;
            _filmCompony = filmCompony;
            _minutesCount = minutesCount;
        }
        
        public int DiskSize() {
            return (_minutesCount / 64) * 2;
        }
        public override void Burn(params string[] values)
        {
            //точно ли так?
            base.Burn(values);
            BurnCout += 1;
        }
        public override string ToString()
        {
            return $"{_name} {_genre} {_producer} {_filmCompony} {_minutesCount} {_burnCout}";
        }
    }

    class Store
    {
        private string _storeName;
        private string _adress;
        private List <Audio> _audios = new List <Audio>();
        private List<DVD> _dvds = new List<DVD>();

        public Store(string storeName, string adress)
        {
            _storeName = storeName;
            _adress = adress;
        }

        public void AddAudio(Audio new_audio)
        {
            _audios.Add(new_audio);
        }
        public void AddDVD(DVD new_dvd)
        {
            _dvds.Add(new_dvd);
        }
        public void ClearAudio(Audio old_audio)
        {
            _audios.Remove(old_audio);
        }
        public void ClearDVD(DVD old_dvd)
        {
            _dvds.Remove(old_dvd);
        }

        public override string ToString()
        {
            string result = "";
            result += "DVD: ";
            foreach (DVD dvd in _dvds)
            {
                result += dvd.ToString() + " ";
            }
            result += "\n Audio:";

            foreach (Audio audio in _audios)
            {
                result += audio.ToString() + " ";
            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Audio first_audio = new Audio("Mike", "THEbest", 1, "firstsong", "pop");
            Audio second_audio = new Audio("Nick", "NotBad", 2, "Best^)", "rock");
            Audio third_audio = new Audio("Steve", "BAD", 3, "Sleep", "classic");
            DVD dvd_1 = new DVD("Jogh", "Disney", 1000, "DEADLINE", "horror");
            DVD dvd_2 = new DVD("Smth", "DC", 900, "Hunt", "horror");

            Store new_store = new Store("firstStore", "Main_1");
            new_store.AddAudio(first_audio);
            new_store.AddAudio(second_audio);
            new_store.AddAudio(third_audio);
            new_store.AddDVD(dvd_1);
            new_store.AddDVD(dvd_2);
            Console.WriteLine(new_store.ToString());
        }
    }
}
