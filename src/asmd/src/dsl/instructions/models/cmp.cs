//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public readonly struct cmp<S,T>
        where S : IOperand
        where T : IOperand
    {
        public S Src {get;}

        public T Dst {get;}

        [MethodImpl(Inline)]
        public static implicit operator cmp<S,T>(Paired<S,T> src)
            => new cmp<S,T>(src.Left, src.Right);

        [MethodImpl(Inline)]
        public cmp(S src, T dst)
        {
            Src = src;
            Dst = dst;
        }        
    }
}