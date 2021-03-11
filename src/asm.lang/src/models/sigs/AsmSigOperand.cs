//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmSigOperand : ITextExpr<AsmSigOperand>
    {
        readonly TextBlock Data;

        [MethodImpl(Inline)]
        public AsmSigOperand(string src)
            => Data = src;

        public string Content
        {
            [MethodImpl(Inline)]
            get => Data.Text;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Data.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Data.IsNonEmpty;
        }

        public override int GetHashCode()
            => Data.GetHashCode();

        [MethodImpl(Inline)]
        public string Format()
            => Data.Format();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(AsmSigOperand src)
            => Data.Equals(src.Data);

        public override bool Equals(object src)
            => src is AsmSigOperand x && Equals(x);

        [MethodImpl(Inline)]
        public static implicit operator AsmSigOperand(string src)
            => new AsmSigOperand(src);

        public static AsmSigOperand Empty
            => new AsmSigOperand(EmptyString);
    }

}