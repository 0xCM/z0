//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static IdentityShare;

    public enum IdentityPartKind : ushort
    {
        None = 0,
                
        /// <summary>
        /// The unadorned subject name and the first part of the moniker
        /// </summary>
        Name = 1,
                
        /// <summary>
        /// A trailing component of the form {suffix sep}{suffix name}
        /// </summary>
        Suffix = 4,
                
        /// <summary>
        /// A numeric specifier of the form {width}{numeric_indicator}
        /// </summary>
        /// <example>
        /// In the identifier 'gteq_(8u,8u)' both arguments are 8-bit unsigned scalar values
        /// </example>
        Numeric,

        /// <summary>
        /// A segmentation specifier of the form {total width}x{segment width}{numeric indicator}
        /// </summary>
        /// <example>
        /// in the identifier 'vnand_(v128x16u,v128x16u)', the term '128x16u' in both value arguments is a segment specifier
        /// </example>
        Segment ,
    }


    public readonly struct IdentityPart : IIdentifiedTarget<IdentityPart>
    {        
        public readonly byte PartIndex;

        public readonly IdentityPartKind PartKind;

        public string Identifier {get;}

        /// <summary>
        /// Defines an identity part
        /// </summary>
        /// <param name="width">The scalar bit-width</param>
        [MethodImpl(Inline)]
        public static IdentityPart Define(byte index, IdentityPartKind kind, string text)
            => new IdentityPart(index, kind, text);
        
        public static implicit operator IdentityPart((byte index, IdentityPartKind kind, string text) src)
            => Define(src.index, src.kind, src.text);

        [MethodImpl(Inline)]
        public static implicit operator string(IdentityPart src)
            => src.Identifier;

        [MethodImpl(Inline)]
        public static bool operator==(IdentityPart a, IdentityPart b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(IdentityPart a, IdentityPart b)
            => !a.Equals(b);

        IdentityPart(byte index, IdentityPartKind kind, string text)
        {
            this.PartIndex = index;
            this.PartKind = kind;
            this.Identifier = text;
        }
        
        public IdentityPart WithText(string src)
            => Define(PartIndex, PartKind, src);

        [MethodImpl(Inline)]
        public bool Equals(IdentityPart src)
            => equals(this, src);

        [MethodImpl(Inline)]
        public int CompareTo(IdentityPart other)
            => compare(this, other);        

        public override string ToString()
            => Identifier;
 
        public override int GetHashCode()
            => hash(this);

        public override bool Equals(object obj)
            => equals(this, obj);
    }
}