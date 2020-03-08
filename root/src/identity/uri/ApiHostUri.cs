//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static IdentityShare;

    public readonly struct ApiHostUri : IUri<ApiHostUri>
    {
        public static ApiHostUri Empty = new ApiHostUri(AssemblyId.None, string.Empty);
        
        public readonly AssemblyId Owner;

        public readonly string Name;        

        public string Identifier {get;}

        public FolderName HostFolder 
            => FolderName.Define(Name);

        public RelativeLocation HostLocation 
            => RelativeLocation.Define(FolderName.Define(Owner.Format()), HostFolder);
        
        [MethodImpl(Inline)]
        static IParser<ApiHostUri> Parser()
            => default(ApiHostUri);
        
        [MethodImpl(Inline)]
        public static ParseResult<ApiHostUri> Parse(string text)
            => Parser().Parse(text);

        [MethodImpl(Inline)]
        public static ApiHostUri FromHost(Type host)
            => new ApiHostUri(host.Assembly.AssemblyId(), host.Name);
                
        [MethodImpl(Inline)]
        public static ApiHostUri Define(AssemblyId owner, string name)
            => new ApiHostUri(owner,name);
     
        [MethodImpl(Inline)]
        public static implicit operator ApiHostUri(ApiHost src)
            => src.Path;
        
        [MethodImpl(Inline)]
        ApiHostUri(AssemblyId owner, string name)
        {
            this.Owner = owner;
            this.Name = name;
            this.Identifier = owner != 0 ? $"{Owner.Format()}/{Name}" : name;
        }

        public string Format()
            => Identifier;

        [MethodImpl(Inline)]
        public bool Equals(ApiHostUri src)
            => equals(this, src);

        [MethodImpl(Inline)]
        public int CompareTo(ApiHostUri other)
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
            get => Owner.IsNone()  && text.empty(Name);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }

        ParseResult<ApiHostUri> IParser<ApiHostUri>.Parse(string text)
        {
            var parts = text.Split('/');
            if(parts.Length == 2 && Enum.TryParse(parts[0], true, out AssemblyId owner))
                return ParseResult.Success(Define(owner, parts[1]));
            else
                return ParseResult.Fail<ApiHostUri>();
        }
    }
}