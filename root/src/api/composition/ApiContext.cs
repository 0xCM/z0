//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;

    /// <summary>
    /// Defines a stateless composed context
    /// </summary>
    public readonly struct ApiContext : IApiContext
    {
        [MethodImpl(Inline)]
        internal ApiContext(int id, IApiComposition composition)
        {
            this.Identity = id;
            this.Compostion = composition;
        }

        /// <summary>
        /// Uniquely identifies the context within an application domain
        /// </summary>
        public readonly int Identity;

        /// <summary>
        /// The assigned composition
        /// </summary>
        public IApiComposition Compostion {get;}
    }

    /// <summary>
    /// Defines a stateful composed context
    /// </summary>
    public readonly struct ApiContext<S> : IApiContext<ApiContext<S>,S>
    {
        [MethodImpl(Inline)]
        internal ApiContext(int id, S state, IApiComposition composition)
        {
            this.Identity = id;
            this.State = state;
            this.Compostion = composition;
        }

        /// <summary>
        /// Uniquely identifies the context within an application domain
        /// </summary>
        public readonly int Identity;

        /// <summary>
        /// The context state
        /// </summary>
        public readonly S State;

        S IContext<S>.State 
            => State;

        /// <summary>
        /// The assigned composition
        /// </summary>
        public IApiComposition Compostion {get;}
    }
}