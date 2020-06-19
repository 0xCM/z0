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
        public string Name {get;}

        public ApiHostKind HostKind {get;}

        public PartId PartId {get;}

        public ApiHostUri Uri {get;}
        
        public Type HostType {get;}
    
        [MethodImpl(Inline)]
        public static implicit operator ApiHostUri(ApiHost src)
            => src.Uri;

        [MethodImpl(Inline)]
        public static bool operator==(ApiHost a, ApiHost b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(ApiHost a, ApiHost b)
            => !a.Equals(b);

        public ApiHost(string name, ApiHostKind kind, PartId part, ApiHostUri uri, Type type)
        {
            Name = name;
            HostKind = kind;
            PartId = part;
            Uri = uri;
            HostType = type;
        }
                                  
        public IEnumerable<MethodInfo> HostedMethods
            => HostType.DeclaredMethods(false);

        public bool IsEmtpy 
        {
            [MethodImpl(Inline)]
            get => PartId == PartId.None && HostType == typeof(void);
        }

        [MethodImpl(Inline)]
        public string Format()
            => Uri.Format();

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

        public static ApiHost Empty 
            => new ApiHost(EmptyString, 0, 0, ApiHostUri.Empty, typeof(void));
    }
}