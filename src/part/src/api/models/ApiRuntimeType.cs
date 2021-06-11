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
    using static core;

    public class ApiRuntimeType : IApiHost, IComparable<ApiRuntimeType>
    {
        /// <summary>
        /// Searches an assembly for types tagged with the <see cref="ApiCompleteAttribute"/>
        /// </summary>
        /// <param name="src">The assembly to search</param>
        [Op]
        public static Index<ApiRuntimeType> complete(Assembly src)
        {
            var part = src.Id();
            var types = span(src.GetTypes().Where(t => t.Tagged<ApiCompleteAttribute>()));
            var count = types.Length;
            var buffer = alloc<ApiRuntimeType>(count);
            ref var dst = ref first(buffer);
            for(var i=0u; i<count; i++)
            {
                ref readonly var type = ref skip(types,i);
                var attrib = type.Tag<ApiCompleteAttribute>();
                var name =  text.ifempty(attrib.MapValueOrDefault(a => a.Name, type.Name),type.Name).ToLower();
                var uri = new ApiHostUri(part, name);
                var declared = type.DeclaredMethods();
                seek(dst, i) = new ApiRuntimeType(type, name, part, uri, declared, index(declared));
            }
            return buffer;
        }

        [Op]
        static Dictionary<string,MethodInfo> index(Index<MethodInfo> methods)
        {
            var index = new Dictionary<string, MethodInfo>();
            core.iter(methods, m => index.TryAdd(ApiIdentity.identify(m).IdentityText, m));
            return index;
        }

        public PartId PartId {get;}

        public Type HostType {get;}

        public Index<MethodInfo> Methods {get;}

        public string Name {get;}

        public ApiHostUri HostUri {get;}

        Dictionary<string,MethodInfo> Index {get;}

        [MethodImpl(Inline)]
        public ApiRuntimeType(Type type, string name, PartId part, ApiHostUri uri, Index<MethodInfo> methods, Dictionary<string,MethodInfo> index)
        {
            HostType = type;
            Name = name;
            PartId = part;
            HostUri = uri;
            Methods = methods;
            Index = index;
        }

        public bool FindMethod(OpUri uri, out MethodInfo method)
            => Index.TryGetValue(uri.OpId.IdentityText, out method);

        [MethodImpl(Inline)]
        public string Format()
            => HostUri.Format();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(ApiRuntimeType src)
            => src.HostType.Equals(HostType);

        [MethodImpl(Inline)]
        public int CompareTo(ApiRuntimeType src)
            => ((long)src.HostType.TypeHandle.Value).CompareTo((long)HostType.TypeHandle.Value);

        public override int GetHashCode()
            => HostType.GetHashCode();

        public override bool Equals(object src)
            => src is ApiRuntimeType t && Equals(t);

        [MethodImpl(Inline)]
        public static implicit operator ApiHostUri(ApiRuntimeType src)
            => src.HostUri;

        [MethodImpl(Inline)]
        public static bool operator==(ApiRuntimeType a, ApiRuntimeType b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(ApiRuntimeType a, ApiRuntimeType b)
            => !a.Equals(b);
    }
}