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
    /// Describes a zero extension operation
    /// </summary>
    [LiteralCover]
    public readonly struct ZeroExtensionKind : ILiteralCover<ZeroExtensionKind>
    {        
        public readonly NumericWidth SourceWidth;

        public readonly NumericWidth TargetWidth;

        [MethodImpl(Inline)]
        public static implicit operator ZeroExtensionKind((NumericWidth src, NumericWidth dst) x)
            => new ZeroExtensionKind(x.src, x.dst);
        
        [MethodImpl(Inline)]
        public ZeroExtensionKind(NumericWidth src, NumericWidth dst)
        {
            SourceWidth = src;
            TargetWidth = dst;
        }
    }
}