//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;

    public readonly struct ApiRuntimeType : IApiHost, IComparable<ApiRuntimeType>
    {
        public PartId PartId {get;}

        public Type HostType {get;}

        public string Name {get;}

        public ApiHostUri Uri {get;}

        [MethodImpl(Inline)]
        public ApiRuntimeType(Type type, string name, PartId part, ApiHostUri uri)
        {
            HostType = type;
            Name = name;
            PartId = part;
            Uri = uri;
        }

        public Index<MethodInfo> Methods
            => HostType.DeclaredMethods();

        [MethodImpl(Inline)]
        public string Format()
            => Uri.Format();

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
            => src.Uri;

        [MethodImpl(Inline)]
        public static bool operator==(ApiRuntimeType a, ApiRuntimeType b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(ApiRuntimeType a, ApiRuntimeType b)
            => !a.Equals(b);
    }
}