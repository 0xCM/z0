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

    using static As;

    public static class inxspan
    {
        public static Span128<T> sub<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, Span128<T> dst)
            where T : unmanaged
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                ginx.store(ginx.sub(ginx.lddqu128(in lhs.Block(block)), ginx.lddqu128(in rhs.Block(block))), ref dst.Block(block));
            return dst;
        }

        public static Span256<T> sub<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, Span256<T> dst)
            where T : unmanaged
        {            
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                ginx.store(ginx.sub(ginx.lddqu256(in lhs.Block(block)), ginx.lddqu256(in rhs.Block(block))), ref dst.Block(block));
            return dst;
        }

        public static Span128<T> add<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, Span128<T> dst)
            where T : unmanaged
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                ginx.store(ginx.vadd(ginx.lddqu128(in lhs.Block(block)), ginx.lddqu128(in rhs.Block(block))), ref dst.Block(block));
            return dst;
        }

        public static Span256<T> add<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, Span256<T> dst)
            where T : unmanaged
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                ginx.store(ginx.vadd(ginx.lddqu256(in lhs.Block(block)), ginx.lddqu256(in rhs.Block(block))), ref dst.Block(block));
            return dst;
        } 


    }


}