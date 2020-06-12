//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Intrinsics;

    using Z0.Asm.Data;

    using static Seed;


    readonly struct SubProcess
    {
        public static BinaryCode ToBinaryCode(ReadOnlySpan<byte> src)
        {
            var length = src.Length;
            for(var i= length - 1; i>=0; i--)
            {
                ref readonly var x = ref Control.skip(src,i);
                if(x != 0)
                    return new BinaryCode(src.Slice(0,length).ToArray());
            }
            return BinaryCode.Empty;
        }

    }
}