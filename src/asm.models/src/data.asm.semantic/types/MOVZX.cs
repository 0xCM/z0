//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Types
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct MOVZX
    {


        [MethodImpl(Inline)]
        public static MOVZX<S,T> create<S,T>(S src, T dst)
            => new MOVZX<S,T>(src,dst);
    }

    public readonly struct MOVZX<S,T>
    {
        public readonly S Source;

        public readonly T Target;

        [MethodImpl(Inline)]
        public MOVZX(S src, T dst)
        {
            Source = src;
            Target = dst;
        }
    }
}