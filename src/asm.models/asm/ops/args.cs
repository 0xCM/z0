//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    using Z0.Asm;

    partial struct asm
    {
        [MethodImpl(Inline)]
        public static AsmArgs<A> args<A>(A a)
            where A : unmanaged, IAsmOperand
                => new AsmArgs<A>(a);

        [MethodImpl(Inline)]
        public static AsmArgs<A,B> args<A,B>(A a, B b)
            where A : unmanaged, IAsmOperand
            where B : unmanaged, IAsmOperand        
                => new AsmArgs<A,B>(a,b);

        [MethodImpl(Inline)]
        public static AsmArgs<A,B,C> args<A,B,C>(A a, B b, C c)
            where A : unmanaged, IAsmOperand
            where B : unmanaged, IAsmOperand        
            where C : unmanaged, IAsmOperand        
                => new AsmArgs<A,B,C>(a,b,c);
    }
}