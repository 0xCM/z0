//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
        
    using static Root;
    using static Nats;

    partial class blocks
    {
        /// <summary>
        /// If possible, applies the conversion S -> T for each cell in the source block
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]   
        public static Block128<T> convert<S,T>(Block128<S> src)
            where T : unmanaged
            where S : unmanaged
        {
            var dst = cellalloc<T>(n128,src.CellCount);
            for(var i=0; i< src.CellCount; i++)
                dst[i] = Cast.to<S,T>(src[i]);
            return dst;
        }

        /// <summary>
        /// If possible, applies the conversion S -> T for each cell in the source block
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]   
        public static Block256<T> convert<S,T>(Block256<S> src)
            where T : unmanaged
            where S : unmanaged
        {
            var dst = cellalloc<T>(n256,src.CellCount);
            for(var i=0; i< src.CellCount; i++)
                dst[i] = Cast.to<S,T>(src[i]);
            return dst;
        }

        /// <summary>
        /// If possible, applies the conversion S -> T for each cell in the source block
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]   
        public static Block512<T> convert<S,T>(Block512<S> src)
            where T : unmanaged
            where S : unmanaged
        {
            var dst = cellalloc<T>(n512,src.CellCount);
            for(var i=0; i< src.CellCount; i++)
                dst[i] = Cast.to<S,T>(src[i]);
            return dst;
        }
    }
}