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
    /// Describes a sign extension operation
    /// </summary>
    [LiteralCover]
    public readonly struct Sx : ILiteralCover<Sx>
    {
        public readonly NumericWidth SourceWidth;

        public readonly NumericWidth TargetWidth;

        [MethodImpl(Inline)]
        public Sx(NumericWidth src, NumericWidth dst)
        {
            SourceWidth = src;
            TargetWidth = dst;
        }

        [MethodImpl(Inline)]
        public static implicit operator Sx((NumericWidth src, NumericWidth dst) x)
            => new Sx(x.src, x.dst);

        public static Sx None
            => default;
    }
}