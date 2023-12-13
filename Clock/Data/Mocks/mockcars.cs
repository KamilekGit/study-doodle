using Clock.Data.interfaces;
using Clock.Data.Models;

namespace Clock.Data.Mocks
{
    public class mockcars : IAllCars
    {
        private readonly ICarsCategory _CategoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    //ELECTRO
                    new() { Name = "Tesla X", ShortDescription = "Best e-car from USA ", LongDescription = "Model X is built for utility and performance, with standard AWD, best in class storage and the highest towing capacity of any electric SUV. ", image = " https://moscowteslaclub.ru/upload/iblock/431/6hsbxyyooiwuwhlkjybj87uqk941m3l7.jpg", price = 10000, IsFav = true, available = true, Category=_CategoryCars.AllCategories.First() },
                    new() { Name = "BMW I3", ShortDescription = "the first production electric car of the German company BMW ", LongDescription = "Compact city car. Created on the basis of the concept of harmonious development, according to which the choice of materials, production processes, suppliers, components and disposal methods is subject to minimal impact on the environment. ", image = " https://cdn5.vedomosti.ru/crop/image/2015/11/15tz1m/original-1i7q.jpg?height=934&width=1330", price = 60099, IsFav = true, available = false, Category=_CategoryCars.AllCategories.First() },
                    new() { Name = "Taycan 4S", ShortDescription = "Lux-class sport e-car ", LongDescription = "The Porsche Taycan 4S is an electric car that is powered by 2 electric motors. The sports coupe's battery is designed on an 800-volt architecture ", image = " https://www.autostat.ru/application/includes/blocks/big_photo/images/cache/000/073/723/76d475e8-670-0.jpg", price = 59080, IsFav = true, available = true, Category=_CategoryCars.AllCategories.First() },
                    new() { Name = "Kia Niro", ShortDescription = "hybrid compact crossover created by Kia Motors in 2016. ", LongDescription = "It is the brand's first hybrid crossover. The second generation Kia Niro will be unveiled in photos in Seoul on November 25, 2021 at the Seoul Auto Show. ", image = " https://eltrender.se/wp-content/uploads/2022/04/Kia-Niro.jpg", price = 30000, IsFav = true, available = true, Category=_CategoryCars.AllCategories.First() },
                    new() { Name = "Audi E-Tron", ShortDescription = "Audi e-tron GE is an all-electric mid-size crossover produced by Audi AG ", LongDescription = "The first-born of the family was originally presented as a concept car called the Audi e-tron 55 Quattro at the 2015 Frankfurt Motor Show. The company's first production electric car. Available for sale in 2019 ", image = " ", price = 43000, IsFav = true, available = true, Category=_CategoryCars.AllCategories.First() },
                    //CLASSIC
                    new() { Name = "Toyota GR Supra", ShortDescription = " sports car produced by Toyota since 2019. ", LongDescription = "The fifth-generation Supra, the GR Supra was sold under and developed by Toyota Gazoo Racing (TGR) brand in collaboration with BMW. ", image = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/09/Toyota_Supra_Monrepos_2019_IMG_1898.jpg/1920px-Toyota_Supra_Monrepos_2019_IMG_1898.jpg ", price = 25000, IsFav = true, available = true, Category = _CategoryCars.AllCategories.Last() },
                    new() { Name = "Mark ||", ShortDescription = "manufactured and marketed in Japan by Toyota between 1968 and 2004 ", LongDescription = "Every Mark II and Cressida was manufactured at the Motomachi plant at Toyota, Aichi, Japan from September 1968 to October 1993 ", image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSZW3b-whVbZ4CwGc_xQxC_aXbMt7Y6nnp4smfMVY82HUWsigOhML-duC134nzoUDPn5Xs&usqp=CAU ", price = 37500, IsFav = true, available = true, Category=_CategoryCars.AllCategories.Last() },
                    new() { Name = "Nissan r34", ShortDescription = "Legenfary Skyline ", LongDescription = "The 10th generation Nissan Skyline was introduced in May 1998 in R34 body styles with a greater emphasis on sportiness and compliance with new environmental standards. In the base GT model, the RB20E engine was replaced by the RB20DE, last used in the R32 but upgraded (NEO). ", image = " https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTm4c8R6qbQRh3cKVtk0ukyDyN_xj3vvc7T743Lby_VYr-3g5dmhXMpM6GUVSMX8oaU_qY&usqp=CAU", price = 60500, IsFav = true, available = true, Category=_CategoryCars.AllCategories.Last() },
                    new() { Name = "Subaru BRZ", ShortDescription = "The Toyota 86 and the Subaru BRZ are 2+2 sports cars jointly developed by Toyota and Subaru, manufactured at Subaru's Gunma assembly plant.[1] ", LongDescription = "The 2+2 fastback coupé has a naturally-aspirated boxer engine, front-engined, rear-wheel-drive configuration, 53/47 front/rear weight balance and low centre of gravity; it was inspired by Toyota's earlier AE86, a small, light, front-engine/rear-drive Corolla variant widely popular for Showroom Stock, Group A, Group N, Rally, Club and drift racing. ", image = " https://upload.wikimedia.org/wikipedia/commons/thumb/7/7c/Dark_Gray_Subaru_BRZ_side.jpg/800px-Dark_Gray_Subaru_BRZ_side.jpg?20130602225335", price = 10000, IsFav = true, available = true, Category=_CategoryCars.AllCategories.Last() },
                    new() { Name = "Mazda RX-7", ShortDescription = "he Mazda RX-7 is a front-engine, rear-wheel-drive, rotary engine-powered sports car that was manufactured and marketed by Mazda from 1978 until 2002 across three generations, all of which made use of a compact, lightweight Wankel rotary engine. ", LongDescription = "he Mazda RX-7 is a front-engine, rear-wheel-drive, rotary engine-powered sports car that was manufactured and marketed by Mazda from 1978 until 2002 across three generations, all of which made use of a compact, lightweight Wankel rotary engine. ", image = " https://upload.wikimedia.org/wikipedia/commons/thumb/f/f5/1986_Mazda_RX-7_Savanna_%2824367370123%29.jpg/1920px-1986_Mazda_RX-7_Savanna_%2824367370123%29.jpg", price = 52000, IsFav = true, available = true, Category=_CategoryCars.AllCategories.Last() },
                };
            }
        }
        public IEnumerable<Car> GetFavCars { get; set; }

        public Car getobjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
