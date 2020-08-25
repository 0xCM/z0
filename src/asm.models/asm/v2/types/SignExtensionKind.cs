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
    /// Describes a sign extension operation
    /// </summary>
    [LiteralCover]
    public readonly struct SignExtensionKind : ILiteralCover<SignExtensionKind>
    {
        public readonly NumericWidth SourceWidth;

        public readonly NumericWidth TargetWidth;        

        [MethodImpl(Inline)]
        public SignExtensionKind(NumericWidth src, NumericWidth dst)
        {
            SourceWidth = src;
            TargetWidth = dst;
        }

        [MethodImpl(Inline)]
        public static implicit operator SignExtensionKind((NumericWidth src, NumericWidth dst) x)
            => new SignExtensionKind(x.src, x.dst);
        
        public static SignExtensionKind None 
            => default;
    }
}