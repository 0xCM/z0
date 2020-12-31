//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;
    using static z;

    /// <summary>
    /// Wraps a packed sequence of bytes that defines the content of an instruction
    /// </summary>
    public readonly struct PackedInstruction : ITextual
    {
        readonly Vector256<byte> Data;

        [MethodImpl(Inline)]
        internal PackedInstruction(Vector256<byte> src)
            => Data = src;

        public MemoryAddress NextRip
        {
            [MethodImpl(Inline)]
            get => vcell(v64u(vlo(Data)),0);
        }

        [MethodImpl(Inline)]
        public byte Register(N0 n)
            => vcell(Data,0);

        [MethodImpl(Inline)]
        public byte Register(N1 n)
            => vcell(Data,1);

        [MethodImpl(Inline)]
        public byte Register(N2 n)
            => vcell(Data,2);

        [MethodImpl(Inline)]
        public byte Register(N3 n)
            => vcell(Data,3);

        [MethodImpl(Inline)]
        public byte Register(byte index)
            => vcell(Data,index);

        public byte BaseRegister
        {
            [MethodImpl(Inline)]
            get => vcell(Data,0);
        }

        [MethodImpl(Inline)]
        public string Format()
            => Data.FormatAsmHex();
    }

}