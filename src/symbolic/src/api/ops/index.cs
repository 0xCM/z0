//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    partial class Symbolic
    {
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