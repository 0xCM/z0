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
    public readonly struct AsmSigOpExpr : ITextExpr<AsmSigOpExpr>
    {
        public string Content {get;}

        [MethodImpl(Inline)]
        public AsmSigOpExpr(string src)
            => Content = src ?? EmptyString;

        /// <summary>
        /// The expression length
        /// </summary>
        public int Length
        {
            [MethodImpl(Inline)]
            get => text.length(Content);
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => text.empty(Content);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => text.nonempty(Content);
        }

        [MethodImpl(Inline)]
        public bool Equals(AsmSigOpExpr src)
            => text.equals(Content, src.Content);

        public override bool Equals(object src)
            => src is AsmSigOpExpr x && Equals(x);

        public override int GetHashCode()
            => text.hash(Content);

        [MethodImpl(Inline)]
        public string Format()
            => Content;

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator AsmSigOpExpr(string src)
            => new AsmSigOpExpr(src);

        public static AsmSigOpExpr Empty
            => new AsmSigOpExpr(EmptyString);
    }
}