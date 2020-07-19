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

    public readonly struct ApiDataType : IApiHost
    {
        public string Name {get;}

        public PartId PartId {get;}

        public ApiHostUri Uri {get;}
        
        public Type HostType {get;}

        [MethodImpl(Inline)]
        public static implicit operator ApiHostUri(ApiDataType src)
            => src.Uri;
            
        public ApiDataType(string name, PartId part, ApiHostUri uri, Type type)
        {
            Name = name;
            PartId = part;
            Uri = uri;
            HostType = type;
        }

        public MethodInfo[] HostedMethods
        {
            [MethodImpl(Inline)]
            get => HostType.DeclaredMethods(false);
        }

        public bool IsEmtpy 
        {
            [MethodImpl(Inline)]
            get => HostType == typeof(void);
        }

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