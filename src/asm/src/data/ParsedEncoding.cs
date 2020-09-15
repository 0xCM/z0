//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct ParsedEncoding
    {
        public readonly MemoryAddress Base;

        public readonly X86Code Input;

        public readonly X86Code Output;

        public int Length
        {
            [MethodImpl(Inline)]
            get => Output.Length;
        }

        public ref readonly byte this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Output[index];
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Output.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Output.IsNonEmpty;
        }

        [MethodImpl(Inline)]
        public ParsedEncoding(MemoryAddress @base, X86Code input, X86Code output)
        {
            insist(@base, input.Base);
            insist(@base, output.Base);
            Base = @base;
            Input = input;
            Output = output;
        }

        [MethodImpl(Inline)]
        public ParsedEncoding(MemoryAddress @base, byte[] input, byte[] output)
        {
            Base = @base;
            Input = new X86Code(@base, input);
            Output = new X86Code(@base, output);
        }

        [MethodImpl(Inline)]
        public bool Equals(ParsedEncoding src)
            => Output.Equals(src.Output);

        public string Format()
            => Output.Format();

        public override string ToString()
            => Format();
    }
}