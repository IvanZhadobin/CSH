using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СSharp1
{
    class State
    {
        private string name;
        private List<Region> region = new List<Region>();
        private List<District> district = new List<District>();
        private List<City> city = new List<City>();
        public State(string name)
        {
            this.name = name;
        }
        public string get_Name()
        {
            return name;
        }
        public void add_region(Region name)
        {
            region.Add(name);
        }
        public void add_district(District name)
        {
            district.Add(name);
        }
        public void add_city(City name)
        {
            city.Add(name);
        }
        public int count_region()
        {
            return region.Count();
        }
        public int count_district()
        {
            return district.Count();
        }
        public int count_city()
        {
            return city.Count();
        }
        public List<Region> get_region()
        {
            return region;
        }
        public List<District> get_district()
        {
            return district;
        }
        public List<City> get_city()
        {
            return city;
        }
    }
}