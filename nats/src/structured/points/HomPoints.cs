//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly ref struct HomPoints<N,T>
        where T : unmanaged
        where N : unmanaged, ITypeNat
    {
        readonly Span<HomPoint<N,T>> Data;

        [MethodImpl(Inline)]
        public static implicit operator HomPoints<N,T>(Span<HomPoint<N,T>> src)
            => new HomPoints<N,T>(src);

        [MethodImpl(Inline)]
        public static implicit operator HomPoints<N,T>(HomPoint<N,T>[] src)
            => new HomPoints<N,T>(src);

        [MethodImpl(Inline)]
        public HomPoints(Span<HomPoint<N,T>> data)
        {
            this.Data = data;
        }

        [MethodImpl(Inline)]
        public ref HomPoint<N,T> Point(int index)
            => ref seek(Data, index);

        public ref HomPoint<N,T> this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Point(index);
        }        

        public int Count
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }
    }
}