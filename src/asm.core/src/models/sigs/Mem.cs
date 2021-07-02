//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmSigTokens;

    partial class AsmSigs
    {
        public readonly struct Mem
        {
            public MemKind Kind {get;}

            [MethodImpl(Inline)]
            public Mem(MemKind kind)
            {
                Kind = kind;
            }

            [MethodImpl(Inline)]
            public static implicit operator Mem(MemKind src)
                => new Mem(src);

            [MethodImpl(Inline)]
            public static implicit operator MemKind(Mem src)
                => src.Kind;

            [MethodImpl(Inline)]
            public static implicit operator byte(Mem src)
                => (byte)src.Kind;
        }
    }
}