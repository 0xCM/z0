//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Collections.Generic;

    using static Root;

    /// <summary>
    /// Identifies/describes a type that declares a formalized api set
    /// </summary>
    public readonly struct ApiHost : IApiHost, IComparable<ApiHost>
    {
        [Op]
        public static Index<IApiHost> hosts(Assembly src)
        {
            var id = src.Id();
            return types(src).Select(h => host(id, h));
        }

        /// <summary>
        /// Describes an api host
        /// </summary>
        /// <param name="part">The defining part</param>
        /// <param name="type">The reifying type</param>
        [Op]
        public static IApiHost host(Type type)
            => host(type.Assembly.Id(), type);

        /// <summary>
        /// Describes an api host
        /// </summary>
        /// <param name="part">The defining part</param>
        /// <param name="t">The reifying type</param>
        [Op]
        static IApiHost host(PartId part, Type type)
        {
            var uri = ApiHostUri.from(type);
            var declared = type.DeclaredMethods();
            return new ApiHost(type, uri.HostName, part, uri, declared, index(declared));
        }

        /// <summary>
        /// Searches an assembly for types tagged with the <see cref="ApiHostAttribute"/>
        /// </summary>
        /// <param name="src">The assembly to search</param>
        [Op]
        static Index<Type> types(Assembly src)
            => src.GetTypes().Where(IsApiHost);

        [Op]
        static bool IsApiHost(Type src)
            => src.Tagged<ApiHostAttribute>();

        [Op]
        static Dictionary<string,MethodInfo> index(Index<MethodInfo> methods)
        {
            var index = new Dictionary<string, MethodInfo>();
            core.iter(methods, m => index.TryAdd(ApiIdentity.identify(m).IdentityText, m));
            return index;
        }

        public PartId PartId {get;}

        public Type HostType {get;}

        public Identifier HostName {get;}

        public ApiHostUri HostUri {get;}

        public Index<MethodInfo> Methods {get;}

        Dictionary<string,MethodInfo> Index {get;}

        [MethodImpl(Inline)]
        public ApiHost(Type type, string name, PartId part, ApiHostUri uri, MethodInfo[] methods, Dictionary<string,MethodInfo> index)
        {
            HostType = type;
            HostName = name;
            PartId = part;
            HostUri = uri;
            Methods = methods;
            Index = index;
        }

        public bool FindMethod(OpUri uri, out MethodInfo method)
            => Index.TryGetValue(uri.OpId.IdentityText, out method);

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => HostType == typeof(void);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => HostType != typeof(void);
        }

        [MethodImpl(Inline)]
        public string Format()
            => HostUri.Format();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(ApiHost src)
            => src.HostType.Equals(HostType);

        [MethodImpl(Inline)]
        public int CompareTo(ApiHost src)
            => ((long)src.HostType.TypeHandle.Value).CompareTo((long)HostType.TypeHandle.Value);

        public override int GetHashCode()
            => HostType.GetHashCode();

        public override bool Equals(object src)
            => src is ApiHost t && Equals(t);

        [MethodImpl(Inline)]
        public static implicit operator ApiHostUri(ApiHost src)
            => src.HostUri;

        [MethodImpl(Inline)]
        public static bool operator==(ApiHost a, ApiHost b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(ApiHost a, ApiHost b)
            => !a.Equals(b);

        public static ApiHost Empty
            => new ApiHost(typeof(void), EmptyString, 0, ApiHostUri.Empty, sys.empty<MethodInfo>(), new());
    }
}