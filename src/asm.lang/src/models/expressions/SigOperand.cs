//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmExpr
    {
        public readonly struct SigOperand : ITextExpr<SigOperand>
        {
            readonly TextBlock Data;

            [MethodImpl(Inline)]
            public SigOperand(string src)
                => Data = src;

            public bool IsComposite
            {
                [MethodImpl(Inline)]
                get => composite(this);
            }

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
            public bool Equals(SigOperand src)
                => Data.Equals(src.Data);

            public override bool Equals(object src)
                => src is SigOperand x && Equals(x);

            [MethodImpl(Inline)]
            public static implicit operator SigOperand(string src)
                => new SigOperand(src);

            public static SigOperand Empty
                => new SigOperand(EmptyString);
        }
    }
}