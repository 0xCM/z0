//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{            
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    partial struct AsmRender
    {
        [MethodImpl(Inline), Op]
        public static AsmTextEmitter emitter()
            => new AsmTextEmitter((dst,formatter) => new AsmWriter(dst,formatter));        
    }
}