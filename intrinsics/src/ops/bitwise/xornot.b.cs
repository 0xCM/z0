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
        /// Computes dst[i] := x[i] ^ ~y[i] where i = 0,..., blocks - 1
        /// </summary>
        /// <param name="x">The left vector source</param>
        /// <param name="y">The right vector source</param>
        /// <param name="dst">The blocked computation target</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static void vxornot<T>(in ConstBlock128<T> x, in ConstBlock128<T> y, in Block128<T> dst)
            where T : unmanaged
        {            
            var count = dst.BlockCount;
            for(var block = 0; block < count; block++)
                vstore(ginx.vxornot(x.LoadVector(block), y.LoadVector(block)), ref dst.BlockRef(block));
        }

        /// <summary>
        /// Computes dst[i] := x[i] ^ ~y[i] where i = 0,..., blocks - 1
        /// </summary>
        /// <param name="x">The left vector source</param>
        /// <param name="y">The right vector source</param>
        /// <param name="dst">The blocked computation target</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static void vxornot<T>(in ConstBlock256<T> x, in ConstBlock256<T> y, in Block256<T> dst)
            where T : unmanaged
        {            
            var count = dst.BlockCount;
            for(var block = 0; block < count; block++)
                vstore(ginx.vxornot(x.LoadVector(block), y.LoadVector(block)), ref dst.BlockRef(block));
        }
    }
}