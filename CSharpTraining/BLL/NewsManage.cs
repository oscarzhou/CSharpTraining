using DAL;
using Model;
using System.Collections.Generic;

namespace BLL
{
    public class NewsManage
    {
        public List<NewsCategory> GetNewsCategory()
        {
            return new NewsService().GetNewsCategory();
        }
    }
}
