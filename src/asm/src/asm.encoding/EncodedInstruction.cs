//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines an encoded instruction
    /// </summary>
    public readonly ref struct EncodedInstruction
    {
        readonly ReadOnlySpan<byte> Code;

        [MethodImpl(Inline)]
        public EncodedInstruction(ReadOnlySpan<byte> code)
            => Code = code;

        public byte Size
        {
            [MethodImpl(Inline)]
            get => (byte)Code.Length;
        }

        public ReadOnlySpan<byte> Data
        {
            [MethodImpl(Inline)]
            get => Code;
        }
    }
}