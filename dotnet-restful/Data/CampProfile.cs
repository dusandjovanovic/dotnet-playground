using AutoMapper;
using dotnet_restful.Data.Entities;
using dotnet_restful.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_restful.Data
{
    public class CampProfile : Profile
    {
        public CampProfile()
        {
            this.CreateMap<Talk, TalkModel>();
            this.CreateMap<Speaker, SpeakerModel>();
            this.CreateMap<Camp, CampModel>()
                .ForMember(c => c.Venue, 
                    o => o.MapFrom(m => m.Location.VenueName)
                );
        }
    }
}
