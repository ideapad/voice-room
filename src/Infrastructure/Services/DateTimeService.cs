using voice_room.Application.Common.Interfaces;
using System;

namespace voice_room.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
