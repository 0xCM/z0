//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public readonly struct CapturedMemory  : ILocatedCode<CapturedMemory,ParsedCode>
    {
        public ParsedCode Encoded {get;}

        public MemoryAddress Address {get;}

        public AsmInstructionList Decoded {get;}

        public string FormattedAsm {get;}       

        public byte[] Data 
        { 
            [MethodImpl(Inline)] 
            get => Encoded.Data;
        }
        
        public int Length 
        { 
            [MethodImpl(Inline)] 
            get => Encoded.Length; 
        }

        public ref readonly byte this[int index] 
        { 
            [MethodImpl(Inline)] 
            get => ref Encoded[index]; 
        }

        public bool IsEmpty 
        { 
            [MethodImpl(Inline)] 
            get => Encoded.IsEmpty; 
        }

        public bool IsNonEmpty 
        { 
            [MethodImpl(Inline)] 
            get => Encoded.IsNonEmpty; 
        }

        [MethodImpl(Inline)]
        public bool Equals(CapturedMemory src)
            => Encoded.Equals(src.Encoded);
        public string Format()
            => Encoded.Format();
        
        public override string ToString()
            => Format();       
        
        [MethodImpl(Inline)]
        public CapturedMemory(MemoryAddress address, ParsedCode data, AsmInstructionList instructions, string formatted)
        {
            Address = address;
            Encoded = data;
            Decoded = instructions;
            FormattedAsm = formatted;
        }        
    }
}