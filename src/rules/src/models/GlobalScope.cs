//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct GlobalScope
    {
        static long IdentityStore;

        public uint Id {get;}

        [MethodImpl(Inline)]
        GlobalScope(uint id)
        {
            Id = id;
        }

        [MethodImpl(Inline)]
        public static GlobalScope create()
            => new GlobalScope((uint)inc(ref IdentityStore));
    }
}