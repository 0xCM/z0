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

        public readonly BasedCodeBlock Input;

        public readonly BasedCodeBlock Output;

        [MethodImpl(Inline)]
        public CapturedCodeBlock(MemoryAddress @base, BasedCodeBlock input, BasedCodeBlock output)
        {
            insist(@base, input.Base);
            insist(@base, output.Base);
            Base = @base;
            Input = input;
            Output = output;
        }

        [MethodImpl(Inline)]
        public CapturedCodeBlock(MemoryAddress @base, byte[] input, byte[] output)
        {
            Base = @base;
            Input = new BasedCodeBlock(@base, input);
            Output = new BasedCodeBlock(@base, output);
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

        public BasedCodeBlock Source
            => Input;

        public BasedCodeBlock Target
            => Output;

        [MethodImpl(Inline)]
        public bool Equals(CapturedCodeBlock src)
            => Output.Equals(src.Output);

        public string Format()
            => Output.Format();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator DataFlow<BasedCodeBlock>(CapturedCodeBlock src)
            => (src.Input,src.Output);
    }
}