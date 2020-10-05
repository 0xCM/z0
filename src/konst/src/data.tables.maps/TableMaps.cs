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

    public readonly struct TableMaps
    {
        [MethodImpl(Inline)]
        public static TableRunner<F,T,D,S,Y> runner<F,T,D,S,Y>(IWfShell wf, TableProcessors<D,S,T,Y> processors, KeyMapIndex<D,S> selectors)
            where F : unmanaged, Enum
            where T : struct, ITable<F,T,D>
            where D : unmanaged, Enum
            where S : unmanaged
                => new TableRunner<F,T,D,S,Y>(wf, processors, selectors);

        [MethodImpl(Inline)]
        public static ClosedInterval<ulong> indices<D,S>(in ClosedInterval<ulong> positions, S min, S max)
            where D : unmanaged
            where S : unmanaged
        {
            var offset = positions.Min;
            var left = uint64(min) - offset;
            var right = uint64(max) - offset;
            return (left,right);
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ClosedInterval<ulong> positions<S>(S min, S max)
            where S : unmanaged
                => Intervals.closed(uint64(min), uint64(max));

        [MethodImpl(Inline)]
        public static FieldIndex<F> index<F>()
            where F : unmanaged, Enum
                => new FieldIndex<F>(0);

        [MethodImpl(Inline)]
        public static ulong index<D,S>(in ClosedInterval<ulong> positions, in D id)
            where D : unmanaged
            where S : unmanaged
        {
            var position = scalar<D,S>(id);
            var offset = positions.Min;
            var index = position - offset;
            return index;
        }

        [MethodImpl(Inline)]
        public static ulong index<D,S>(in KeyMap<D,S> selector, ulong offset)
            where D : unmanaged
            where S : unmanaged
                => uint64(selector.Index) - offset;

        [MethodImpl(Inline)]
        static ulong scalar<D,S>(D id)
            where D : unmanaged
            where S : unmanaged
                => force<S,ulong>(z.@as<D,S>(id));

        /// <summary>
        /// Correlates an identifying key and a sequence/index postion
        /// </summary>
        /// <param name="key">The identifying key</param>
        /// <param name="index">The correlated position</param>
        /// <typeparam name="K">The key type</typeparam>
        /// <typeparam name="I">The index type</typeparam>
        [MethodImpl(Inline)]
        public static KeyMap<K,I> map<K,I>(K key, I index)
            where K : unmanaged
            where I : unmanaged
                => new KeyMap<K,I>(key,index);

        [MethodImpl(Inline)]
        public static TableMap<T,Y> map<T,Y>(Func<T,Y> f)
            where T : struct, ITable
                => new TableMap<T,Y>(f);

        [MethodImpl(Inline)]
        public static TableMap<D,S,T,Y> map<T,D,S,Y>(Func<T,Y> f, KeyMap<D,S> id, T t = default, Y y = default)
            where D : unmanaged, Enum
            where T : struct, ITable
            where S : unmanaged
                => new TableMap<D,S,T,Y>(f,id);
    }

}