using AutoMapper;
using DatabaseTest.Entity;
using DatabaseTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTest.MappingProfiles
{
    public class AccomodationMappingProfile : Profile
    {
        public AccomodationMappingProfile()
        {
            CreateMap<Accommodation, AccommodationDto>()
                .ForMember(p => p.Country, c => c.MapFrom(a => a.Address.Country))
                .ForMember(p => p.City, c => c.MapFrom(a => a.Address.City))
                .ForMember(p => p.Street, c => c.MapFrom(a => a.Address.Street))
                .ForMember(p => p.PostalCode, c => c.MapFrom(a => a.Address.PostalCode))
                .ForMember(p => p.Latitude, c => c.MapFrom(a => a.Address.Latitude))
                .ForMember(p => p.Longitude, c => c.MapFrom(a => a.Address.Longitude))
                .ForMember(p => p.PhotoGallery, c => c.MapFrom(x => x.Photos.Select(y => y.Photo).ToList()))
                .ForMember(p => p.Reviews, c => c.MapFrom(x => x.Reviews.Select(y => y.Review).ToList()));


            CreateMap<CreateAccommodationDto, Accommodation>()
                .ForMember(r => r.Address,
                    c => c.MapFrom(dto => new Address()
                    {
                        Country = dto.Country,
                        City = dto.City,
                        PostalCode = dto.PostalCode,
                        Street = dto.Street,
                        Latitude = dto.Latitude,
                        Longitude = dto.Longitude,
                    }));

        }
    }
}
