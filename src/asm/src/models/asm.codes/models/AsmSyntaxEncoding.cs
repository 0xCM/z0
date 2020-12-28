//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines an op code via a sequence bytes
    /// </summary>
    public readonly struct AsmSyntaxEncoding : ITextual
    {
        readonly ulong Data;

        [MethodImpl(Inline)]
        public AsmSyntaxEncoding(ulong data)
            => Data = data;

        public ReadOnlySpan<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => Data.Bytes();
        }
        public string Format()
            => asci.format(Data);

        public override string ToString()
            => Format();
    }
}