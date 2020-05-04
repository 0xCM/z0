//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static IdentityShare;

    /// <summary>
    /// Uri for .net clr assembly
    /// </summary>
    public readonly struct PartUri : IUri<PartUri>, INullary<PartUri>
    {
        public static PartUri Empty = new PartUri(PartId.None);
        
        /// <summary>
        /// The assembly identifier, constrained to the defining enumeration
        /// </summary>
        public readonly PartId Id;
        
        public string IdentityText {get;}

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Id == PartId.None || string.IsNullOrWhiteSpace(IdentityText);
        }

        PartUri INullary<PartUri>.Zero => Empty;        
        
                
        [MethodImpl(Inline)]
        public static PartUri Define(PartId id)
            => new PartUri(id);
     
        [MethodImpl(Inline)]
        PartUri(PartId id)
        {
            this.Id = id;
            this.IdentityText = id != 0 ? id.Format() : text.blank;
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
            => IdentityText;        
    }
}