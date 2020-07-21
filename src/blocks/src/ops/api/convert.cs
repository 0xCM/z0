//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
        
    using static Widths;
    using static Konst;        

    partial class Blocks
    {
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
            var dst = Cells.alloc<T>(w256,(ulong)src.CellCount);
            for(var i=0; i< src.CellCount; i++)
                dst[i] = z.convert<S,T>(src[i]);
            return dst;
        }

    }
}