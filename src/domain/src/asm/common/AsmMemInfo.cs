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
        public static AsmMemInfo Empty => new AsmMemInfo(Register.None, Register.None, AsmMemDirect.Empty, MemoryAddress.Empty, MemorySize.Unknown);
                
        public Register SegmentRegister {get;}
                
        public Register SegmentPrefix {get;}
        
        public AsmMemDirect Direct {get;}

        public MemoryAddress Address {get;}

        public MemorySize Size {get;}

        public AsmMemInfo(Register segreg, Register prefix, AsmMemDirect mem, MemoryAddress address, MemorySize size)        
        {
            SegmentRegister = segreg;
            SegmentPrefix = prefix;
            Direct = mem;
            Address = address;
            Size = size;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Size == 0 && Direct.IsEmpty && SegmentRegister == 0 && SegmentPrefix == 0;
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
    }
}