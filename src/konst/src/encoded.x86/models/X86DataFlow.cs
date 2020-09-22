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

    public readonly struct X86DataFlow : IDataFlow<BasedCodeBlock>
    {
        public readonly MemoryAddress Base;

        public readonly BasedCodeBlock Input;

        public readonly BasedCodeBlock Output;

        [MethodImpl(Inline)]
        public X86DataFlow(MemoryAddress @base, BasedCodeBlock input, BasedCodeBlock output)
        {
            insist(@base, input.Base);
            insist(@base, output.Base);
            Base = @base;
            Input = input;
            Output = output;
        }

        [MethodImpl(Inline)]
        public X86DataFlow(MemoryAddress @base, byte[] input, byte[] output)
        {
            Base = @base;
            Input = new BasedCodeBlock(@base, input);
            Output = new BasedCodeBlock(@base, output);
        }

        [MethodImpl(Inline)]
        public static implicit operator DataFlow<BasedCodeBlock> (X86DataFlow src)
            => (src.Input,src.Output);

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

        BasedCodeBlock IArrow<BasedCodeBlock, BasedCodeBlock>.Source
            => Input;

        BasedCodeBlock IArrow<BasedCodeBlock, BasedCodeBlock>.Target
            => Output;


        [MethodImpl(Inline)]
        public bool Equals(X86DataFlow src)
            => Output.Equals(src.Output);

        public string Format()
            => Output.Format();

        public override string ToString()
            => Format();
    }
}