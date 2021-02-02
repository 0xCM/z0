//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmSigOpIdentifier
    {
        public byte Index {get;}

        public Identifier Name {get;}

        public AsmSigOpKind Kind {get;}

        [MethodImpl(Inline)]
        public AsmSigOpIdentifier(byte index, Identifier name, AsmSigOpKind kind)
        {
            Index = index;
            Name = name;
            Kind = kind;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Index == 0;
        }

        public static AsmSigOpIdentifier Empty => default;
    }
}