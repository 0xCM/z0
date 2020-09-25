//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    public readonly struct EncodedInstruction
    {
        readonly Vector128<byte> Storage;

        [MethodImpl(Inline)]
        internal EncodedInstruction(Vector128<byte> src)
            => Storage = src;
    }

    public readonly struct AsmStatementCode : ITextual
    {
        public readonly asci64 Asm;

        [MethodImpl(Inline)]
        public static implicit operator AsmStatementCode(string src)
            => new AsmStatementCode(src);

        [MethodImpl(Inline)]
        public AsmStatementCode(in asci64 asm)
            => Asm = asm;

        [MethodImpl(Inline)]
        public string Format()
            => Asm.Format();

        public override string ToString()
            => Format();
    }
}