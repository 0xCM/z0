//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;
    using static Widths;
    using static As;

    using FV = FixedValues;

    public readonly struct FixedStreams
    {
        const SignKind DefaultSign = SignKind.Positive;

        /// <summary>
        /// Creates a stream of fixed values
        /// </summary>
        /// <param name="source">The random source</param>
        /// <typeparam name="F">The fixed type</typeparam>
        public static IEnumerable<F> stream<F>(IValueSource source)
            where F: unmanaged, IFixed
        {
            var w = (FixedWidth)default(F).BitWidth;
            switch(w)
            {
                case FixedWidth.W8: return stream<F>(source, w8);
                case FixedWidth.W16: return stream<F>(source, w16);
                case FixedWidth.W32: return stream<F>(source, w32);
                case FixedWidth.W64: return stream<F>(source, w64);
                case FixedWidth.W128: return stream<F>(source, w128);
                case FixedWidth.W256: return stream<F>(source, w256);
                case FixedWidth.W512: return stream<F>(source, w512);
                default: return Root.seq<F>();                    
            }
        }

        static IEnumerable<T> stream<T>(IValueSource source, W8 w)
            where T :unmanaged, IFixed
        {
            while(true)
                yield return FV.next(source,w).As<T>();
        }

        static IEnumerable<T> stream<T>(IValueSource source, W16 w)
            where T :unmanaged, IFixed
        {
            while(true)
                yield return FV.next(source,w).As<T>();
        }

        static IEnumerable<T> stream<T>(IValueSource source, W32 w)
            where T :unmanaged, IFixed
        {
            while(true)
                yield return FV.next(source,w).As<T>();
        }

        static IEnumerable<T> stream<T>(IValueSource source, W64 w)
            where T :unmanaged, IFixed
        {
            while(true)
                yield return FV.next(source,w).As<T>();
        }

        static IEnumerable<T> stream<T>(IValueSource source, W128 w)
            where T :unmanaged, IFixed
        {
            while(true)
                yield return FV.next(source,w).As<T>();
        }

        [Op]
        static IEnumerable<T> stream<T>(IValueSource source, W256 w)
            where T :unmanaged, IFixed
        {
            while(true)
                yield return FV.next(source,w).As<T>();
        }

        static IEnumerable<T> stream<T>(IValueSource source, W512 w)
            where T :unmanaged, IFixed
        {
            while(true)
                yield return FV.next(source,w).As<T>();
        }

        public static IEnumerable<F> Create<F,W,T>(IPolyrand random, F f = default, T t = default)
            where F : unmanaged, IFixed
            where W : unmanaged, ITypeWidth
            where T : unmanaged
                => new FixedStreamProvider<F,W,T>(random, random.Domain<T>()).Stream;

        public static IEnumerable<F> Create<F,W,T>(IPolyrand random, Interval<T> celldomain)
            where F : unmanaged, IFixed
            where W : unmanaged, ITypeWidth
            where T : unmanaged
                => new FixedStreamProvider<F,W,T>(random, celldomain).Stream;

    }
}