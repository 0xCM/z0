//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public class Alphabet<K>
        where K : unmanaged
    {
        readonly Index<Symbol<K>> Data;

        internal Alphabet(Symbol<K>[] src)
        {
            Data = src;
        }

        public ReadOnlySpan<Symbol<K>> Members
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