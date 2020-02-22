//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Root;    

    public readonly struct ApiHost : IApiHostIdentity<ApiHost>
    {
        public string Name {get;}

        public readonly AssemblyId Owner;

        public ApiHostPath Path {get;}

        public string Identifier {get;}            
        
        public readonly Type HostingType;

        public static ApiHost Empty = new ApiHost(AssemblyId.None, typeof(void));
        
        [MethodImpl(Inline)]
        public static ApiHost Define(Type src)
            => new ApiHost(src.Assembly.AssemblyId(), src);

        [MethodImpl(Inline)]
        public static ApiHost Define(AssemblyId owner, Type src)
            => new ApiHost(owner, src);

        [MethodImpl(Inline)]
        public static IEnumerable<ApiHost> Define(AssemblyId owner, params Type[] src)
            => src.Select(t => Define(owner, t));

        [MethodImpl(Inline)]
        public static bool operator==(ApiHost a, ApiHost b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(ApiHost a, ApiHost b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        ApiHost(AssemblyId id, Type t)
        {
            this.Owner = id;
            this.HostingType = t;
            var name =  t.GetCustomAttribute<ApiHostAttribute>()?.Name;
            Name = string.IsNullOrEmpty(name) ? t.Name : name;
            this.Path = ApiHostPath.Define(Owner, HostingType.Name);
            this.Identifier = Path.Format();
        }
        
        public IEnumerable<MethodInfo> DeclaredMethods
            => HostingType.DeclaredMethods(false);

        public bool IsEmtpy 
            => Owner == AssemblyId.None && HostingType == typeof(void);

        public override string ToString() 
            => Identifier;

        [MethodImpl(Inline)]
        public bool Equals(ApiHost src)
            => IdentityEquals(this, src);

        [MethodImpl(Inline)]
        public int CompareTo(IIdentity other)
            => IdentityCompare(this, other);

        public override int GetHashCode()
            => IdentityHashCode(this);

        public override bool Equals(object obj)
            => IdentityEquals(this, obj);
    }
}