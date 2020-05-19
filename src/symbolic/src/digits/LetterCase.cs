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

    public enum LetterCaseKind : byte
    {
        None = 0,

        Lower = 1,

        Upper = 2
    }

    public interface ILetterCase
    {
        bool IsUpper {get;}    

        bool IsLower {get;}    

        LetterCaseKind Kind {get;}
    }
    
    public interface ILetterCase<F> : ILetterCase
        where F : unmanaged, ILetterCase<F>
    {
        
    }

    public readonly struct UpperCased : ILetterCase<UpperCased>
    {    
        public static UpperCased Case => default(UpperCased);

        [MethodImpl(Inline)]
        public static implicit operator LetterCase(UpperCased src)
            => new LetterCase(src.IsUpper, src.IsLower, src.Kind);
     
        public bool IsUpper => true;

        public bool IsLower => false;

        public LetterCaseKind Kind => LetterCaseKind.Upper;
    }

    public readonly struct LowerCased : ILetterCase<LowerCased>
    {
        public static LowerCased Case => default(LowerCased);

        [MethodImpl(Inline)]
        public static implicit operator LetterCase(LowerCased src)
            => new LetterCase(src.IsUpper, src.IsLower, src.Kind);

        public bool IsUpper => false;

        public bool IsLower => true;

        public LetterCaseKind Kind => LetterCaseKind.Lower;        
    }
}