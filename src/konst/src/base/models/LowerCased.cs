//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct LowerCased : ILetterCase<LowerCased>
    {
        public static LowerCased Case => default(LowerCased);

        [MethodImpl(Inline)]
        public static implicit operator LetterCase(LowerCased src)
            => new LetterCase(src.IsUpper, src.IsLower, src.Kind);

        public bool IsUpper 
            => false;

        public bool IsLower 
            => true;

        public LetterCaseKind Kind 
            => LetterCaseKind.Lower;        
    }
}