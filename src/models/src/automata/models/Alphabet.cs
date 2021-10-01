//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Root;

    public class Alphabet<A>
        where A : unmanaged
    {
        readonly HashSet<Symbol<A>> Data;

        [MethodImpl(Inline)]
        public Alphabet(HashSet<Symbol<A>> src)
        {
            Data = src;
        }

        public IEnumerable<Symbol<A>> Members
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public uint MemberCount
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Count;
        }
    }
}