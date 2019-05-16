﻿using MTD.CouchBot.Domain.Models.Twitch;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MTD.CouchBot.Dals
{
    public interface ITwitchDal
    {
        Task<TwitchStreamV5> GetStreamById(string twitchId);
        Task<string> GetTwitchIdByLogin(string name);
        Task<TwitchStreamsV5> GetStreamsByIdList(string twitchIdList);
        Task<TwitchTeam> GetTwitchTeamByName(string name);
        Task<List<string>> GetDelimitedListOfTwitchMemberIds(string teamToken);
        Task<List<TwitchStreamsV5.Stream>> GetStreamsByGameName(string gameName);
        Task<TwitchGameSearchResponse> SearchForGameByName(string gameName);
        Task<TwitchChannelResponse> GetTwitchChannelById(string twitchId);
        Task<List<TwitchUser.User>> GetTwitchUsersByLoginList(string twitchNameList);
    }
}
