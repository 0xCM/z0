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
        [MethodImpl(Inline)]
        public static CapturedMemory Define(MemoryAddress address, ParsedCode data, AsmInstructionList instructions, string formatted)
            => new CapturedMemory(address, data, instructions,formatted);

        public ParsedCode Encoded {get;}

        public MemoryAddress Address {get;}

        public AsmInstructionList Decoded {get;}

        public string FormattedAsm {get;}       


        public int Length { [MethodImpl(Inline)] get => Encoded.Length; }

        public bool IsEmpty { [MethodImpl(Inline)] get => Encoded.IsEmpty; }

        public bool IsNonEmpty { [MethodImpl(Inline)] get => Encoded.IsNonEmpty; }

        public ReadOnlySpan<byte> Bytes  { [MethodImpl(Inline)] get => Encoded.Bytes; }

        public ref readonly byte Head { [MethodImpl(Inline)] get => ref Encoded.Head;}

        public ref readonly byte this[int index] { [MethodImpl(Inline)] get => ref Encoded[index]; }

        public MemoryRange MemorySegment { [MethodImpl(Inline)] get => Encoded.MemorySegment;}

        [MethodImpl(Inline)]
        public bool Equals(CapturedMemory src)
            => Encoded.Equals(src.Encoded);
        public string Format()
            => Encoded.Format();
        
        public override string ToString()
            => Format();       
        
        [MethodImpl(Inline)]
        internal CapturedMemory(MemoryAddress address, ParsedCode data, AsmInstructionList instructions, string formatted)
        {
            this.Address = address;
            this.Encoded = data;
            this.Decoded = instructions;
            this.FormattedAsm = formatted;
        }
    }
}