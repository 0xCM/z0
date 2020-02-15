//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static RootShare;
    
    public readonly struct OpUri : IEquatable<OpUri>, IComparable<OpUri>, IIdentity<OpUri>, IParser<OpUri>
    {
        public readonly OpUriScheme Scheme;
        
        public readonly ApiHostPath HostPath;
        
        public readonly string Group;

        public readonly OpIdentity OpId;

        public string Identifier {get;}

        [MethodImpl(Inline)]
        public static bool operator==(OpUri a, OpUri b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(OpUri a, OpUri b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public static OpUri Hex(ApiHostPath host, string group)        
            => new OpUri(OpUriScheme.Hex, host, group, OpIdentity.Empty);

        [MethodImpl(Inline)]
        public static OpUri Hex(ApiHostPath host, string group, OpIdentity opid)        
            => new OpUri(OpUriScheme.Hex, host, group, opid);

        [MethodImpl(Inline)]
        public static OpUri Hex(OpIdentity opid, MethodInfo src)        
            => new OpUri(OpUriScheme.Hex, ApiHostPath.FromHost(src.DeclaringType), src.Name, opid);

        [MethodImpl(Inline)]
        public static OpUri Asm(ApiHostPath host, string group)        
            => new OpUri(OpUriScheme.Asm, host, group, OpIdentity.Empty);

        [MethodImpl(Inline)]
        public static OpUri Asm(ApiHostPath host, string group, OpIdentity opid)        
            => new OpUri(OpUriScheme.Asm, host, group, opid);

        [MethodImpl(Inline)]
        public static OpUri Asm(OpIdentity opid, MethodInfo src)        
            => new OpUri(OpUriScheme.Asm, ApiHostPath.FromHost(src.DeclaringType), src.Name, opid);

        [MethodImpl(Inline)]
        OpUri(OpUriScheme scheme, ApiHostPath host, string group, OpIdentity opid)
        {
            this.Scheme = scheme;
            this.HostPath = host;
            this.OpId = opid;
            this.Group = group;
            this.Identifier = 
                opid.IsEmpty 
                ? QueryText(scheme, host.Owner, host.Name,group) 
                : UriText(scheme, host.Owner, host.Name, Group, opid);
        }

        public OpUri GroupUri
            => new OpUri(Scheme, HostPath, Group, OpIdentity.Empty);

        public string Format()
            => Identifier;
        
        [MethodImpl(Inline)]
        public bool Equals(OpUri src)
            => IdentityEquals(this, src);

        public override string ToString()
            => Identifier;
 
        public override int GetHashCode()
            => IdentityHashCode(this);

        public override bool Equals(object obj)
            => IdentityEquals(this, obj);

        [MethodImpl(Inline)]
        public int CompareTo(OpUri other)
            => IdentityCompare(this, other);

        [MethodImpl(Inline)]
        public int CompareTo(IIdentity other)
            => IdentityCompare(this, other);

        [MethodImpl(Inline)]
        static string PathText(string scheme, AssemblyId catalog, string subject)
            => $"{scheme}://{catalog.Format()}/{subject}";

        [MethodImpl(Inline)]
        static string QueryText(OpUriScheme scheme, AssemblyId catalog, string subject, string group)
            => $"{scheme.Format()}://{catalog.Format()}/{subject}?{group}";

        [MethodImpl(Inline)]
        static string UriText(OpUriScheme scheme, AssemblyId catalog, string subject, string group, OpIdentity opid)
            => $"{scheme.Format()}://{catalog.Format()}/{subject}?{group}#{opid.Identifier}";

        OpUri IParser<OpUri>.Parse(string text)
        {
            return default;
        }
    }
}