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

    partial struct Blit
    {
        public readonly struct textT<T> : IName<textT<T>,T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public static uint MaxLength(byte psz)
                => size<T>()*psz - 1;

            public T Storage {get;}

            public uint Length {get;}

            public byte PointSize {get;}

            [MethodImpl(Inline)]
            public textT(T data, uint length, byte psz)
            {
                Storage= data;
                Length = length;
                PointSize = psz;
            }

            public Span<byte> Bytes
            {
                [MethodImpl(Inline)]
                get => slice(bytes(Storage),0, MaxLength(PointSize));
            }
        }
    }
}