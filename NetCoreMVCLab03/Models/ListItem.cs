namespace NetCoreMVCLab03.Models
{
    public class ListItem
    {
        public string Id { get; set; }
        private List<Item> Items { get; set; }

        public ListItem(string Id)
        {
            this.Id = Id;
            Items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public List<Item> GetItems()
        {
            return Items;
        }
    }
}
