//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;
    
    using static Konst;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static EncodedFunction func([CallerMemberName] string name = null)
            => new EncodedFunction(name,32);

        [MethodImpl(Inline), Op]
        public static EncodedFunction func(asci32[] name, EncodedCommand[] commands, uint[] index)
            => new EncodedFunction(name, commands, index);
    }
}