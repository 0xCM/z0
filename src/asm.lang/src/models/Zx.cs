//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Describes a zero extension operation
    /// </summary>
    public readonly struct Zx : ILiteralCover<Zx>
    {
        public NumericWidth SourceWidth {get;}

        public NumericWidth TargetWidth {get;}

        [MethodImpl(Inline)]
        public Zx(NumericWidth src, NumericWidth dst)
        {
            SourceWidth = src;
            TargetWidth = dst;
        }

        [MethodImpl(Inline)]
        public static implicit operator Zx((NumericWidth src, NumericWidth dst) x)
            => new Zx(x.src, x.dst);
    }
}