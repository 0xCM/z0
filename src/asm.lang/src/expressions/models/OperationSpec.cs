//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmSigs;

    partial struct AsmExpr
    {
        public readonly struct OperationSpec
        {
            public ushort Seq {get;}

            public Signature Sig {get;}

            public OpCode OpCode {get;}

            [MethodImpl(Inline)]
            internal OperationSpec(ushort seq, OpCode opcode, Signature sig)
            {
                OpCode = opcode;
                Sig = sig;
                Seq = seq;
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
            public bool Equals(OperationSpec src)
                => OpCode == src.OpCode && Sig == src.Sig;

            public override bool Equals(object src)
                => src is OperationSpec x && Equals(x);

            public override int GetHashCode()
                => (int)alg.hash.combine(OpCode.GetHashCode(), Sig.GetHashCode());

            public string Format()
                => string.Format("{0,-8} | {1,-64} | {2}", Seq, Sig.Format(), OpCode.Format());

            public override string ToString()
                => Format();

            public static OperationSpec Empty
                => new OperationSpec(0, OpCode.Empty, AsmExpr.Signature.Empty);
        }
    }
}