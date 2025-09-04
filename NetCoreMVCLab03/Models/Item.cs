namespace NetCoreMVCLab03.Models
{
    public class Item
    {
        public int id { get; set; }
        public string title { get; set; }
        public string ImgUrl { get; set; }

        public Item(int id, string title, string ImgUrl)
        {
            this.id = id;
            this.title = title;
            this.ImgUrl = ImgUrl;
        }
    }
}
