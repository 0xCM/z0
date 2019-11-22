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

    using static ginx;

    public static class inxspan
    {
        [MethodImpl(Inline)]
        public static Block256<T> sll<T>(in ConstBlock256<T> xblock, byte offset, in Block256<T> zblock)
            where T : unmanaged
        {
            var count = zblock.BlockCount;
            for(var i=0; i< count; i++)
                vstore(vsll(xblock.LoadVector(i), offset), ref zblock.BlockHead(i));                             
            return zblock;        
        } 

        [MethodImpl(Inline)]
        public static Block256<T> srl<T>(in ConstBlock256<T> xblock, byte offset, in Block256<T> zblock)
            where T : unmanaged
        {
            var count = zblock.BlockCount;
            for(var i=0; i< count; i++)
                vstore(vsrl(xblock.LoadVector(i), offset), ref zblock.BlockHead(i));                             
            return zblock;        
        } 

        [MethodImpl(Inline)]
        public static Block256<T> or<T>(in ConstBlock256<T> xblock, in ConstBlock256<T> yblock, in Block256<T> zblock)
            where T : unmanaged
        {
            var count = zblock.BlockCount;
            for(var block=0; block< count; block++)
                vstore(vor(xblock.LoadVector(block), yblock.LoadVector(block)), ref zblock.BlockHead(block));                             
            return zblock;        
        } 


        [MethodImpl(Inline)]
        public static Block256<T> sub<T>(in ConstBlock256<T> xblock, in ConstBlock256<T> yblock, in Block256<T> zblock)
            where T : unmanaged
        {            
            var count = zblock.BlockCount;
            for(var block = 0; block < count; block++)
                vstore(vsub(xblock.LoadVector(block), yblock.LoadVector(block)), ref zblock.BlockHead(block));
            return zblock;
        }

        [MethodImpl(Inline)]
        public static Block256<T> add<T>(in ConstBlock256<T> xblock, in ConstBlock256<T> yblock, in Block256<T> dst)
            where T : unmanaged
        {
            var count = dst.BlockCount;
            for(var block = 0; block < count; block++)
                vstore(ginx.vadd(xblock.LoadVector(block), yblock.LoadVector(block)), ref dst.BlockHead(block));
            return dst;
        } 
   }
}