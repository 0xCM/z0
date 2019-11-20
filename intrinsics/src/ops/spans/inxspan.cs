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
        public static Span256<T> sll<T>(ConstBlock256<T> lhs, byte offset, Span256<T> dst)
            where T : unmanaged
        {
            for(var i=0; i< lhs.BlockCount; i++)
                ginx.vstore(ginx.vsll(lhs.LoadVector(i), offset), ref dst.BlockHead(i));                             
            return dst;        
        } 

        public static Span256<T> srl<T>(ConstBlock256<T> lhs, byte offset, Span256<T> dst)
            where T : unmanaged
        {
            for(var i=0; i< lhs.BlockCount; i++)
                ginx.vstore(ginx.vsrl(lhs.LoadVector(i), offset), ref dst.BlockHead(i));                             
            return dst;        
        } 

        public static Span256<T> or<T>(ConstBlock256<T> lhs, ConstBlock256<T> rhs, Span256<T> dst)
            where T : unmanaged
        {
            for(var i=0; i< blocks(lhs,rhs); i++)
                ginx.vstore(ginx.vor(lhs.LoadVector(i), rhs.LoadVector(i)), ref dst.BlockHead(i));                             
            return dst;        
        } 

        public static Span256<T> xor<T>(ConstBlock256<T> lhs, ConstBlock256<T> rhs, Span256<T> dst)
            where T : unmanaged
        {
            for(var i=0; i< blocks(lhs,rhs); i++)
                ginx.vstore(ginx.vxor<T>(lhs.LoadVector(i), rhs.LoadVector(i)), ref dst.BlockHead(i));                             
            return dst;        
        } 

        public static Span256<T> sub<T>(ConstBlock256<T> lhs, ConstBlock256<T> rhs, Span256<T> dst)
            where T : unmanaged
        {            
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                ginx.vstore(ginx.vsub<T>(ginx.vload(n256,in lhs.Block(block)), ginx.vload(n256,in rhs.Block(block))), ref dst.BlockHead(block));
            return dst;
        }

        public static Span256<T> add<T>(ConstBlock256<T> lhs, ConstBlock256<T> rhs, Span256<T> dst)
            where T : unmanaged
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                ginx.vstore(ginx.vadd(ginx.vload(n256,in lhs.Block(block)), ginx.vload(n256,in rhs.Block(block))), ref dst.BlockHead(block));
            return dst;
        } 

   }
}