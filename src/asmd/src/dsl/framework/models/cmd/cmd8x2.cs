//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct cmd8x2
    {           
        public arg8 A {get;}

        public arg8 B {get;}        

        [MethodImpl(Inline)]
        public static implicit operator cmd8x2((arg8 a, arg8 b) src)
            => new cmd8x2(src.a,src.b);

        [MethodImpl(Inline)]
        public cmd8x2(arg8 a, arg8 b)
        {
            A = a;
            B = b;
        }
    }
}