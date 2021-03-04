//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmExpr
    {
        public readonly struct Form
        {
            public ushort Id {get;}

            public Signature Sig {get;}

            public OpCode OpCode {get;}

            [MethodImpl(Inline)]
            internal Form(ushort id, OpCode opcode, Signature sig)
            {
                OpCode = opcode;
                Sig = sig;
                Id = id;
            }

            public bool IsEmpty
            {
                [MethodImpl(Inline)]
                get => OpCode.IsEmpty || Sig.IsEmpty;
            }

            public bool IsNonEmpty
            {
                [MethodImpl(Inline)]
                get => !IsEmpty;
            }

            public bool IsComposite
            {
                [MethodImpl(Inline)]
                get => Sig.IsComposite;
            }

            [MethodImpl(Inline)]
            public bool Equals(Form src)
                => OpCode == src.OpCode && Sig == src.Sig;

            public override bool Equals(object src)
                => src is Form x && Equals(x);

            public override int GetHashCode()
                => (int)alg.hash.combine(OpCode.GetHashCode(), Sig.GetHashCode());

            public string Format()
                => string.Format("{0,-8} | {1,-64} | {2}", Id, Sig.Format(), OpCode.Format());

            public override string ToString()
                => Format();

            public static Form Empty
                => new Form(0, OpCode.Empty, AsmExpr.Signature.Empty);
        }
    }
}