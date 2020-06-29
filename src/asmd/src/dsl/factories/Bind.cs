//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static Root;
    using static asm;

    readonly struct Bind
    {
        [MethodImpl(Inline)]
        public static Bound<R,S> cmp<R,S>(R dst, S src)
            where R : unmanaged, IOperand
            where S : unmanaged, IOperand
                => bind(dst,src);
    }
}