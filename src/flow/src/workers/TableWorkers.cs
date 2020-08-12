//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Data;
    
    using static Konst;
    using static ProcessFx;
    using static z;


    [ApiHost]
    public readonly struct TableWorkers
    {                
        [MethodImpl(Inline)]
        public static ulong scalar<D,S>(D id)
            where D : unmanaged, Enum
            where S : unmanaged
                => convert<S,ulong>(Enums.scalar<D,S>(id));
        
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ClosedInterval<ulong> positions<S>(S min, S max)
            where S : unmanaged
                => Intervals.closed(uint64(min), uint64(max));

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
        public static ClosedInterval<ulong> indices<D,S>(in ClosedInterval<ulong> positions, S min, S max)
            where D : unmanaged, Enum        
            where S : unmanaged
        {
            var offset = positions.Min;
            var left = uint64(min) - offset;
            var right = uint64(max) - offset;
            return (left,right);
        }

        [MethodImpl(Inline)]        
        public static ulong index<D,S>(in Selector<D,S> selector, ulong offset)
            where D : unmanaged, Enum        
            where S : unmanaged    
                => uint64(selector.Position) - offset;        
    }
}