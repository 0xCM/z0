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
    /// Describes a block of memory the context of an asm instruction operand
    /// </summary>
    public readonly struct AsmMemInfo : INullity
    {                      
        public readonly Register Seg;
                
        public readonly Register SegPrefix;
        
        public readonly AsmMemDirect Direct;

        public readonly MemoryAddress Address;

        public readonly MemorySize Size;

        public AsmMemInfo(Register segreg, Register prefix, AsmMemDirect mem, MemoryAddress address, MemorySize size)        
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

        public static AsmMemInfo Empty 
            => default;
    }
}