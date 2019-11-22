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
    
    partial class vblock
    {     

       [MethodImpl(Inline)]
        public static void unpacklo<T>(in ConstBlock128<T> xb, in ConstBlock128<T> yb, in Block128<T> zb)
            where T : unmanaged
        {
            var count = zb.BlockCount;
            for(var block = 0; block < count; block++)
                vstore(ginx.vunpacklo(xb.LoadVector(block), yb.LoadVector(block)), ref zb.SeekBlock(block));
        } 

        [MethodImpl(Inline)]
        public static void unpacklo<T>(in ConstBlock256<T> xb, in ConstBlock256<T> yb, in Block256<T> zb)
            where T : unmanaged
        {
            var count = zb.BlockCount;
            for(var block = 0; block < count; block++)
                vstore(ginx.vunpacklo(xb.LoadVector(block), yb.LoadVector(block)), ref zb.SeekBlock(block));
        } 

        [MethodImpl(Inline)]
        public static void unpackhi<T>(in ConstBlock128<T> xb, in ConstBlock128<T> yb, in Block128<T> zb)
            where T : unmanaged
        {
            var count = zb.BlockCount;
            for(var block = 0; block < count; block++)
                vstore(ginx.vunpackhi(xb.LoadVector(block), yb.LoadVector(block)), ref zb.SeekBlock(block));
        } 

        [MethodImpl(Inline)]
        public static void unpackhi<T>(in ConstBlock256<T> xb, in ConstBlock256<T> yb, in Block256<T> zb)
            where T : unmanaged
        {
            var count = zb.BlockCount;
            for(var block = 0; block < count; block++)
                vstore(ginx.vunpackhi(xb.LoadVector(block), yb.LoadVector(block)), ref zb.SeekBlock(block));
        } 


    }

}