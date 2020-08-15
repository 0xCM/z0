//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    partial class asm
    {
        [MethodImpl(Inline)]
        public static AsmArgs<A> args<A>(A a)
            where A : unmanaged, IOperand
                => new AsmArgs<A>(a);

        [MethodImpl(Inline)]
        public static AsmArgs<A,B> args<A,B>(A a, B b)
            where A : unmanaged, IOperand
            where B : unmanaged, IOperand        
                => new AsmArgs<A,B>(a,b);

        [MethodImpl(Inline)]
        public static AsmArgs<A,B,C> args<A,B,C>(A a, B b, C c)
            where A : unmanaged, IOperand
            where B : unmanaged, IOperand        
            where C : unmanaged, IOperand        
                => new AsmArgs<A,B,C>(a,b,c);
    }
}