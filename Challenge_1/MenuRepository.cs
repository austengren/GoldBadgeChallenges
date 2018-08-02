using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    public class MenuRepository
    {
        private List<CafeMenu> _cafeMenu = new List<CafeMenu>();

        // Methods
        public void AddItemToMenu(CafeMenu item)
        {
            _cafeMenu.Add(item);
        }

        public void RemoveItemFromMenu(CafeMenu item)
        {
            _cafeMenu.Remove(item);
        }

        public List<CafeMenu> GetList()
        {
            return _cafeMenu;
        }

        public void AddMealByName(CafeMenu meal)
        {
            _cafeMenu.Add(meal);
        }

        public void RemoveMealByName(CafeMenu meal)
        {
            _cafeMenu.Remove(meal);
        }

        public int GetCount()
        {
            return _cafeMenu.Count;
        }
    }
}
