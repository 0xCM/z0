//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Relations
    {
        public readonly struct PK
        {
            public ulong Value {get;}

            [MethodImpl(Inline)]
            public PK(ulong value)
                => Value = value;

            [MethodImpl(Inline)]
            public static implicit operator PK(ulong value)
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
                => memory.unsigned(src.Value);
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
                => memory.unsigned(src.Value);
        }
    }
}