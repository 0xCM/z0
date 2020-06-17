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

    using static Konst;
    using static IdentityShare;

    /// <summary>
    /// Identifies/describes a type that declares a formalized api set
    /// </summary>
    public readonly struct ApiHost : IIdentification<ApiHost>, IApiHost
    {        
        /// <summary>
        /// Selects the host-attributed types from an assembly
        /// </summary>
        /// <param name="src">The source assembly</param>
        public static IEnumerable<Type> HostTypes(Assembly src)
            => src.GetTypes().Tagged<ApiHostAttribute>();

        /// <summary>
        /// Instantiates the api hosts defined in a .net assembly
        /// </summary>
        /// <param name="src">The assembly to search</param>
        public static IEnumerable<IApiHost> Hosts(Assembly src)
            => HostTypes(src).Select(h => ApiHost.Define(h.Assembly.Id(), h) as IApiHost);

        public static ApiHost Empty = new ApiHost(PartId.None, typeof(void));
    
        public string HostName {get;}

        public string IdentityText {get;}            

        public ApiHostKind HostKind {get;}

        public PartId Owner {get;}

        public ApiHostUri UriPath {get;}
        
        public Type HostingType {get;}

        [MethodImpl(Inline)]
        public static IApiHost<H> Create<H>()
            where H : IApiHost<H>, new()
                => new H();

        [MethodImpl(Inline)]
        public static ApiHostUri Uri<H>()
            where H : IApiHost<H>, new()
                => new H().UriPath;

        [MethodImpl(Inline)]
        public static ApiHost Define(PartId owner, Type src)
            => new ApiHost(owner, src);

        [MethodImpl(Inline)]
        public static implicit operator ApiHostUri(ApiHost src)
            => src.UriPath;

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
            this.UriPath = ApiHostUri.Define(Owner, HostName);
            this.IdentityText = UriPath.Format();
        }
                                  
        public IEnumerable<MethodInfo> HostedMethods
            => HostingType.DeclaredMethods(false);

        public bool IsEmtpy 
            => Owner == PartId.None && HostingType == typeof(void);

        public string Format()
            => IdentityText;

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