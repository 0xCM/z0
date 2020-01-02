//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static As;
    using static zfunc;

    partial class ginx
    {
        /// <summary>
        /// Computes x ^ ((x << offset) ^ (x >> offset));
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="offset">The shift offset</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> vxors<T>(Vector128<T> x, byte offset)
            where T : unmanaged
                => vxor(x,vxor(vsll(x, offset),vsrl(x,offset)));

        /// <summary>
        /// Computes x ^ ((x << offset) ^ (x >> offset));
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="offset">The shift offset</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vxors<T>(Vector256<T> x, byte offset)
            where T : unmanaged
                => vxor(x,vxor(vsll(x, offset),vsrl(x,offset)));

        /// <summary>
        /// Computes z[i] := x[i]^((x[i] >> offset)^(x[i] >> offset)) where i = 0,..., blocks - 1
        /// </summary>
        /// <param name="x">The source blocks</param>
        /// <param name="offset">The shift offset</param>
        /// <param name="dst">The blocked computation target</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static void vxors<T>(in ConstBlock128<T> x, byte offset, in Block128<T> dst)
            where T : unmanaged
        {
            var count = dst.BlockCount;
            for(var block = 0; block < count; block++)
                vstore(ginx.vxors(x.LoadVector(block), offset), ref dst.BlockRef(block));
        } 

        /// <summary>
        /// Computes z[i] := x[i]^((x[i] >> offset)^(x[i] >> offset)) where i = 0,..., blocks - 1
        /// </summary>
        /// <param name="x">The source blocks</param>
        /// <param name="offset">The shift offset</param>
        /// <param name="dst">The blocked computation target</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static void vxors<T>(in ConstBlock256<T> x, byte shift, in Block256<T> dst)
            where T : unmanaged
        {
            var count = dst.BlockCount;
            for(var block = 0; block < count; block++)
                vstore(ginx.vxors(x.LoadVector(block), shift), ref dst.BlockRef(block));
        } 
    }
}
