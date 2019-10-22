//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    

    partial class ginxx
    {

        [MethodImpl(Inline)]
        public static Scalar128<T> ToScalar128<T>(this Vector128<T> src, int index)
            where T : unmanaged            
                => Num128.define(ginx.vextract(src,(byte)index));

        /// <summary>
        /// Loads a scalar vector from a blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Scalar128<T> ToScalar128<T>(this ReadOnlySpan128<T> src, int block = 0)            
            where T : unmanaged            
                => Num128.load(src,block);



    }
}