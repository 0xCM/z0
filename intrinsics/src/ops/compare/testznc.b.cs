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
    
    partial class ginx
    {
        [MethodImpl(Inline)]
        public static bit testznc<T>(in ConstBlock128<T> xb, in ConstBlock128<T> yb)
            where T : unmanaged
        {
            var result = bit.On;
            var count = xb.BlockCount;
            for(var block = 0; block < count; block++)
                result &= ginx.vtestznc(xb.LoadVector(block), yb.LoadVector(block));
            return result;
        } 

        [MethodImpl(Inline)]
        public static bit testznc<T>(in ConstBlock256<T> xb, in ConstBlock256<T> yb)
            where T : unmanaged
        {
            var result = bit.On;
            var count = xb.BlockCount;
            for(var block = 0; block < count; block++)
                result &= ginx.vtestznc(xb.LoadVector(block), yb.LoadVector(block));
            return result;
        } 
    }
}