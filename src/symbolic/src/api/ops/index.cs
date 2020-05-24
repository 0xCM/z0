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
    
    using static Seed;

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

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static HexIndex<T> index<T>(params HexKindValue<T>[] src)
            where T : unmanaged
        {
            var buffer = new T[256];
            Span<T> index = buffer;
            ReadOnlySpan<HexKindValue<T>> view = src;

            for(var i=0; i<src.Length; i++)
            {
                ref readonly var x = ref Control.skip(view,i);
                Control.seek(index,(int)x.Kind) = x.Value;
            }
            return new HexIndex<T>(buffer);
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static HexIndex<T> index<T>(Func<T,HexKind> f, params T[] src)
            where T : unmanaged
        {
            var buffer = new T[256];
            Span<T> index = buffer;
            ReadOnlySpan<T> view = src;
            for(var i=0; i<src.Length; i++)
            {
                var x = Control.skip(view,i);
                Control.seek(index,(int)f(x)) = x;
            }
            return new HexIndex<T>(buffer);
        }                
    }
}