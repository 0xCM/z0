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

    public readonly struct ApiHostUri : IUri<ApiHostUri>, INullary<ApiHostUri>
    {
        public static ApiHostUri Empty = new ApiHostUri(PartId.None, string.Empty);
        
        public readonly PartId Owner;

        public readonly string Name;        

        public string Identifier {get;}

        public FolderName HostFolder 
            => FolderName.Define(Name);

        public RelativeLocation HostLocation 
            => RelativeLocation.Define(FolderName.Define(Owner.Format()), HostFolder);
        
        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Owner.IsNone()  && text.empty(Name);
        }

        ApiHostUri INullary<ApiHostUri>.Zero => Empty;

        [MethodImpl(Inline)]
        static IParser<ApiHostUri> Parser()
            => default(ApiHostUri);
        
        [MethodImpl(Inline)]
        public static ParseResult<ApiHostUri> Parse(string text)
            => Parser().Parse(text);

        [MethodImpl(Inline)]
        public static ApiHostUri FromHost(Type host)
        {
            var tag = host.Tag<ApiHostAttribute>();
            var name = text.ifempty(tag.MapValueOrDefault(x => x.HostName), host.Name);
            var owner = host.Assembly.Id();
            return new ApiHostUri(owner, name);
        }
                
        [MethodImpl(Inline)]
        public static ApiHostUri Define(PartId owner, string name)
            => new ApiHostUri(owner,name);
     
        [MethodImpl(Inline)]
        public static implicit operator ApiHostUri(ApiHost src)
            => src.Path;

        [MethodImpl(Inline)]
        public static bool operator==(ApiHostUri a, ApiHostUri b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(ApiHostUri a, ApiHostUri b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        ApiHostUri(PartId owner, string name)
        {
            this.Owner = owner;
            this.Name = name;
            this.Identifier = owner != 0 ? $"{Owner.Format()}/{Name}" : name;
        }
 
        ParseResult<ApiHostUri> IParser<ApiHostUri>.Parse(string text)
        {
            var parts = text.Split('/');
            if(parts.Length == 2 && Enum.TryParse(parts[0], true, out PartId owner))
                return ParseResult.Success(text,Define(owner, parts[1]));
            else
                return ParseResult.Fail<ApiHostUri>(text);
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
    }
}