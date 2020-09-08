//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Describes a zero extension operation
    /// </summary>
    [LiteralCover]
    public readonly struct Zx : ILiteralCover<Zx>
    {
        public readonly NumericWidth SourceWidth;

        public readonly NumericWidth TargetWidth;

        [MethodImpl(Inline)]
        public static implicit operator Zx((NumericWidth src, NumericWidth dst) x)
            => new Zx(x.src, x.dst);

        [MethodImpl(Inline)]
        public Zx(NumericWidth src, NumericWidth dst)
        {
            SourceWidth = src;
            TargetWidth = dst;
        }
    }
}