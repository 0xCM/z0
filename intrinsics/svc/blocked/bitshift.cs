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
    
    using static zfunc;

    partial class vblocks
    {
        /// <summary>
        /// Computes z[i] := x[i]^((x[i] >> offset)^(x[i] >> offset)) where i = 0,..., blocks - 1
        /// </summary>
        /// <param name="x">The source blocks</param>
        /// <param name="count">The shift offset</param>
        /// <param name="dst">The blocked computation target</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), BlockedOp, NumericClosures(NumericKind.Integers)]
        public static void vxors<T>(in Block128<T> x, [Imm] byte count, in Block128<T> dst)
            where T : unmanaged
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                gvec.vstore(ginx.vxors(x.LoadVector(block), count), ref dst.BlockRef(block));
        } 

        /// <summary>
        /// Computes z[i] := x[i]^((x[i] >> offset)^(x[i] >> offset)) where i = 0,..., blocks - 1
        /// </summary>
        /// <param name="x">The source blocks</param>
        /// <param name="offset">The shift offset</param>
        /// <param name="dst">The blocked computation target</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), BlockedOp, NumericClosures(NumericKind.Integers)]
        public static void vxors<T>(in Block256<T> x, [Imm] byte count, in Block256<T> dst)
            where T : unmanaged
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                vstore(ginx.vxors(x.LoadVector(block), count), ref dst.BlockRef(block));
        } 
    }
}