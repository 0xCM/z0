//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmInstructions
    {
        public readonly struct Movzx
        {
            [MethodImpl(Inline)]
            public static Movzx<S,T> create<S,T>(S src, T dst)
                => new Movzx<S,T>(src,dst);
        }

        public readonly struct Movzx<S,T>
        {
            public readonly S Source;

            public readonly T Target;

            [MethodImpl(Inline)]
            public Movzx(S src, T dst)
            {
                Source = src;
                Target = dst;
            }
        }
    }
}