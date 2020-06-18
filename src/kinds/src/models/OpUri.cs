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
    using static IdentityShare;
    
    public readonly struct OpUri : IUri<OpUri>, INullary<OpUri>
    {
        /// <summary>
        /// The full uri in the form {Scheme}://{HostPath}/{OpId}
        /// </summary>
        public string UriText {get;}
        
        /// <summary>
        /// The uri scheme, constrained to the defining enumeration
        /// </summary>
        public readonly OpUriScheme Scheme;
        
        /// <summary>
        /// The host fragment, of the form {assmblyid}/{hostname}
        /// </summary>
        public readonly ApiHostUri Host;
        
        /// <summary>
        /// The name assigned to a group of methods; usually agrees with what is called a "method group" in clr-land
        /// The purpose of the group name is to classify/identify a related set of methods and, again, this typically
        /// corresponds to the "name" property on a method
        /// </summary>
        public readonly string GroupName;

        /// <summary>
        /// Defines host-relative identity in the form, for example, {opname}_{typewidth}X{segwidth}{u | i | f}
        /// </summary>
        public readonly OpIdentity OpId;

        /// <summary>
        /// The defining part
        /// </summary>
        public PartId Part 
            => Host.Owner;
        
        public bool IsEmpty
        {
            [MethodImpl(Inline)]            
            get => Scheme == 0 && Host.IsEmpty && text.empty(GroupName) && OpId.IsEmpty;
        }
        
        public bool IsComplete
        {
            [MethodImpl(Inline)]
            get => Scheme != 0 && !Host.IsEmpty && text.nonempty(GroupName) && !OpId.IsEmpty;
        }

        public OpUri GroupUri
        {
            [MethodImpl(Inline)]
            get => new OpUri(Scheme, Host, GroupName, OpIdentity.Empty);
        }

        public OpUri Loc 
            => WithScheme(OpUriScheme.Located);

        public OpUri Hex 
            => WithScheme(OpUriScheme.Hex);

        [MethodImpl(Inline)]
        public static ParseResult<OpUri> Parse(string text)
            => OpUriParser.The.Parse(text);            

        [MethodImpl(Inline)]
        public static OpUri ParseDefault(string text, OpUri failed = default)
            => OpUriParser.The.Parse(text).ValueOrDefault(failed);            

        OpUri INullary<OpUri>.Zero 
            => Empty;
            
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
        public static OpUri hex(ApiHostUri host, string group)        
            => new OpUri(OpUriScheme.Hex, host, group, OpIdentity.Empty);

        [MethodImpl(Inline)]
        public static OpUri hex(ApiHostUri host, string group, OpIdentity opid)        
            => new OpUri(OpUriScheme.Hex, host, group, opid);

        [MethodImpl(Inline)]
        public static OpUri hex(OpIdentity opid, MethodInfo src)        
            => new OpUri(OpUriScheme.Hex, ApiHostUri.FromHost(src.DeclaringType), src.Name, opid);

        [MethodImpl(Inline)]
        public static OpUri asm(ApiHostUri host, string group)        
            => new OpUri(OpUriScheme.Asm, host, group, OpIdentity.Empty);

        [MethodImpl(Inline)]
        public static OpUri asm(ApiHostUri host, string group, OpIdentity opid)        
            => new OpUri(OpUriScheme.Asm, host, group, opid);

        [MethodImpl(Inline)]
        public static OpUri asm(OpIdentity opid, MethodInfo src)        
            => new OpUri(OpUriScheme.Asm, ApiHostUri.FromHost(src.DeclaringType), src.Name, opid);

        [MethodImpl(Inline)]
        OpUri(OpUriScheme scheme, ApiHostUri host, string group, OpIdentity opid)
        {
            this.Scheme = scheme;
            this.Host = host;
            this.OpId = opid;
            this.GroupName = group;
            UriText = 
                opid.IsEmpty 
                ? OpUriBuilder.QueryText(scheme, host.Owner, host.Name, group) 
                : OpUriBuilder.FullUriText(scheme, host.Owner, host.Name, GroupName, opid);
        }

        [MethodImpl(Inline)]
        public string Format()
            => UriText;
        
        public OpUri WithScheme(OpUriScheme scheme)
            => Define(scheme, Host, GroupName, OpId);
            
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

        /// <summary>
        /// Emptiness of nothing
        /// </summary>
        public static OpUri Empty 
            => new OpUri(OpUriScheme.None, ApiHostUri.Empty, string.Empty, OpIdentity.Empty);
    }
}