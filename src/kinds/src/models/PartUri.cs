//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static IdentityShare;
    
    /// <summary>
    /// Uri for .net clr assembly
    /// </summary>
    public readonly struct PartUri : IUri<PartUri>, INullary<PartUri>
    {        
        /// <summary>
        /// The assembly identifier, constrained to the defining enumeration
        /// </summary>
        public readonly PartId Id;

        /// <summary>
        /// The uri content
        /// </summary>
        public string UriText {get;}

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Id == PartId.None || string.IsNullOrWhiteSpace(UriText);
        }

        PartUri INullary<PartUri>.Zero 
            => Empty;            
                     
        [MethodImpl(Inline)]
        internal PartUri(PartId id)
        {
            Id = id;
            UriText = id != 0 ? id.Format() : EmptyString;        
        }

        [MethodImpl(Inline)]
        public bool Equals(PartUri src)
            => equals(this, src);

        [MethodImpl(Inline)]
        public int CompareTo(PartUri other)
            => compare(this, other);
 
        public override int GetHashCode()
            => hash(this);

        public override bool Equals(object obj)
            => equals(this, obj);

        public override string ToString()
            => UriText; 

        public static PartUri Empty 
            => new PartUri(0);
    }
}