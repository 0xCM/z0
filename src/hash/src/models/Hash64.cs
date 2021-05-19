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

    public readonly struct Hash64 : IHashCode<ulong,ulong>
    {
        public ulong Value {get;}

        [MethodImpl(Inline)]
        public Hash64(ulong value)
            => Value = value;

        public ulong Primitive
        {
            [MethodImpl(Inline)]
            get => Value;
        }

        [MethodImpl(Inline)]
        public static implicit operator Hash64(ulong src)
            => new Hash64(src);
    }
}