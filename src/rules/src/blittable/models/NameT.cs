//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Blit
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct Name<T> : IName<Name<T>,T>
        where T : unmanaged
    {
        public T Storage {get;}

        public uint Length {get;}

        public byte PointSize {get;}

        [MethodImpl(Inline)]
        public Name(T data, uint length, byte psz)
        {
            Storage= data;
            Length = length;
            PointSize = psz;
        }
    }
}