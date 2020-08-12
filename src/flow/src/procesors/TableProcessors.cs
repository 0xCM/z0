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
    using static z;


    [ApiHost]
    public readonly struct TableProcessors
    {
        [MethodImpl(Inline)]
        public static Selector<D,S> selector<D,S>(D id, S s = default)
            where D : unmanaged, Enum        
            where S : unmanaged
                => new Selector<D,S>(id);

        [MethodImpl(Inline)]
        public static Selectors<D,S> selectors<D,S>(Selector<D,S>[] src, S min, S max)
            where D : unmanaged, Enum        
            where S : unmanaged
                => new Selectors<D,S>(src,min,max);

        [MethodImpl(Inline)]
        public static TableProcessor<D,S,T,Y> processor<T,D,S,Y>(Selector<D,S> id, T t = default, Y y = default)
            where D : unmanaged, Enum
            where T : struct, ITable
            where S : unmanaged
                => new TableProcessor<D,S,T,Y>(id);
        
        [MethodImpl(Inline)]
        public static DispatcherProxy<F,T,D,S,Y> dispatcher<F,T,D,S,Y>(IWfContext wf, T[] src, TableProcessors<D,S,T,Y> processors, Selectors<D,S> selectors, Y[] dst)
            where F : unmanaged, Enum
            where T : struct, ITable<F,T,D>
            where D : unmanaged, Enum
            where S : unmanaged        
                => new DispatcherProxy<F,T,D,S,Y>(wf, src, processors, selectors, dst);
        
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