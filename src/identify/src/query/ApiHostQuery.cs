//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using static Konst;

    public readonly struct ApiHostQuery : IApiHostQuery
    {
        public static IApiHostQuery<H> Over<H>()
            where H : IApiHost<H>, new()
                => new ApiHostQuery<H>(new H());

        [MethodImpl(Inline)]
        public static IApiHostQuery Create(IApiHost host)
            => new ApiHostQuery(host);
        
        [MethodImpl(Inline)]
        internal ApiHostQuery(IApiHost host)
        {
            Host = host;
        }

        public IApiHost Host {get;}
    }

    public readonly struct ApiHostQuery<H> : IApiHostQuery<H>
        where H : IApiHost<H>, new()
    {
        internal ApiHostQuery(H host)
        {
            this.Host = host;
        }

        public H Host {get;}

        /// <summary>
        /// All hosted methods
        /// </summary>
        public IEnumerable<MethodInfo> Hosted 
            => Host.HostedMethods;    
    }
}