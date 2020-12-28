using AutoMapper;
using CoreCodeCamp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCodeCamp.Data
{
    public class CampProfile : Profile
    {
        public CampProfile()
        {
            //this.CreateMap<Speaker, SpeakerModel>();
            this.CreateMap<Talk, TalkModel>().ReverseMap();
            this.CreateMap<Speaker, SpeakerModel>().ReverseMap();
            this.CreateMap<Camp, CampModel>()
                .ForMember(n => n.LocationVenueName, x => x.MapFrom(r => r.Location.VenueName)).ReverseMap();
        }
    }
}
