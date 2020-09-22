//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct CapturedMemoryBlock
    {
        public CodeBlockDataFlow Encoded {get;}

        public AsmFxList Decoded {get;}

        public string[] Formatted {get;}

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
        public CapturedMemoryBlock(CodeBlockDataFlow encoded, AsmFxList fxList, string[] formatted)
        {
            Encoded = encoded;
            Decoded = fxList;
            Formatted = formatted;
        }

        [MethodImpl(Inline)]
        public bool Equals(CapturedMemoryBlock src)
            => Encoded.Equals(src.Encoded);

        public string Format()
            => Encoded.Format();

        public override string ToString()
            => Format();
    }
}