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
    /// Describes a block of memory the context of an asm instruction operand
    /// </summary>
    public readonly struct AsmMemoryInfo
    {
        public RegisterKind SegReg {get;}

        public RegisterKind SegPrefix {get;}

        public AsmRegMemory Direct {get;}

        public MemoryAddress Address {get;}

        public byte SizeKind {get;}

        public AsmMemoryInfo(RegisterKind seg, RegisterKind prefix, AsmRegMemory mem, MemoryAddress address, byte sizekind)
        {
            SegReg = seg;
            SegPrefix = prefix;
            Direct = mem;
            Address = address;
            SizeKind = sizekind;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => SizeKind == 0 && Direct.IsEmpty && SegReg == 0 && SegPrefix == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }

        public bool HasKnownSize
        {
            [MethodImpl(Inline)]
            get => SizeKind != 0;
        }

        public static AsmMemoryInfo Empty
            => default;
    }
}