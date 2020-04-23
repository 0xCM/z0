//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static Seed; 
    using static Memories;
    using static SBlock;

    partial class Blocked
    {
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block128<T> bsll<T>(in Block128<T> a, [Imm] byte count, in Block128<T> dst)
            where T : unmanaged
                => ref zip(a, count, dst, VSvc.vbsll<T>(n128));

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block256<T> bsll<T>(in Block256<T> a, [Imm] byte count, in Block256<T> dst)
            where T : unmanaged
                => ref zip(a, count, dst, VSvc.vbsll<T>(n256));

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block128<T> bsrl<T>(in Block128<T> a, [Imm] byte count, in Block128<T> dst)
            where T : unmanaged
                => ref zip(a, count, dst, VSvc.vbsrl<T>(n128));

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block256<T> brsl<T>(in Block256<T> a, [Imm] byte count, in Block256<T> dst)
            where T : unmanaged
                => ref zip(a, count, dst, VSvc.vbsrl<T>(n256));

        /// <summary>
        /// Computes z[i] := x[i]^((x[i] >> offset)^(x[i] >> offset)) where i = 0,..., blocks - 1
        /// </summary>
        /// <param name="x">The source blocks</param>
        /// <param name="count">The shift offset</param>
        /// <param name="dst">The blocked computation target</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block128<T> xors<T>(in Block128<T> x, [Imm] byte count, in Block128<T> dst)
            where T : unmanaged
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Vectors.vstore(gvec.vxors(x.LoadVector(block), count), ref dst.BlockRef(block));
            return ref dst;
        } 

        /// <summary>
        /// Computes z[i] := x[i]^((x[i] >> offset)^(x[i] >> offset)) where i = 0,..., blocks - 1
        /// </summary>
        /// <param name="x">The source blocks</param>
        /// <param name="offset">The shift offset</param>
        /// <param name="dst">The blocked computation target</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block256<T> xors<T>(in Block256<T> x, [Imm] byte count, in Block256<T> dst)
            where T : unmanaged
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Vectors.vstore(gvec.vxors(x.LoadVector(block), count), ref dst.BlockRef(block));
            return ref dst;
        } 
    }
}