//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static RootShare;

    public readonly struct TypeIdentity : ITypeIdentity<TypeIdentity>
    {
        public string Identifier {get;}

        public static TypeIdentity Empty => Define(string.Empty);

        /// <summary>
        /// Defines a scalar type identity
        /// </summary>
        /// <param name="width">The scalar bit-width</param>
        /// <param name="indicator"></param>
        [MethodImpl(Inline)]
        public static ScalarIdentity Scalar(FixedWidth width, NumericIndicator indicator)
            => ScalarIdentity.Define(width, indicator);

        /// <summary>
        /// Defines a segmented type identity
        /// </summary>
        /// <param name="total">The total bit-width of the type</param>
        /// <param name="segwidth">The width of each segment</param>
        /// <param name="indicator"></param>
        [MethodImpl(Inline)]
        public static SegmentedIdentity Segmented(FixedWidth total, FixedWidth segwidth, NumericIndicator indicator)
            => SegmentedIdentity.Define(total,segwidth,indicator);

        [MethodImpl(Inline)]
        public static TypeIdentity Define(string identifier)
            => new TypeIdentity(identifier);
        
        [MethodImpl(Inline)]
        public static TypeIdentity operator +(TypeIdentity lhs, string rhs)
            => Define($"{lhs}{rhs}");

        [MethodImpl(Inline)]
        public static TypeIdentity operator +(string lhs, TypeIdentity rhs)
            => Define($"{lhs}{rhs}");

        [MethodImpl(Inline)]
        public static implicit operator string(TypeIdentity src)
            => src.Identifier;

        [MethodImpl(Inline)]
        public static bool operator==(TypeIdentity a, TypeIdentity b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(TypeIdentity a, TypeIdentity b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        TypeIdentity(string id)
            => Identifier = id;

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => string.IsNullOrWhiteSpace(Identifier);
        }

        [MethodImpl(Inline)]
        public bool Equals(TypeIdentity src)
            => IdentityEquals(this, src);

        public override string ToString()
            => Identifier;
 
        public override int GetHashCode()
            => IdentityHashCode(this);

        public override bool Equals(object obj)
            => IdentityEquals(this, obj);

        public const char SegSep = 'x';

        public const char Vector = 'v';

        public const char Block = 'b';

        public const char Nat = 'n';

        public const string Pointer = "ptr";

        public const string Modifier = "~";

        public const string MSpan = "span";

        public const string ImSpan = "imspan";

        public const string NatSpan = "nspan";
    }
}