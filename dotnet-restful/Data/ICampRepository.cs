﻿using dotnet_restful.Data.Entities;
using System;
using System.Threading.Tasks;

namespace dotnet_restful.Data
{
    public interface ICampRepository
    {
        void Add<T>(T entity) where T : class;

        void Delete<T>(T entity) where T : class;

        Task<bool> SaveChangesAsync();

        Task<Camp[]> GetAllCampsAsync(bool includeTalks = false);

        Task<Camp> GetCampAsync(string moniker, bool includeTalks = false);

        Task<Camp[]> GetAllCampsByEventDate(DateTime dateTime, bool includeTalks = false);

        Task<Talk> GetTalkByMonikerAsync(string moniker, int talkId, bool includeSpeakers = false);

        Task<Talk[]> GetTalksByMonikerAsync(string moniker, bool includeSpeakers = false);

        Task<Speaker[]> GetSpeakersByMonikerAsync(string moniker);

        Task<Speaker> GetSpeakerAsync(int speakerId);

        Task<Speaker[]> GetAllSpeakersAsync();
    }
}
