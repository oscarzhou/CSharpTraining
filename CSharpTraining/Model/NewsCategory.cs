
namespace Model
{
    public class NewsCategory
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public NewsCategory(int id, string name)
        {
            this.CategoryId = id;
            this.CategoryName = name;
        }
    }
}
