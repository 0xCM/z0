//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
        
    using static zfunc;

    partial class DataBlocks
    {

        [MethodImpl(Inline)]
        public static Block64<T> load<T>(N64 n, Span<T> src, int offset = 0)
            where T : unmanaged
        {
            if(!aligned<T>(n,src.Length - offset))
                badsize(n, src.Length - offset);      

            return new Block64<T>(offset == 0 ? src : src.Slice(offset));
        }


        [MethodImpl(Inline)]
        public static Block128<T> load<T>(N128 n, Span<T> src, int offset = 0)
            where T : unmanaged
        {
            if(!aligned<T>(n,src.Length - offset))
                badsize(n, src.Length - offset);      

            return new Block128<T>(offset == 0 ? src : src.Slice(offset));
        }


        [MethodImpl(Inline)]
        public static Block256<T> load<T>(N256 n, Span<T> src, int offset = 0)
            where T : unmanaged
        {
            if(!aligned<T>(n,src.Length - offset))
                badsize(n, src.Length - offset);      

            return new Block256<T>(offset == 0 ? src : src.Slice(offset));
        }
    }

}