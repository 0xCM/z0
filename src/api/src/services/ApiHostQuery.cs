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

    using static Seed;

    public static class ApiHostQuery
    {
        public static ApiHostQuery<H> Over<H>(H host = default)
            where H : IApiHost<H>, new()
                => new ApiHostQuery<H>(host);

    }

    public readonly struct ApiHostQuery<H> : IService
        where H : IApiHost<H>, new()
    {
        internal ApiHostQuery(H host)
        {
            this.Host = host;
        }

        public H Host {get;}


        public IEnumerable<MethodInfo> Vectorized(W128 w, bool generic = false)
            => generic 
            ? Host.HostedMethods.VectorizedGeneric(w) 
            : Host.HostedMethods.VectorizedDirect(w);

        public IEnumerable<MethodInfo> VLeftShifts(W128 w, bool generic = false)
            => Host.HostedKind(BitShiftKind.Sll).VectorizedDirect(w);

        public IEnumerable<MethodInfo> VLeftShifts(W256 w)
            => Host.HostedKind(BitShiftKind.Sll).VectorizedDirect(w);

        public IEnumerable<MethodInfo> VRightShifts(W128 w)
            => Host.HostedKind(BitShiftKind.Srl).VectorizedDirect(w);

        public IEnumerable<MethodInfo> VRightShifts(W256 w)
            => Host.HostedKind(BitShiftKind.Srl).VectorizedDirect(w);

    }

}