//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    
    using static Konst;
    using static Control;

    partial class Symbolic
    {
        /// <summary>
        /// Creates value-to-symbol index
        /// </summary>
        /// <typeparam name="E">The enumeration type that defines the symbols</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        public static IDictionary<T,char> index<E,T>()
            where E : unmanaged, Enum
            where T : unmanaged
        {            
            var values = Enums.dictionary<E,T>();
            var index = new Dictionary<T,char>();
            foreach(var kvp in values)
                index[kvp.Key] = kvp.Value.ToString().Last();
            return index;
        }

        /// <summary>
        /// Creates an index that correlates 8-bit unsigned integers [0..255] with aribitrary parametric values
        /// </summary>
        /// <param name="src">The values to correlate</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline)]
        public static HexIndex<T> index<T>(params HexKindValue<T>[] src)
            where T : unmanaged
                => index(src, new T[256]);

        /// <summary>
        /// Creates an index that correlates up to 255 unsigned 8-bit integers with aribitrary parametric values
        /// </summary>
        /// <param name="src">The values to correlate</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static HexIndex<T> index<T>(HexKindValue<T>[] src, T[] dst)
            where T : unmanaged
        {
            Span<T> index = dst;
            ReadOnlySpan<HexKindValue<T>> view = src;
            var count = Math.Min(src.Length, dst.Length);

            for(var i=0; i<count; i++)
            {
                ref readonly var x = ref skip(view,i);
                seek(index, (int)x.Kind) = skip(view,i).Value;
            }
            return new HexIndex<T>(dst);
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static HexIndex<T> index<T>(Func<T,HexKind> f, T[] src, T[] dst)
            where T : unmanaged
        {
            Span<T> index = dst;
            ReadOnlySpan<T> view = src;
            var count = Math.Min(src.Length, dst.Length);

            for(var i=0; i<count; i++)
            {
                ref readonly var x = ref skip(view,i);
                seek(index, (int)f(x)) = x;
            }
            
            return new HexIndex<T>(dst);
        }                

        [MethodImpl(Inline)]
        public static HexIndex<T> index<T>(Func<T,HexKind> f, params T[] src)
            where T : unmanaged
                => index(f, src, new T[src.Length]);
    }
}