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

    partial struct Table
    {
        [MethodImpl(Inline)]
        public static FieldIndex<F> index<F>()
            where F : unmanaged, Enum
                => new FieldIndex<F>(0);

        [MethodImpl(Inline)]
        public static ulong index<D,S>(in ClosedInterval<ulong> positions, in D id)
            where D : unmanaged, Enum
            where S : unmanaged
        {
            var position = scalar<D,S>(id);
            var offset = positions.Min;
            var index = position - offset;
            return index;
        }

        [MethodImpl(Inline)]
        public static ulong index<D,S>(in TableSelector<D,S> selector, ulong offset)
            where D : unmanaged, Enum
            where S : unmanaged
                => uint64(selector.Position) - offset;

        [MethodImpl(Inline)]
        static ulong scalar<D,S>(D id)
            where D : unmanaged, Enum
            where S : unmanaged
                => force<S,ulong>(Enums.scalar<D,S>(id));
    }
}