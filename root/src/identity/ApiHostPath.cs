//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static RootShare;

    [Parser]
    public readonly struct ApiHostPath : IIdentity<ApiHostPath>, IParser<ApiHostPath>
    {
        public readonly AssemblyId Owner;

        public readonly string Name;

        public string Identifier {get;}
        
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
            this.Identifier = $"{Owner.Format()}/{Name}";
        }

        [MethodImpl(Inline)]
        public bool Equals(ApiHostPath src)
             => IdentityEquals(this, src);

        [MethodImpl(Inline)]
        public int CompareTo(IIdentity other)
            => IdentityCompare(this, other);

        public override string ToString()
            => Identifier;
 
        public override int GetHashCode()
            => IdentityHashCode(this);

        public override bool Equals(object obj)
            => IdentityEquals(this, obj);
        
        ApiHostPath IParser<ApiHostPath>.Parse(string text)
        {
            var parts = text.Split('/');
            if(parts.Length == 2 && Enum.TryParse(text,true, out AssemblyId owner))
                return Define(owner, parts[1]);
            else
                return Define(AssemblyId.None, $"error/{text}");
        }
    }
}