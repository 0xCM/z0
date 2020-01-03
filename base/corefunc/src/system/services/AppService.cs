//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;

    public abstract class AppService : IAppService
    {
        protected AppService(IContext AppContext)
        {
            this.AppContext = AppContext;
        }

        protected IContext AppContext {get;}

        protected virtual void OnConfigure(dynamic config) {}

        public virtual void Dispose() {}

        public virtual async Task Configure(dynamic config)
        {
            await Task.Factory.StartNew(() => {});
        }
    }
}