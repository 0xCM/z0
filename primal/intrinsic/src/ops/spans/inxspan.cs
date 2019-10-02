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
                vstore(ginx.vsll(lhs.LoadVec256(i), offset), ref dst.Block(i));                             
            return dst;        
        } 

        public static Span256<T> srl<T>(ReadOnlySpan256<T> lhs, byte offset, Span256<T> dst)
            where T : unmanaged
        {
            for(var i=0; i< lhs.BlockCount; i++)
                vstore(ginx.vsrl(lhs.LoadVec256(i), offset), ref dst.Block(i));                             
            return dst;        
        } 

        public static Span256<T> or<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, Span256<T> dst)
            where T : unmanaged
        {
            for(var i=0; i< blocks(lhs,rhs); i++)
                vstore(ginx.vor(lhs.LoadVec256(i), rhs.LoadVec256(i)), ref dst.Block(i));                             
            return dst;        
        } 

        public static Span256<T> xor<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, Span256<T> dst)
            where T : unmanaged
        {
            for(var i=0; i< blocks(lhs,rhs); i++)
                vstore(ginx.vxor<T>(lhs.LoadVec256(i), rhs.LoadVec256(i)), ref dst.Block(i));                             
            return dst;        
        } 

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


        public static Span256<double> sqrt(Span256<double> src, Span256<double> dst)
        {
            for(var block = 0; block <src.BlockCount; block ++)                
            {
                var x =  Vec256.Load(ref src.Block(block));
                vstore(dfp.sqrt(x), ref dst[block]);                
            }
            return dst;
        }

        public static Span256<float> sqrt(Span256<float> src, Span256<float> dst)
        {
            for(var block = 0; block <src.BlockCount; block ++)                
            {
                var x =  Vec256.Load(ref src.Block(block));
                vstore(dfp.sqrt(x), ref dst[block]);                
            }
            return dst;
        }

        public static Span128<float> div(ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs, Span128<float> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                vstore(dfp.vdiv(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst[block]);            
            return dst;            
        }

        public static Span128<double> div(ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs, Span128<double> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                vstore(dfp.vdiv(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst[block]);            
            return dst;            
        }

        public static Span256<float> div(ReadOnlySpan256<float> lhs, ReadOnlySpan256<float> rhs, Span256<float> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                vstore(dfp.vdiv(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst[block]);            
            return dst;            
        }

        public static Span256<double> div(ReadOnlySpan256<double> lhs, ReadOnlySpan256<double> rhs, Span256<double> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                vstore(dfp.vdiv(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst[block]);            
            return dst;            
        }     

    }


}