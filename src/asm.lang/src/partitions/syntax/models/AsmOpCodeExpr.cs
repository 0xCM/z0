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
        readonly TextBlock Data;

        [MethodImpl(Inline)]
        public AsmOpCodeExpr(string src)
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

        public bool IsValid
        {
            [MethodImpl(Inline)]
            get => text.neq(Data,"<invalid>", NoCase);
        }

        public override int GetHashCode()
            => Data.GetHashCode();

        [MethodImpl(Inline)]
        public string Format()
            => Data.Format();

        public override string ToString()
            => Format();

        public override bool Equals(object src)
            => src is AsmOpCodeExpr x && Equals(x);

        [MethodImpl(Inline)]
        public bool Equals(AsmOpCodeExpr src)
            => Data.Equals(src.Data);

        public int CompareTo(AsmOpCodeExpr src)
            => Data.CompareTo(src.Data);

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