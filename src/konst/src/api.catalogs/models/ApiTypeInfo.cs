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

    using static Part;

    public readonly struct ApiTypeInfo : IApiHost, IComparable<ApiTypeInfo>
    {
        public static HashSet<string> Ignore
            => root.hashset("ToString","GetHashCode", "Equals", "ToString");

        public PartId PartId {get;}

        public Type HostType {get;}

        public string Name {get;}

        public ApiHostUri Uri {get;}

        public bool IsDataType => true;

        [MethodImpl(Inline)]
        public ApiTypeInfo(Type type, string name, PartId part, ApiHostUri uri)
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
        public bool Equals(ApiTypeInfo src)
            => src.HostType.Equals(HostType);

        [MethodImpl(Inline)]
        public int CompareTo(ApiTypeInfo src)
            => ((long)src.HostType.TypeHandle.Value).CompareTo((long)HostType.TypeHandle.Value);

        public override int GetHashCode()
            => HostType.GetHashCode();

        public override bool Equals(object src)
            => src is ApiTypeInfo t && Equals(t);

        [MethodImpl(Inline)]
        public static implicit operator ApiHostUri(ApiTypeInfo src)
            => src.Uri;

        [MethodImpl(Inline)]
        public static bool operator==(ApiTypeInfo a, ApiTypeInfo b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(ApiTypeInfo a, ApiTypeInfo b)
            => !a.Equals(b);

    }
}