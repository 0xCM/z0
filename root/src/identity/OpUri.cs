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
    using static IdentityCommons;
    
    public readonly struct OpUri : IEquatable<OpUri>, IComparable<OpUri>, IIdentity<OpUri>, IParser<OpUri>
    {
        public static OpUri Empty => new OpUri(OpUriScheme.None, ApiHostPath.Empty, string.Empty, OpIdentity.Empty);
        
        public readonly OpUriScheme Scheme;
        
        public readonly ApiHostPath HostPath;
        
        /// <summary>
        /// The name assigned to a group of methods; usually agrees with what is called a "method group" in clr-land
        /// The purpose of the group name is to classify/identify a related set of methods and, again, this typically
        /// corresponds to the "name" property on a method
        /// </summary>
        public readonly string GroupName;

        public readonly OpIdentity OpId;

        public string Identifier {get;}

        [MethodImpl(Inline)]
        static IParser<OpUri> Parser()
            => default(OpUri);
        
        [MethodImpl(Inline)]
        public static ParseResult<OpUri> Parse(string text)
            => Parser().Parse(text);

        [MethodImpl(Inline)]
        public static bool operator==(OpUri a, OpUri b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(OpUri a, OpUri b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public static OpUri Define(OpUriScheme scheme, ApiHostPath host, string group, OpIdentity opid)        
            => new OpUri(scheme, host, group, opid);

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
            this.GroupName = group;
            this.Identifier = 
                opid.IsEmpty 
                ? OpUriOps.QueryText(scheme, host.Owner, host.Name, group) 
                : OpUriOps.FullUriText(scheme, host.Owner, host.Name, GroupName, opid);
        }

        public OpUri GroupUri
            => new OpUri(Scheme, HostPath, GroupName, OpIdentity.Empty);

        public string Format()
            => IdentityFormat(this);
        
        [MethodImpl(Inline)]
        public int CompareTo(OpUri other)
            => IdentityCompare(this, other);

        [MethodImpl(Inline)]
        public bool Equals(OpUri src)
            => IdentityEquals(this, src);

        public override int GetHashCode()
            => IdentityHashCode(this);

        public override bool Equals(object obj)
            => IdentityEquals(this, obj);

        public override string ToString()
            => Format();
        
        ParseResult<OpUri> IParser<OpUri>.Parse(string text)
            => OpUriOps.ParseUri(text);
    }
}