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

    using api = AsmBytes;

    public struct AsmInstruction<T> : IAsmInstruction<AsmInstruction<T>,T>
        where T : unmanaged
    {
        public T Encoded {get; set;}

        [MethodImpl(Inline)]
        public AsmInstruction(T encoded)
            => Encoded = encoded;

        public ReadOnlySpan<byte> Data
        {
            [MethodImpl(Inline)]
            get => bytes(Encoded);
        }

        public ReadOnlySpan<AsmByte> Bytes
        {
            [MethodImpl(Inline)]
            get => recover<AsmByte>(Data);
        }

        public uint4 Size
        {
            [MethodImpl(Inline)]
            get => (uint4)Data.Length;
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmInstruction<T>(T src)
            => new AsmInstruction<T>(src);

        public static implicit operator AsmInstruction(AsmInstruction<T> src)
            => api.untype(src);
    }
}