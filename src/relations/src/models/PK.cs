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

    partial struct Relations
    {
        public readonly struct PK
        {
            public uint Value {get;}

            [MethodImpl(Inline)]
            public PK(uint value)
                => Value = value;

            [MethodImpl(Inline)]
            public static implicit operator PK(uint value)
                => new PK(value);
        }

        public readonly struct PK<I>
            where I : unmanaged
        {
            public I Value {get;}

            [MethodImpl(Inline)]
            public PK(I value)
                => Value = value;

            [MethodImpl(Inline)]
            public static implicit operator PK<I>(I value)
                => new PK<I>(value);

            [MethodImpl(Inline)]
            public static implicit operator PK(PK<I> src)
                => bw32(src.Value);
        }

        public readonly struct PK<I,T>
            where T : struct
            where I : unmanaged
        {
            public I Value {get;}

            [MethodImpl(Inline)]
            public PK(I value)
                => Value = value;

            [MethodImpl(Inline)]
            public static implicit operator PK<I,T>(I value)
                => new PK<I,T>(value);

            [MethodImpl(Inline)]
            public static implicit operator PK<I>(PK<I,T> src)
                => new PK<I>(src.Value);

            [MethodImpl(Inline)]
            public static implicit operator PK(PK<I,T> src)
                => bw32(src.Value);
        }
    }
}