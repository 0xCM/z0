//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public interface IEnvContext
    {
        EnvData Env {get;}
    }

    public abstract class EnvService<H> : IEnvContext
        where H : EnvService<H>, new()
    {
        /// <summary>
        /// Instantites the serice without initialization
        /// </summary>
        [MethodImpl(Inline)]
        protected static H @new() => new H();

        public EnvData Env {get; protected set;}

        /// <summary>
        /// Creates and initializes the service
        /// </summary>
        /// <param name="wf">The source workflow</param>
        public static H create(IEnvContext ctx)
        {
            var service = @new();
            service.Init(ctx);
            return service;
        }

        protected EnvPaths Paths {get; private set;}

        public void Init(IEnvContext ctx)
        {
            Env = ctx.Env;
            Paths = new EnvPaths(Env);
            Initialized();
        }

        protected virtual void Initialized() {}

    }
}