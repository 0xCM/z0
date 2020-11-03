//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    /// <summary>
    /// Identifies/describes a type that declares a formalized api set
    /// </summary>
    public readonly struct ApiHost : IApiHost
    {
        public PartId PartId {get;}

        public Type HostType {get;}

        public string Name {get;}

        public ApiHostUri Uri {get;}

        public MethodInfo[] DeclaredMethods {get;}

        [MethodImpl(Inline)]
        public ApiHost(Type type, string name, PartId part, ApiHostUri uri)
        {
            Name = name;
            HostType = type;
            PartId = part;
            Uri = uri;
            DeclaredMethods = HostType.DeclaredMethods();
        }

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
            => Uri.Format();

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
            => src.Uri;

        [MethodImpl(Inline)]
        public static bool operator==(ApiHost a, ApiHost b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(ApiHost a, ApiHost b)
            => !a.Equals(b);

        public static ApiHost Empty
            => new ApiHost(EmptyType, EmptyString, 0, ApiHostUri.Empty);
    }
}