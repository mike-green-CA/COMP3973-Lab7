using System.Collections.Generic;
using COMP3973_lab4_A01045801_Michael_Green.Data;
using COMP3973_lab4_A01045801_Michael_Green.Models;

namespace COMP3973_lab4_A01045801_Michael_Green.Data {

    public class SampleData{

        //Method for dummy provinces
        public static List<Province> GetProvinces(){
            List<Province> provinces = new List<Province>(){
                new Province() {
                    ProvinceCode    = "BC",
                    ProvinceName    = "British Columbia" 
                },
                new Province(){
                    ProvinceCode = "AB",
                    ProvinceName = "Alberta"
                },
                new Province(){
                    ProvinceCode = "SK",
                    ProvinceName = "Saskatchewan"
                },
            };

            return provinces;
        }

        // Method for dummy cities
        public static List<City> GetCities(){
            
            List<City> cities = new List<City>(){
                new City{
                    CityID = 1,
                    CityName = "Vancouver",
                    Population = 500000,
                    ProvinceCode = "BC"
                },
                new City{
                    CityID = 2,
                    CityName = "Victoria",
                    Population = 300000,
                    ProvinceCode = "BC"
                },
                new City{
                    CityID = 3,
                    CityName = "Port Coquitlam",
                    Population = 80000,
                    ProvinceCode = "BC"
                },
                new City{
                    CityID = 4,
                    CityName = "Calgary",
                    Population = 700000,
                    ProvinceCode = "AB"
                },
                new City{
                    CityID = 5,
                    CityName = "Edmonton",
                    Population = 800000,
                    ProvinceCode = "AB"
                },
                new City{
                    CityID = 6,
                    CityName = "Banff",
                    Population = 50000,
                    ProvinceCode = "AB"
                },
                new City{
                    CityID = 7,
                    CityName = "Moose Jaw",
                    Population = 50000,
                    ProvinceCode = "SK"
                },
                new City{
                    CityID = 8,
                    CityName = "Regina",
                    Population = 400000,
                    ProvinceCode = "SK"
                },
                new City{
                    CityID = 9,
                    CityName = "Saskatoon",
                    Population = 350000,
                    ProvinceCode = "SK"
                },
                
            }; 
            
            return cities;
        }
        
    }
}