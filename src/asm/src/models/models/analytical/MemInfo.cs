//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using Z0.Asm;

    /// <summary>
    /// Describes a block of memory the context of an asm instruction operand
    /// </summary>
    public readonly struct MemInfo
    {
        public readonly IceRegister Seg;

        public readonly IceRegister SegPrefix;

        public readonly MemDirect Direct;

        public readonly MemoryAddress Address;

        public readonly MemorySize Size;

        public MemInfo(IceRegister segreg, IceRegister prefix, MemDirect mem, MemoryAddress address, MemorySize size)
        {
            Seg = segreg;
            SegPrefix = prefix;
            Direct = mem;
            Address = address;
            Size = size;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Size == 0 && Direct.IsEmpty && Seg == 0 && SegPrefix == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }

        public bool HasKnownSize
        {
            [MethodImpl(Inline)]
            get => Size != 0;
        }

        public static MemInfo Empty
            => default;
    }
}