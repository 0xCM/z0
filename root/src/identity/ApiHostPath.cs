//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static IdentityOps;

    public readonly struct ApiHostPath : IIdentity<ApiHostPath>, IParser<ApiHostPath>
    {
        public static ApiHostPath Empty = new ApiHostPath(AssemblyId.None, string.Empty);
        
        public readonly AssemblyId Owner;

        public readonly string Name;        

        public string Identifier {get;}

        public FolderName HostFolder 
            => FolderName.Define(Name);

        public RelativeLocation HostLocation 
            => RelativeLocation.Define(FolderName.Define(Owner.Format()), HostFolder);
        
        [MethodImpl(Inline)]
        static IParser<ApiHostPath> Parser()
            => default(ApiHostPath);
        
        [MethodImpl(Inline)]
        public static ParseResult<ApiHostPath> Parse(string text)
            => Parser().Parse(text);

        [MethodImpl(Inline)]
        public static ApiHostPath FromHost(Type host)
            => new ApiHostPath(host.Assembly.AssemblyId(), host.Name);
                
        [MethodImpl(Inline)]
        public static ApiHostPath Define(AssemblyId owner, string name)
            => new ApiHostPath(owner,name);
     
        [MethodImpl(Inline)]
        ApiHostPath(AssemblyId owner, string name)
        {
            this.Owner = owner;
            this.Name = name;
            this.Identifier = owner != 0 ? $"{Owner.Format()}/{Name}" : name;
        }

        [MethodImpl(Inline)]
        public bool Equals(ApiHostPath src)
            => equals(this, src);

        [MethodImpl(Inline)]
        public int CompareTo(ApiHostPath other)
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
            get => Owner == AssemblyId.None && string.IsNullOrWhiteSpace(Name);
        }

        ParseResult<ApiHostPath> IParser<ApiHostPath>.Parse(string text)
        {
            var parts = text.Split('/');
            if(parts.Length == 2 && Enum.TryParse(parts[0], true, out AssemblyId owner))
                return ParseResult.Success(Define(owner, parts[1]));
            else
                return ParseResult.Fail<ApiHostPath>();
        }
    }
}