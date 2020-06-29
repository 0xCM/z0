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

    partial class asm
    {
        [MethodImpl(Inline)]
        public static Bound<A> bind<A>(A a)
            where A : unmanaged, IOperand
                => new Bound<A>(a);

        [MethodImpl(Inline)]
        public static Bound<A,B> bind<A,B>(A a, B b)
            where A : unmanaged, IOperand
            where B : unmanaged, IOperand        
                => new Bound<A,B>(a,b);

        [MethodImpl(Inline)]
        public static Bound<A,B,C> bind<A,B,C>(A a, B b, C c)
            where A : unmanaged, IOperand
            where B : unmanaged, IOperand        
            where C : unmanaged, IOperand        
                => new Bound<A,B,C>(a,b,c);
    }
}