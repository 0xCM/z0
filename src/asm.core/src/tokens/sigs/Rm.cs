//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct AsmSigTokens
    {
        public readonly struct Rm
        {
            public RmKind Kind {get;}

            [MethodImpl(Inline)]
            public Rm(RmKind kind)
            {
                Kind = kind;
            }

            [MethodImpl(Inline)]
            public static implicit operator Rm(RmKind src)
                => new Rm(src);

            [MethodImpl(Inline)]
            public static implicit operator RmKind(Rm src)
                => src.Kind;

            [MethodImpl(Inline)]
            public static implicit operator byte(Rm src)
                => (byte)src.Kind;
        }
    }
}