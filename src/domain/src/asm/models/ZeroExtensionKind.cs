//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Describes a zero exension operation
    /// </summary>
    public readonly struct ZeroExensionKind
    {        
        public readonly NumericWidth SourceWidth;

        public readonly NumericWidth TargetWidth;

        [MethodImpl(Inline)]
        public static implicit operator ZeroExensionKind((NumericWidth src, NumericWidth dst) x)
            => new ZeroExensionKind(x.src, x.dst);
        
        [MethodImpl(Inline)]
        public ZeroExensionKind(NumericWidth src, NumericWidth dst)
        {
            SourceWidth = src;
            TargetWidth = dst;
        }

        public static ZeroExensionKind None => default;
    }
}