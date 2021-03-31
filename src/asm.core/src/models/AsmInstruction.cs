//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public struct AsmInstruction : IAsmInstruction<AsmInstruction, AsmHexCode>
    {
        public AsmHexCode Encoded {get;set;}

        [MethodImpl(Inline)]
        public AsmInstruction(AsmHexCode encoded)
            => Encoded = encoded;

        public uint4 Size
        {
            [MethodImpl(Inline)]
            get => Encoded.Size;
        }

        public ReadOnlySpan<byte> Data
        {
            [MethodImpl(Inline)]
            get => Encoded.Bytes;
        }

        public ReadOnlySpan<AsmByte> Bytes
        {
            [MethodImpl(Inline)]
            get => recover<AsmByte>(Data);
        }

        [MethodImpl(Inline)]
        public static explicit operator ulong(AsmInstruction src)
            => src.Encoded.Data.Lo;

        [MethodImpl(Inline)]
        public static explicit operator uint(AsmInstruction src)
            => (uint)src.Encoded.Data.Lo;

        [MethodImpl(Inline)]
        public static explicit operator ushort(AsmInstruction src)
            => (ushort)src.Encoded.Data.Lo;

        [MethodImpl(Inline)]
        public static explicit operator byte(AsmInstruction src)
            => (byte)src.Encoded.Data.Lo;

        [MethodImpl(Inline)]
        public static explicit operator AsmInstruction<ulong>(AsmInstruction src)
            => src.Encoded.Data.Lo;

        [MethodImpl(Inline)]
        public static explicit operator AsmInstruction<uint>(AsmInstruction src)
            => (uint)src.Encoded.Data.Lo;

        [MethodImpl(Inline)]
        public static explicit operator AsmInstruction<ushort>(AsmInstruction src)
            => (ushort)src.Encoded.Data.Lo;

        [MethodImpl(Inline)]
        public static explicit operator AsmInstruction<byte>(AsmInstruction src)
            => (byte)src.Encoded.Data.Lo;
    }
}