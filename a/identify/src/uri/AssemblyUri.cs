//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Identify;
    using static IdentityShare;

    /// <summary>
    /// Uri for .net clr assembly
    /// </summary>
    public readonly struct AssemblyUri : IUri<AssemblyUri>, INullary<AssemblyUri>
    {
        public static AssemblyUri Empty = new AssemblyUri(PartId.None);
        
        /// <summary>
        /// The assembly identifier, constrained to the defining enumeration
        /// </summary>
        public readonly PartId Id;
        
        public string Identifier {get;}

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Id == PartId.None || string.IsNullOrWhiteSpace(Identifier);
        }

        AssemblyUri INullary<AssemblyUri>.Zero => Empty;        
        
        [MethodImpl(Inline)]
        public static ParseResult<AssemblyUri> Parse(string text)
            => from id in Enums.parse<PartId>(text) select AssemblyUri.Define(id);
                
        [MethodImpl(Inline)]
        public static AssemblyUri Define(PartId id)
            => new AssemblyUri(id);
     
        [MethodImpl(Inline)]
        AssemblyUri(PartId id)
        {
            this.Id = id;
            this.Identifier = id != 0 ? id.Format() : text.blank;
        }

        [MethodImpl(Inline)]
        public bool Equals(AssemblyUri src)
            => equals(this, src);

        [MethodImpl(Inline)]
        public int CompareTo(AssemblyUri other)
            => compare(this, other);
 
        public override int GetHashCode()
            => hash(this);

        public override bool Equals(object obj)
            => equals(this, obj);

        public override string ToString()
            => Identifier;        
    }
}