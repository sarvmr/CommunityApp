using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CommunityApp.Models;

namespace CommunityApp.Data;

public static class SeedData
{
    // this is an extension method to the ModelBuilder class
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Province>().HasData(
            GetProvinces()
        );
        modelBuilder.Entity<City>().HasData(
            GetCities()
        );
    }
    public static List<Province> GetProvinces()
    {
        List<Province> provinces = new List<Province>() {
            new Province() {    // 1
                ProvinceCode="BC",
                ProvinceName="British Columbia"
            },
            new Province() {    //2
                ProvinceCode="AB",
                ProvinceName="Alberta",
            },
            new Province() {    // 3
                ProvinceCode="ON",
                ProvinceName="Ontario"
            },

        };

        return provinces;
    }

    public static List<City> GetCities()
    {
        List<City> cities = new List<City>() {
            new City {
                CityId = 1,
                CityName = "Vancouver",
                Population = 1000000,
                ProvinceCode = "BC"            
            },
            new City {
                CityId = 2,
                CityName = "Calgary",
                Population = 500000,
                ProvinceCode = "AB"
            },
            new City {
                CityId = 3,
                CityName = "Toronto",
                Population = 1500000,
                ProvinceCode = "ON"
            },
            new City {
                CityId = 4,
                CityName = "Edmonton",
                Population = 500000,
                ProvinceCode = "AB"
            },
            new City {
                CityId = 5,
                CityName = "Ottawa",
                Population = 750000,
                ProvinceCode = "ON"
            },
            new City {
                CityId = 6,
                CityName = "Victoria",
                Population = 500000,
                ProvinceCode = "BC"
            },
            new City {
                CityId = 7,
                CityName = "Whistler",
                Population = 10000,
                ProvinceCode = "BC"
            },
            new City {
                CityId = 8,
                CityName = "Niagara Falls",
                Population = 100000,
                ProvinceCode = "ON"
            },
            new City {
                CityId = 9,
                CityName = "Banff",
                Population = 10000,
                ProvinceCode = "AB"
            },

        };

        return cities;
    }
}
