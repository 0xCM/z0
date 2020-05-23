//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct LetterCase
    {
        public static LowerCased Lower => LowerCased.Case;

        public static UpperCased Upper => UpperCased.Case;

        [MethodImpl(Inline)]
        internal LetterCase(bool upper, bool lower, LetterCaseKind kind)
        {
            IsUpper = upper;
            IsLower = lower;
            Kind = kind;
        }
        
        public bool IsUpper {get;}    

        public bool IsLower {get;}    

        public LetterCaseKind Kind {get;}
    }
}