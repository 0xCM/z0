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

    public readonly struct CapturedCodeBlock
    {
        public readonly MemoryAddress Base;

        public readonly CodeBlock Input;

        public readonly CodeBlock Output;

        [MethodImpl(Inline)]
        public CapturedCodeBlock(MemoryAddress @base, CodeBlock input, CodeBlock output)
        {
            insist(@base, input.BaseAddress);
            insist(@base, output.BaseAddress);
            Base = @base;
            Input = input;
            Output = output;
        }

        [MethodImpl(Inline)]
        public CapturedCodeBlock(MemoryAddress @base, byte[] input, byte[] output)
        {
            Base = @base;
            Input = new CodeBlock(@base, input);
            Output = new CodeBlock(@base, output);
        }

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

        public CodeBlock Source
            => Input;

        public CodeBlock Target
            => Output;

        [MethodImpl(Inline)]
        public bool Equals(CapturedCodeBlock src)
            => Output.Equals(src.Output);

        public string Format()
            => Output.Format();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator DataFlow<CodeBlock>(CapturedCodeBlock src)
            => (src.Input,src.Output);
    }
}