//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct UpperCased : ILetterCase<UpperCased>
    {    
        [MethodImpl(Inline)]
        public static implicit operator LetterCase(UpperCased src)
            => new LetterCase(src.IsUpper, src.IsLower, src.Kind);
     
        public bool IsUpper 
            => true;

        public bool IsLower 
            => false;

        public LetterCaseKind Kind 
            => LetterCaseKind.Upper;

        public static UpperCased Case 
            => default(UpperCased);
    }
}