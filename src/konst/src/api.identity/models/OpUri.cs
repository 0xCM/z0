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
    using static ApiUriDelimiters;

    using api = ApiIdentify;

    public readonly struct OpUri : IApiUri<OpUri>, INullary<OpUri>
    {
        /// <summary>
        /// The full uri in the form {scheme}://{hostpath}/{opid}
        /// </summary>
        public string UriText {get;}

        /// <summary>
        /// The uri scheme, constrained to the defining enumeration
        /// </summary>
        public readonly ApiUriScheme Scheme;

        /// <summary>
        /// The host fragment, of the form {assembly_short_name}/{hostname}
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
            get => Scheme == 0 && Host.IsEmpty && text.blank(GroupName) && OpId.IsEmpty;
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
            => WithScheme(ApiUriScheme.Located);

        public OpUri Hex
            => WithScheme(ApiUriScheme.Hex);

        OpUri INullary<OpUri>.Zero
            => Empty;

        [MethodImpl(Inline)]
        public static bool operator==(OpUri a, OpUri b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(OpUri a, OpUri b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public static OpUri Define(ApiUriScheme scheme, ApiHostUri host, string group, OpIdentity opid)
            => new OpUri(scheme, host, group, opid);

        [MethodImpl(Inline)]
        public static OpUri hex(ApiHostUri host, string group, OpIdentity opid)
            => new OpUri(ApiUriScheme.Hex, host, group, opid);

        [MethodImpl(Inline)]
        public static OpUri hex(OpIdentity opid, MethodInfo src)
            => new OpUri(ApiUriScheme.Hex, ApiQuery.uri(src.DeclaringType), src.Name, opid);

        [MethodImpl(Inline)]
        public static OpUri located(OpIdentity opid, MethodInfo src)
            => new OpUri(ApiUriScheme.Located, ApiQuery.uri(src.DeclaringType), src.Name, opid);

        [MethodImpl(Inline)]
        public static OpUri asm(ApiHostUri host, string group)
            => new OpUri(ApiUriScheme.Asm, host, group, OpIdentity.Empty);

        [MethodImpl(Inline)]
        public static OpUri asm(ApiHostUri host, string group, OpIdentity opid)
            => new OpUri(ApiUriScheme.Asm, host, group, opid);

        [MethodImpl(Inline)]
        public static OpUri asm(OpIdentity opid, MethodInfo src)
            => new OpUri(ApiUriScheme.Asm, ApiQuery.uri(src.DeclaringType), src.Name, opid);

        [MethodImpl(Inline)]
        OpUri(ApiUriScheme scheme, ApiHostUri host, string group, OpIdentity opid)
        {
            Scheme = scheme;
            Host = host;
            OpId = opid;
            GroupName = group;
            UriText = (opid.IsEmpty
                ? QueryText(scheme, host.Owner, host.Name, group)
                : FullUriText(scheme, host.Owner, host.Name, GroupName, opid)).Trim();
        }


        [MethodImpl(Inline)]
        public string Format()
            => UriText;

        public OpUri WithScheme(ApiUriScheme scheme)
            => Define(scheme, Host, GroupName, OpId);

        [MethodImpl(Inline)]
        public int CompareTo(OpUri other)
            => api.compare(this, other);

        [MethodImpl(Inline)]
        public bool Equals(OpUri src)
            => api.equals(this, src);

        public override int GetHashCode()
            => api.hash(this);

        public override bool Equals(object obj)
            => api.equals(this, obj);

        public override string ToString()
            => Format();

        /// <summary>
        /// Emptiness of nothing
        /// </summary>
        public static OpUri Empty
            => new OpUri(ApiUriScheme.None, ApiHostUri.Empty, string.Empty, OpIdentity.Empty);

        static string QueryText(ApiUriScheme scheme, PartId catalog, string host, string group)
            => $"{scheme.ToString().ToLower()}{UriEndOfScheme}{catalog.Format()}{UriPathSep}{host}{UriQuery}{group}";

        static string FullUriText(ApiUriScheme scheme, PartId catalog, string host, string group, OpIdentity opid)
            => $"{scheme.ToString().ToLower()}{UriEndOfScheme}{catalog.Format()}{UriPathSep}{host}{UriQuery}{group}{UriFragment}{opid.Identifier}";
    }
}