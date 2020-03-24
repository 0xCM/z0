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
    using static IdentityShare;

    /// <summary>
    /// Identifies/describes a type that declares a formalized api set
    /// </summary>
    public readonly struct ApiHost : IIdentifiedTarget<ApiHost>
    {        
        public string HostName {get;}

        public string Identifier {get;}            

        public ApiHostKind HostKind {get;}

        public PartId Owner {get;}

        public ApiHostUri Path {get;}
        
        public Type HostingType {get;}

        public static ApiHost Empty = new ApiHost(PartId.None, typeof(void));
        
        /// <summary>
        /// Searches an assembly for api host types
        /// </summary>
        /// <param name="src">The assembly to search</param>
        public static IEnumerable<Type> HostTypes(Assembly src)
            => src.GetTypes().Tagged<ApiHostAttribute>();

        /// <summary>
        /// Instantiates the api hosts found in a specified assembly
        /// </summary>
        /// <param name="src">The assembly to search</param>
        public static IEnumerable<ApiHost> Hosts(Assembly src)
            => HostTypes(src).Select(FromType);

        [MethodImpl(Inline)]
        public static ApiHost FromType(Type src)
        {
            var owner = src.Assembly.Id();            
            return new ApiHost(owner, src);
        }

        [MethodImpl(Inline)]
        public static ApiHost Define(PartId owner, Type src)
        {
            return new ApiHost(owner, src);
        }

        [MethodImpl(Inline)]
        public static bool operator==(ApiHost a, ApiHost b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(ApiHost a, ApiHost b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        ApiHost(PartId id, Type t)
        {
            this.Owner = id;
            this.HostingType = t;
            var attrib = t.GetCustomAttribute<ApiHostAttribute>();
            this.HostKind = attrib?.HostKind ?? ApiHostKind.DirectAndGeneric;
            this.HostName = text.ifempty(attrib?.HostName, t.Name).ToLower();
            this.Path = ApiHostUri.Define(Owner, HostName);
            this.Identifier = Path.Format();
        }
                                  
        public IEnumerable<MethodInfo> DeclaredMethods
            => HostingType.DeclaredMethods(false);

        public bool IsEmtpy 
            => Owner == PartId.None && HostingType == typeof(void);

        public string Format()
            => Identifier;

        public override string ToString() 
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(ApiHost src)
            => equals(this, src);

        [MethodImpl(Inline)]
        public int CompareTo(ApiHost other)
            => compare(this, other);

        public override int GetHashCode()
            => hash(this);

        public override bool Equals(object obj)
            => equals(this, obj);
    }
}