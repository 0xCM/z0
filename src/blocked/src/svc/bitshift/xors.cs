
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

    partial class BSvcHosts
    {
        [Closures(Integers), Xors]
        public readonly struct Xors128<T> : IBlockedUnaryImm8Op128<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public ref readonly Block128<T> Invoke(in Block128<T> a, [Imm] byte count, in Block128<T> dst)            
            {
                var blocks = dst.BlockCount;
                for(var block = 0; block < blocks; block++)
                    Vectors.vstore(gvec.vxors(a.LoadVector(block), count), ref dst.BlockRef(block));
                return ref dst;
            } 
        }

        [Closures(Integers), Xors]
        public readonly struct Xors256<T> : IBlockedUnaryImm8Op256<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public ref readonly Block256<T> Invoke(in Block256<T> a, [Imm] byte count, in Block256<T> dst)            
            {
                var blocks = dst.BlockCount;
                for(var block = 0; block < blocks; block++)
                    Vectors.vstore(gvec.vxors(a.LoadVector(block), count), ref dst.BlockRef(block));
                return ref dst;
            } 
        }    
    }
}