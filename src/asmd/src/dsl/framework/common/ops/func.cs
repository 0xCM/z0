//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    
    using static Konst;

    partial class asm
    {
        [MethodImpl(Inline), Op]
        public static FunctionBuilder func([Caller] string name = null)
            => new FunctionBuilder(name,32);

        [MethodImpl(Inline), Op]
        public static FunctionBuilder func(asci32[] name, EncodedCommand[] commands, int[] index)
            => new FunctionBuilder(name,commands,index);
    }
}