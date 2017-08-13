
using Model;
using System.Collections.Generic;

namespace DAL
{
    public class NewsService
    {
        public List<NewsCategory> GetNewsCategory()
        {
            List<NewsCategory> list = new List<NewsCategory>();
            list.Add(new NewsCategory(1,"Education"));
            list.Add(new NewsCategory(2,"Media"));
            list.Add(new NewsCategory(3,"Vehicle"));
            list.Add(new NewsCategory(4,"Military"));

            return list;
        }
    }
}
