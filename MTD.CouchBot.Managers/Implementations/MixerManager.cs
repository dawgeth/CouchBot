﻿using MTD.CouchBot.Dals;
using MTD.CouchBot.Domain.Dtos.Mixer;
using System.Threading.Tasks;

namespace MTD.CouchBot.Managers.Implementations
{
    public class MixerManager : IMixerManager
    {
        private readonly IMixerDal _mixerDal;

        public MixerManager(IMixerDal mixerDal)
        {
            _mixerDal = mixerDal;
        }

        public async Task<MixerChannelQueryResponse> GetMixerChannelByChannelName(string channelName)
        {
            return await _mixerDal.GetMixerChannelByChannelName(channelName);
        }
    }
}