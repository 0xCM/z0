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
    
    partial class ginx
    {
        /// <summary>
        /// Computes dst[i] := x[i]^(x[i] >> offset) where i = 0,..., blocks - 1
        /// </summary>
        /// <param name="x">The source blocks</param>
        /// <param name="shift">The shift offset</param>
        /// <param name="dst">The blocked computation target</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static void vxorsr<T>(in ConstBlock128<T> x, byte shift, in Block128<T> dst)
            where T : unmanaged
        {
            var count = x.BlockCount;
            for(var block = 0; block < count; block++)
                vstore(ginx.vxorsr(x.LoadVector(block), shift), ref dst.BlockRef(block));
        } 

        /// <summary>
        /// Computes dst[i] := x[i]^(x[i] >> offset) where i = 0,..., blocks - 1
        /// </summary>
        /// <param name="x">The source blocks</param>
        /// <param name="shift">The shift offset</param>
        /// <param name="dst">The blocked computation target</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static void vxorsr<T>(in ConstBlock256<T> x, byte shift, in Block256<T> dst)
            where T : unmanaged
        {
            var count = dst.BlockCount;
            for(var block = 0; block < count; block++)
                vstore(ginx.vxorsr(x.LoadVector(block), shift), ref dst.BlockRef(block));
        } 
    }
}