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
    04 ib
    05 iw
    05 id
    REX.W+ 05 id
    80 /0 ib
    REX+ 80 /0 ib
    81 /0 iw
    81 /0 id
    REX.W+ 81 /0 id
    83 /0 ib
    83 /0 ib
    REX.W+ 83 /0 ib
    00 /r
    REX+ 00 /r
    01 /r
    01 /r
    REX.W+ 01 /r
    02 /r
    REX+ 02 /r
    03 /r
    03 /r
    REX.W+ 03 /r
    */

    public readonly struct AsmOpCodeExpr
    {
        public Index<string> Components {get;}

        [MethodImpl(Inline)]
        public AsmOpCodeExpr(Index<string> src)
            => Components = src;

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Components.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Components.IsNonEmpty;
        }


        [MethodImpl(Inline)]
        public bool Equals(AsmOpCodeExpr src)
            => src.Components.Equals(Components);

        public override bool Equals(object src)
            => src is AsmOpCodeExpr x && Equals(x);

        public override int GetHashCode()
            => Components.GetHashCode();

        public string Format()
            => Components.Format();

        public override string ToString()
            => Format();

        public static AsmOpCodeExpr Empty
            => new AsmOpCodeExpr(Index<string>.Empty);
    }
}