//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;

    public abstract class AppService<TContract,TConfig> : AppService, IAppService<TContract,TConfig>
        where TContract : IAppService
    {
        protected AppService(IContext AppContext)
            : base(AppContext)
        {

        }

        public event Action<TConfig> Configured;

        protected abstract Task Configure(TConfig config);

        async Task IAppService<TConfig>.Configure(TConfig config)
        {
            await Configure(config);
            OnConfigured(config);
        }

        void OnConfigured(TConfig config)
        {
            Configured?.BeginInvoke(config, new AsyncCallback(x => {}), this);
        }

        public override sealed async Task Configure(dynamic config)
        {
            await Configure((TConfig)config);
        }
    }
}