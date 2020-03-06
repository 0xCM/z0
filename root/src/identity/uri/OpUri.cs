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
    using static IdentityShare;
    
    public readonly struct OpUri : IUri<OpUri>
    {
        public static OpUri Empty => new OpUri(OpUriScheme.None, ApiHostUri.Empty, string.Empty, OpIdentity.Empty);
        
        public readonly OpUriScheme Scheme;
        
        public readonly ApiHostUri HostPath;
        
        /// <summary>
        /// The name assigned to a group of methods; usually agrees with what is called a "method group" in clr-land
        /// The purpose of the group name is to classify/identify a related set of methods and, again, this typically
        /// corresponds to the "name" property on a method
        /// </summary>
        public readonly string GroupName;

        public readonly OpIdentity OpId;

        public string Identifier {get;}

        public bool IsEmpty
        {
            get => Scheme.IsNone() && HostPath.IsEmpty && text.empty(GroupName) && OpId.IsEmpty;
        }
        
        public bool IsComplete
        {
            get => Scheme.IsSome() && !HostPath.IsEmpty && text.nonempty(GroupName) && OpId.IsNonEmpty;
        }

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
        public static OpUri Define(OpUriScheme scheme, ApiHostUri host, string group, OpIdentity opid)        
            => new OpUri(scheme, host, group, opid);

        [MethodImpl(Inline)]
        public static OpUri Hex(ApiHostUri host, string group)        
            => new OpUri(OpUriScheme.Hex, host, group, OpIdentity.Empty);

        [MethodImpl(Inline)]
        public static OpUri Hex(ApiHostUri host, string group, OpIdentity opid)        
            => new OpUri(OpUriScheme.Hex, host, group, opid);

        [MethodImpl(Inline)]
        public static OpUri Hex(OpIdentity opid, MethodInfo src)        
            => new OpUri(OpUriScheme.Hex, ApiHostUri.FromHost(src.DeclaringType), src.Name, opid);

        [MethodImpl(Inline)]
        public static OpUri Asm(ApiHostUri host, string group)        
            => new OpUri(OpUriScheme.Asm, host, group, OpIdentity.Empty);

        [MethodImpl(Inline)]
        public static OpUri Asm(ApiHostUri host, string group, OpIdentity opid)        
            => new OpUri(OpUriScheme.Asm, host, group, opid);

        [MethodImpl(Inline)]
        public static OpUri Asm(OpIdentity opid, MethodInfo src)        
            => new OpUri(OpUriScheme.Asm, ApiHostUri.FromHost(src.DeclaringType), src.Name, opid);

        [MethodImpl(Inline)]
        OpUri(OpUriScheme scheme, ApiHostUri host, string group, OpIdentity opid)
        {
            this.Scheme = scheme;
            this.HostPath = host;
            this.OpId = opid;
            this.GroupName = group;
            this.Identifier = 
                opid.IsEmpty 
                ? OpUriBuilder.QueryText(scheme, host.Owner, host.Name, group) 
                : OpUriBuilder.FullUriText(scheme, host.Owner, host.Name, GroupName, opid);
        }

        public OpUri GroupUri
            => new OpUri(Scheme, HostPath, GroupName, OpIdentity.Empty);

        public string Format()
            => IdentityShare.format(this);
        
        [MethodImpl(Inline)]
        public int CompareTo(OpUri other)
            => compare(this, other);

        [MethodImpl(Inline)]
        public bool Equals(OpUri src)
            => equals(this, src);

        public override int GetHashCode()
            => hash(this);

        public override bool Equals(object obj)
            => equals(this, obj);

        public override string ToString()
            => Format();
        
        ParseResult<OpUri> IParser<OpUri>.Parse(string text)
            => OpUriParser.The.Parse(text);            
    }
}