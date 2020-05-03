//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static OpKind;

    using W = NumericWidth;

    /// <summary>
    /// Describes a zero exension operation
    /// </summary>
    public readonly struct ZeroExensionKind
    {
        public static ZeroExensionKind None => default(ZeroExensionKind);
        
        public readonly NumericWidth SourceWidth;

        public readonly NumericWidth TargetWidth;

        [MethodImpl(Inline)]
        public static implicit operator ZeroExensionKind((NumericWidth src, NumericWidth dst) x)
            => new ZeroExensionKind(x.src, x.dst);
        
        [MethodImpl(Inline)]
        public ZeroExensionKind(NumericWidth src, NumericWidth dst)
        {
            this.SourceWidth = src;
            this.TargetWidth = dst;
        }

    }

    /// <summary>
    /// Describes a sign exension operation
    /// </summary>
    public readonly struct SignExensionKind
    {
        public static SignExensionKind None => default(SignExensionKind);

        [MethodImpl(Inline)]
        public static implicit operator SignExensionKind((NumericWidth src, NumericWidth dst) x)
            => new SignExensionKind(x.src, x.dst);
        
        [MethodImpl(Inline)]
        public SignExensionKind(NumericWidth src, NumericWidth dst)
        {
            this.SourceWidth = src;
            this.TargetWidth = dst;
        }

        public readonly NumericWidth SourceWidth;

        public readonly NumericWidth TargetWidth;
    }
}