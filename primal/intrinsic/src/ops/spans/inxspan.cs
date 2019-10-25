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
        public static Span256<T> sll<T>(ReadOnlySpan256<T> lhs, byte offset, Span256<T> dst)
            where T : unmanaged
        {
            for(var i=0; i< lhs.BlockCount; i++)
                vstore(ginx.vsll(lhs.LoadVector(i), offset), ref dst.Block(i));                             
            return dst;        
        } 

        public static Span256<T> srl<T>(ReadOnlySpan256<T> lhs, byte offset, Span256<T> dst)
            where T : unmanaged
        {
            for(var i=0; i< lhs.BlockCount; i++)
                vstore(ginx.vsrl(lhs.LoadVector(i), offset), ref dst.Block(i));                             
            return dst;        
        } 

        public static Span256<T> or<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, Span256<T> dst)
            where T : unmanaged
        {
            for(var i=0; i< blocks(lhs,rhs); i++)
                vstore(ginx.vor(lhs.LoadVector(i), rhs.LoadVector(i)), ref dst.Block(i));                             
            return dst;        
        } 

        public static Span256<T> xor<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, Span256<T> dst)
            where T : unmanaged
        {
            for(var i=0; i< blocks(lhs,rhs); i++)
                vstore(ginx.vxor<T>(lhs.LoadVector(i), rhs.LoadVector(i)), ref dst.Block(i));                             
            return dst;        
        } 

        public static Span128<T> sub<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, Span128<T> dst)
            where T : unmanaged
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                ginx.vstore(ginx.vsub<T>(ginx.vloadu(n128,in lhs.Block(block)), ginx.vloadu(n128,in rhs.Block(block))), ref dst.Block(block));
            return dst;
        }

        public static Span256<T> sub<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, Span256<T> dst)
            where T : unmanaged
        {            
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                ginx.vstore(ginx.vsub<T>(ginx.vloadu(n256,in lhs.Block(block)), ginx.vloadu(n256,in rhs.Block(block))), ref dst.Block(block));
            return dst;
        }

        public static Span128<T> add<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, Span128<T> dst)
            where T : unmanaged
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                ginx.store(ginx.vadd(ginx.vloadu(n128,in lhs.Block(block)), ginx.vloadu(n128,in rhs.Block(block))), ref dst.Block(block));
            return dst;
        }

        public static Span256<T> add<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, Span256<T> dst)
            where T : unmanaged
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                ginx.store(ginx.vadd(ginx.vloadu(n256,in lhs.Block(block)), ginx.vloadu(n256,in rhs.Block(block))), ref dst.Block(block));
            return dst;
        } 


        public static Span128<float> div(ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs, Span128<float> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                vstore(dfp.vdiv(lhs.LoadVector(block), rhs.LoadVector(block)), ref dst[block]);            
            return dst;            
        }

        public static Span128<double> div(ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs, Span128<double> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                vstore(dfp.vdiv(lhs.LoadVector(block), rhs.LoadVector(block)), ref dst[block]);            
            return dst;            
        }

        public static Span256<float> div(ReadOnlySpan256<float> lhs, ReadOnlySpan256<float> rhs, Span256<float> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                vstore(dfp.vdiv(lhs.LoadVector(block), rhs.LoadVector(block)), ref dst[block]);            
            return dst;            
        }

        public static Span256<double> div(ReadOnlySpan256<double> lhs, ReadOnlySpan256<double> rhs, Span256<double> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                vstore(dfp.vdiv(lhs.LoadVector(block), rhs.LoadVector(block)), ref dst[block]);            
            return dst;            
        }     


        public static short Sum(ReadOnlySpan<short> src)
        {
            var veclen = Vec128<short>.Length;
            var seglen = 2*veclen;
            var srclen = src.Length;
            require(0 == srclen % seglen);

            var dst = Vec128.Fill((short)0);
            var offset = 0;
            for(var i=0; i< srclen; i+= seglen)
            {
                var v1 = Vec128.Load(src, offset);
                offset += veclen;
                var v2 = Vec128.Load(src, offset);
                offset += veclen;
                var vSum = dinx.vhadd(v1, v2);
                dst = dinx.vadd(dst,vSum);                
            }
            
            Span<short> final = stackalloc short[veclen];
            vstore(dst, ref final[0]);

            var total = (short)0;
            for(var i=0; i< veclen; i++)
                 total += final[i];            
            return total;
        }

            
        public static int Sum(ReadOnlySpan<int> src)
        {
            var veclen = Vec128<int>.Length;
            var seglen = 2*veclen;
            var srclen = src.Length;
            require(0 == srclen % seglen);

            var dst = Vec128.Fill((int)0);
            var offset = 0;
            for(var i=0; i< srclen; i+= seglen)
            {
                var v1 = Vec128.Load(src, offset);
                offset += veclen;
                var v2 = Vec128.Load(src, offset);
                offset += veclen;
                var vSum = dinx.vhadd(v1, v2);
                dst = dinx.vadd(dst,vSum);                
            }
            
            Span<int> final = stackalloc int[veclen];
            vstore(dst, ref final[0]);

            var total = (int)0;
            for(var i=0; i< veclen; i++)
                 total += final[i];            
            return total;
        }

        [MethodImpl(Inline)]
        public static int Sum(Span<int> src)
            => Sum(src.ReadOnly());

    }


}