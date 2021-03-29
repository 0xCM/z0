//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using api = AsmThumbprints;

    public readonly struct AsmThumbprint : IDataTypeComparable<AsmThumbprint>
    {
        public AsmSigExpr Sig {get;}

        public AsmOpCodeExpr OpCode {get;}

        public AsmHexCode Encoded {get;}

        [MethodImpl(Inline), Op]
        public AsmThumbprint(AsmSigExpr sig, AsmOpCodeExpr opcode, AsmHexCode encoded)
        {
            Sig = sig;
            OpCode = opcode;
            Encoded = encoded;
        }

        public byte CodeSize
        {
            [MethodImpl(Inline)]
            get => Encoded.Size;
        }

        public int CompareTo(AsmThumbprint src)
            => api.cmp(this, src);


        public bool Equals(AsmThumbprint src)
            => api.eq(this, src);

        public override int GetHashCode()
            => Format().GetHashCode();
        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        public AsmThumbprintExpr ToExpression()
            => new AsmThumbprintExpr(Format());

        public static AsmThumbprint Empty
        {
            [MethodImpl(Inline)]
            get => new AsmThumbprint(AsmSigExpr.Empty, AsmOpCodeExpr.Empty, AsmHexCode.Empty);
        }
    }
}