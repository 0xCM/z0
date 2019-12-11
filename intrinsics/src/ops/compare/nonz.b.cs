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
        public static bit vnonz<T>(in ConstBlock128<T> x)
            where T : unmanaged
        {
            var result = bit.On;
            var count = x.BlockCount;
            for(var block = 0; block < count; block++)
                result &= ginx.vnonz(x.LoadVector(block));
            return result;
        } 

        [MethodImpl(Inline)]
        public static bit vnonz<T>(in ConstBlock256<T> x)
            where T : unmanaged
        {
            var result = bit.On;
            var count = x.BlockCount;
            for(var block = 0; block < count; block++)
                result &= ginx.vnonz(x.LoadVector(block));
            return result;
        } 
    }
}