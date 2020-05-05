using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace vegetableshop.DataAccess.Entities
{
    public class SeedData
    {
        private List<string> firstName = new List<string>
        {
            "Nguyễn","Võ","Vũ","Lê","Triệu","Đinh","Lí","Trần"
        };

        private List<string> middleName = new List<string>
        {
            "Thị","Lan","Minh","Lôi"
        };

        private List<string> lastName = new List<string>
        {
            "Ngọc","Huyền","Mai","Chi","Vy","Anh"
        };

        private List<string> slogans = new List<string>
        {
            " Got Milk?","Good to the last drop! ","It’s everywhere you want to be.","They’re Gr-r-reat!","What happens here, stay here.","Just do it."
        };

        private List<string> streets = new List<string>
        {
           "Tô Hiệu","Phố Huế","Hàng Cháo","Hàng Chiếu","Hàng Bưởi","TDH","Phạm Văn Đồng","Hồ Tùng Mậu"
        };

        private List<string> districts = new List<string>
        {
           "Từ Liêm","Cầu Giấy","Đống Đa","Ba Đình","Hoàng Mai","Thanh Xuân"
        };

        private List<string> passwords = new List<string>
        {
           "Bạn anh Dũng","Bạn anh Huy","Bạn anh Công"
        };

        private List<string> realNames = new List<string>
        {
           "artichoke",
"aubergine", "eggplant",
"asparagus",
"legumes",
"alfalfa sprouts",
"azuki beans",
"bean sprouts",
"black beans",
"black-eyed peas",
"borlotti bean",
"broad beans",
"chickpeas", "garbanzos", "ceci beans",
"green beans",
"kidney beans",
"lentils",
"lima beans or Butter bean",
"mung beans",
"navy beans",
"pinto beans",
"runner beans",
"split peas",
"soy beans",
"peas",
"mangetout or snap peas",
"broccoflower",
"broccoli",
"brussels sprouts",
"cabbage",
"kohlrabi",
"Savoy Cabbage",
"Red Cabbage",
"Pointed", "Sweetheart", "Cabbage",
"cauliflower",
"celery",
"endive",
"fiddleheads",
"frisee",
"fennel",
"greens",
"beet greens",
"bok choy",
"chard",
"collard greens",
"kale",
"mustard",
"spinach",
"herbs" , "spices",
"anise",
"basil",
"caraway",
"coriander",
"chamomile",
"dill",
"fennel",
"lavender",
"lemon Grass",
"marjoram",
"oregano",
"parsley",
"rosemary",
"sage",
"thyme",
"lettuce",
"arugula",
"mushrooms",
"nettles",
"New Zealand spinach",
"okra",
"onions",
"Chives",
"Garlic",
"Leek",
"onion",
"shallot",
"scallion",
"parsley",
"peppers",
"bell pepper",
"chili pepper",
"Jalapeño",
"Habanero",
"Paprika",
"Tabasco pepper",
"Cayenne pepper",
"radicchio",
"rhubarb",
"root vegetables",
"beetroot" ,
"mangel-wurzel",
"carrot",
"celeriac",
"corms",
"eddoe",
"konjac",
"taro",
"water chestnut",
"ginger",
"parsnip",
"rutabaga",
"radish",
"wasabi",
"horseradish",
"white radish",
"daikon",
"tubers",
"jicama",
"jerusalem artichoke",
"potato",
"sunchokes",
"sweet potato",
"yam",
"turnip",
"salsify" ,
"skirret",
"sweetcorn" ,
"topinambur",
"squashes" ,
"acorn squash",
"bitter melon",
"butternut squash",
"banana squash",
"courgette" ,
"cucumber" ,
"delicata",
"gem squash",
"hubbard squash",
"marrow , Squash" ,
"spaghetti squash",
"tat soi",
"tomato",
"watercress",
        };

        private vegetableshopContext context = new vegetableshopContext();

        public void SeedDataVegetable()
        {
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                Vegetables vegetable = new Vegetables
                {
                    Name = GenerateRandomName(),
                    Nickname = GenerateRandomName(),
                    Address = $"Số {random.Next(10, 500)}- Phố {streets[random.Next(streets.Count - 1)]}",
                    Email = GenerateRandomName().Trim() + "@gmail.com",
                    Endworkingtime = random.Next(18, 24).ToString(),
                    Height = random.Next(155, 175).ToString(),
                    Weight = random.Next(45, 52).ToString(),
                    Password = passwords[random.Next(passwords.Count - 1)],
                    Phonenumber = $"0{GenerateNumber()}",
                    Ratting = random.Next(1, 5),
                    Price = $"{random.Next(500, 2000)}$",
                    Slogan = slogans[random.Next(slogans.Count - 1)],
                    Startworkingtime = random.Next(9, 12).ToString(),
                    Skin = random.Next(6, 9),
                    Promotionprice = $"{random.Next(500, 2000)}$",
                    Wokingareas = districts[random.Next(districts.Count - 1)],
                    V1 = random.Next(82, 95).ToString(),
                    V2 = random.Next(58, 63).ToString(),
                    V3 = random.Next(88, 95).ToString(),
                    Insertdate = DateTime.Now,
                    Updatedate = DateTime.Now,
                };
                context.Add(vegetable);
            }
        }

        public void SeedDataVipImages()
        {
            var list = context.Vegetables.ToList();
            var fileArray = Directory.GetFiles("wwwroot/access/images/real/", "*.jpg", SearchOption.AllDirectories).ToList();
            Random random = new Random();
            for (int i = 0; i < 1000; i++)
            {
                Vegetableimages image = new Vegetableimages
                {
                    Path = fileArray[random.Next(fileArray.Count - 1)],
                    RealvegetableId = null,
                    VegetableId = list[random.Next(list.Count - 1)].Id,
                    Type = random.Next(1, 2),
                    Insertdate = DateTime.Now,
                    Updatedate = DateTime.Now
                };
                context.Add(image);
            }
        }

        public void SeedDataRealImages()
        {
            var list = context.Realvegetables.ToList();
            var fileArray = Directory.GetFiles("wwwroot/access/images/real/", "*.jpg", SearchOption.AllDirectories).ToList();
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                Vegetableimages image = new Vegetableimages
                {
                    Path = fileArray[random.Next(fileArray.Count - 1)],
                    RealvegetableId = list[random.Next(list.Count - 1)].Id,
                    Type = random.Next(1, 2),
                    Insertdate = DateTime.Now,
                    Updatedate = DateTime.Now
                };
                context.Add(image);
            }
        }

        public void SeedDataRealVegetable()
        {
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                Realvegetables vegetable = new Realvegetables
                {
                    Name = realNames[random.Next(realNames.Count - 1)],
                    Price = $"{random.Next(2, 20)}$",
                    Promotionprice = $"{random.Next(1, 18)}$",
                    Descriptions = slogans[random.Next(slogans.Count - 1)],
                    Insertdate = DateTime.Now,
                    Updatedate = DateTime.Now,
                };
                context.Add(vegetable);
            }
        }

        private string GenerateRandomName()
        {
            Random random = new Random();
            string name = $"{firstName[random.Next(firstName.Count - 1)]} {middleName[random.Next(middleName.Count - 1)]} {lastName[random.Next(lastName.Count - 1)]}";
            return name;
        }

        public string GenerateNumber()
        {
            Random random = new Random();
            string r = "";
            int i;
            for (i = 1; i < 10; i++)
            {
                r += random.Next(0, 9).ToString();
            }
            return r;
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}