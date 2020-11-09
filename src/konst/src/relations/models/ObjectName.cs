//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct ObjectName
    {
        readonly string Interned;

        [MethodImpl(Inline)]
        public ObjectName(string src)
            => Interned = src;

        public ReadOnlySpan<char> Data
        {
            [MethodImpl(Inline)]
            get => Interned;
        }

        [MethodImpl(Inline)]
        public static implicit operator ObjectName(string src)
            => new ObjectName(src);

        public ulong Surrogate
        {
            [MethodImpl(Inline)]
            get => address(Interned);
        }
    }
}
