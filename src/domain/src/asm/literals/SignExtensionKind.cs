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
    /// Describes a sign exension operation
    /// </summary>
    public readonly struct SignExensionKind
    {
        public readonly NumericWidth SourceWidth;

        public readonly NumericWidth TargetWidth;        

        [MethodImpl(Inline)]
        public SignExensionKind(NumericWidth src, NumericWidth dst)
        {
            SourceWidth = src;
            TargetWidth = dst;
        }

        [MethodImpl(Inline)]
        public static implicit operator SignExensionKind((NumericWidth src, NumericWidth dst) x)
            => new SignExensionKind(x.src, x.dst);
        
        public static SignExensionKind None 
            => default(SignExensionKind);
    }
}