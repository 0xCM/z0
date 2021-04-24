//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [WfService]
    public abstract class AppSingleton<H,S> : IAppService<H>
        where H : AppSingleton<H,S>, new()
    {
        static H Service;

        protected static S State;

        protected static IWfRuntime Wf;

        IWfRuntime IAppService.Wf
            => Wf;

        [MethodImpl(Inline)]
        public static H create() => new H();

        protected abstract H Init(out S state);

        /// <summary>
        /// Creates and initializes the service
        /// </summary>
        /// <param name="wf">The source workflow</param>
        public static H init(IWfRuntime wf)
        {
            if(Wf == null)
            {
                Wf = wf;
                Service = create();
                Service.Init(out State);
            }
            return Service;
        }

        public void Init(IWfRuntime wf)
        {
            init(wf);
        }
    }
}