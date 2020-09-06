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

    using static Konst;
    using static z;

    public readonly struct ApiDataType : IApiHost, IComparable<ApiDataType>
    {
        public static HashSet<string> Ignore
            => hashset("ToString","GetHashCode", "Equals", "ToString");

        public PartId PartId {get;}

        public Type HostType {get;}

        public string Name {get;}

        public ApiHostUri Uri {get;}

        [MethodImpl(Inline)]
        public static implicit operator ApiHostUri(ApiDataType src)
            => src.Uri;

        [MethodImpl(Inline)]
        public static bool operator==(ApiDataType a, ApiDataType b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(ApiDataType a, ApiDataType b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public ApiDataType(Type type, string name, PartId part, ApiHostUri uri)
        {
            HostType = type;
            Name = name;
            PartId = part;
            Uri = uri;
        }

        public MethodInfo[] Methods
            => HostType.DeclaredMethods();

        [MethodImpl(Inline)]
        public string Format()
            => Uri.Format();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(ApiDataType src)
            => src.HostType.Equals(HostType);

        [MethodImpl(Inline)]
        public int CompareTo(ApiDataType src)
            => ((long)src.HostType.TypeHandle.Value).CompareTo((long)HostType.TypeHandle.Value);

        public override int GetHashCode()
            => HostType.GetHashCode();

        public override bool Equals(object src)
            => src is ApiDataType t && Equals(t);
    }
}