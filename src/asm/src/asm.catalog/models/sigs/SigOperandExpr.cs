//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /* Examples:
    AL
    imm8
    AX
    imm16
    EAX
    imm32
    RAX
    imm32
    r/m8
    imm8
    r/m8
    imm8
    r/m16
    imm16
    r/m32
    imm32
    r/m64
    imm32
    r/m16
    imm8
    r/m32
    imm8
    r/m64
    imm8
    r/m8
    r8
    r/m8
    r8
    r/m16
    r16
    r/m32
    r32
    r/m64
    r64
    r8
    r/m8
    r8
    r/m8
    r16
    r/m16
    r32
    r/m32
    r64
    r/m64
    */

    /// <summary>
    /// Represents an operand in the context of a <see cref='AsmSigExpr'/>
    /// </summary>
    public readonly struct SigOperandExpr : ITextExpr<SigOperandExpr>
    {
        public readonly TextBlock Content {get;}

        [MethodImpl(Inline)]
        public SigOperandExpr(string src)
            => Content = src;

        /// <summary>
        /// The expression length
        /// </summary>
        public int Length
        {
            [MethodImpl(Inline)]
            get => Content.Length;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Content.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Content.IsNonEmpty;
        }

        public TextBlock Text
        {
            [MethodImpl(Inline)]
            get => Content;
        }

        [MethodImpl(Inline)]
        public bool Equals(SigOperandExpr src)
            => src.Content.Equals(Content);

        public override bool Equals(object src)
            => src is SigOperandExpr x && Equals(x);

        public override int GetHashCode()
            => Content.GetHashCode();

        [MethodImpl(Inline)]
        public string Format()
            => Content.Format();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator SigOperandExpr(string src)
            => new SigOperandExpr(src);

        public static SigOperandExpr Empty
            => new SigOperandExpr(EmptyString);
    }
}