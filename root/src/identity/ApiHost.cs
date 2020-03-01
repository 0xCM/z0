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

    /// <summary>
    /// Identifies/describes a type that declares a formalized api set
    /// </summary>
    public readonly struct ApiHost : IApiHostIdentity<ApiHost>
    {        
        public string HostName {get;}

        public string Identifier {get;}            

        public ApiHostKind HostKind {get;}

        public AssemblyId Owner {get;}

        public ApiHostPath Path {get;}
        
        public Type HostingType {get;}

        public static ApiHost Empty = new ApiHost(AssemblyId.None, typeof(void));
        
        /// <summary>
        /// Searches a source assembly for api host types as determined by attribution
        /// </summary>
        /// <param name="src">The assembly to search</param>
        public static IEnumerable<Type> HostTypes(Assembly src)
            => src.GetTypes().Tagged<ApiHostAttribute>();

        [MethodImpl(Inline)]
        public static ApiHost Define(Type src)
            => new ApiHost(src.Assembly.AssemblyId(), src);

        [MethodImpl(Inline)]
        public static ApiHost Define(AssemblyId owner, Type src)
            => new ApiHost(owner, src);

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
            var attrib = t.GetCustomAttribute<ApiHostAttribute>();
            this.HostKind = attrib?.HostKind ?? ApiHostKind.DirectAndGeneric;
            this.HostName = string.IsNullOrWhiteSpace(attrib?.HostName) ? t.Name : attrib.HostName;            
            this.Path = ApiHostPath.Define(Owner, HostName);
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
            => IdentityOps.equals(this, src);

        [MethodImpl(Inline)]
        public int CompareTo(ApiHost other)
            => IdentityOps.compare(this, other);

        public override int GetHashCode()
            => IdentityOps.hash(this);

        public override bool Equals(object obj)
            => IdentityOps.equals(this, obj);
    }
}