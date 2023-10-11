using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.AutoMapper
{
    class MapperConfig {
        public static Mapper InitializeAutomapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                //cfg.CreateMap<Employee, EmployeeDTO>()
                //   .ForMember(dest => dest.FullName, act => act.MapFrom(src => src.Name))
                //   .ForMember(dest => dest.Rank, act => act.MapFrom(src => src.Department))
                //   .ForMember(dest => dest.Dept, act => act.MapFrom(src => src.Department));

                //cfg.CreateMap<Employee, EmployeeDTO>()
                //    .ForMember(dest => dest.City, act => act.MapFrom(src => src.Address.City))
                //    .ForMember(dest => dest.State, act => act.MapFrom(src => src.Address.State))
                //    .ForMember(dest => dest.Country, act => act.MapFrom(src => src.Address.Country));

                cfg.CreateMap<Employee, EmployeeDTO>()
                   .ForMember(dest => dest.Address, act => act.MapFrom(src => new Address() { 
                       City = src.City,
                       State = src.State,
                       Country = src.Country
                   }));

            })
            {

            };
            var mapper = new Mapper(config);
            return mapper;
        }
       
    }

    class Address
    {
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
    class Employee { 
      public string Name { get; set; }
      public int Salary { get; set; }
      public string Department { get; set; }

      public string City { get; set; }
      public string State { get; set; }
      public string Country { get; set; }

    }

    class EmployeeDTO
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Department { get; set; }
        public Address Address { get; set; }
        

        public override string? ToString()
        {
            return $"{this.Name} {this.Salary} {this.Department} {this.Address.City} {this.Address.State} {this.Address.Country}";
        }


        //public override string ToString()
        //{
        //    return $"{this.Name} {this.Salary} {this.Department} {this.City} {this.State} {this.Country}";
        //}
    }



    internal class AutoMapper
    {
        static void Main() {

            //Address add = new Address()
            //{
            //    City = "Canberra",
            //    State = "State",
            //    Country = "Australia"
            //};
            Employee emp = new Employee
            {
                Name = "John",
                Salary = 2000000,
                Department = "Sales",
                City = "Canberra",
                State = "State",
                Country = "Australia"
            };


            var mapper = MapperConfig.InitializeAutomapper();
            var empDTO = mapper.Map<EmployeeDTO>(emp);
            //var empDTO = mapper.Map<Employee, EmployeeDTO>(emp);

            //Console.WriteLine(empDTO.Name+" "+empDTO.Salary+" "+empDTO.Department+" "
            //    +empDTO.City+" "+empDTO.State+" "+empDTO.Country);

            Console.WriteLine(empDTO.ToString());

        }
    }
}
