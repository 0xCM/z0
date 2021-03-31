//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmOpCodeExpr : IComparable<AsmOpCodeExpr>
    {
        readonly TextBlock _Data;

        [MethodImpl(Inline)]
        public AsmOpCodeExpr(string src)
            => _Data = src;

        public string Content
        {
            [MethodImpl(Inline)]
            get => _Data.Text;
        }

        public ReadOnlySpan<char> Data
        {
            [MethodImpl(Inline)]
            get => _Data.Text;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => _Data.Length;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => _Data.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => _Data.IsNonEmpty;
        }

        public bool IsValid
        {
            [MethodImpl(Inline)]
            get => text.neq(_Data,"<invalid>", NoCase);
        }

        public override int GetHashCode()
            => _Data.GetHashCode();

        [MethodImpl(Inline)]
        public string Format()
            => _Data.Format();

        public override string ToString()
            => Format();

        public override bool Equals(object src)
            => src is AsmOpCodeExpr x && Equals(x);

        [MethodImpl(Inline)]
        public bool Equals(AsmOpCodeExpr src)
            => _Data.Equals(src._Data);

        public int CompareTo(AsmOpCodeExpr src)
            => _Data.CompareTo(src._Data);

        [MethodImpl(Inline)]
        public static bool operator ==(AsmOpCodeExpr a, AsmOpCodeExpr b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(AsmOpCodeExpr a, AsmOpCodeExpr b)
            => !a.Equals(b);

        public static AsmOpCodeExpr Empty
            => new AsmOpCodeExpr(EmptyString);
    }
}