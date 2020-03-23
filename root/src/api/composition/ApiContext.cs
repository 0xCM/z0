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
}