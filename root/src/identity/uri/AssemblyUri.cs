//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Linq;

    using static Root;
    using static IdentityShare;

    public readonly struct AssemblyUri : IUri<AssemblyUri>
    {
        public static AssemblyUri Empty = new AssemblyUri(AssemblyId.None);
        
        public readonly AssemblyId Id;

        public string Identifier {get;}

        public FolderName RootFolder
            => FolderName.Define(Id.Format());
        
        [MethodImpl(Inline)]
        static IParser<AssemblyUri> Parser()
            => default(AssemblyUri);
        
        [MethodImpl(Inline)]
        public static ParseResult<AssemblyUri> Parse(string text)
            => Parser().Parse(text);
                
        [MethodImpl(Inline)]
        public static AssemblyUri Define(AssemblyId id)
            => new AssemblyUri(id);
     
        [MethodImpl(Inline)]
        AssemblyUri(AssemblyId id)
        {
            this.Id = id;
            this.Identifier = id.IsSome() ? id.Format() : text.blank;
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
        
        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Id == AssemblyId.None || string.IsNullOrWhiteSpace(Identifier);
        }

        ParseResult<AssemblyUri> IParser<AssemblyUri>.Parse(string text)
            => from id in Enums.parse<AssemblyId>(text) select AssemblyUri.Define(id);
    }
}