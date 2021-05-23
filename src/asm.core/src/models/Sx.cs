//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Describes a sign extension operation
    /// </summary>
    public readonly struct Sx : ILiteralCover<Sx>
    {
        public NumericWidth SourceWidth {get;}

        public NumericWidth TargetWidth {get;}

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