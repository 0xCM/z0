//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using api = AsmThumbprints;

    public readonly struct AsmThumbprintExpr : IDataTypeComparable<AsmThumbprintExpr>
    {
        TextBlock Content {get;}


        [MethodImpl(Inline)]
        internal AsmThumbprintExpr(string content)
            => Content = content;

        public string Format()
            => Content.Format();

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => Content.GetHashCode();

        public bool Equals(AsmThumbprintExpr src)
            => src.Content.Equals(Content);

        public override bool Equals(object src)
            => src is AsmThumbprintExpr t && Equals(t);

        public int CompareTo(AsmThumbprintExpr src)
            => api.cmp(this, src);

        public static AsmThumbprintExpr Empty
        {
            [MethodImpl(Inline)]
            get => new AsmThumbprintExpr(EmptyString);
        }

        const string Implication = " => ";
    }
}