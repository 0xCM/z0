//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct OpUri : IApiUri<OpUri>
    {
        /// <summary>
        /// The full uri in the form {scheme}://{hostpath}/{opid}
        /// </summary>
        public string UriText {get;}

        /// <summary>
        /// The uri scheme, constrained to the defining enumeration
        /// </summary>
        public ApiUriScheme Scheme {get;}

        /// <summary>
        /// The host fragment, of the form {assembly_short_name}/{hostname}
        /// </summary>
        public ApiHostUri Host {get;}

        /// <summary>
        /// The name assigned to a group of methods; usually agrees with what is called a "method group" in clr-land
        /// The purpose of the group name is to classify/identify a related set of methods and, again, this typically
        /// corresponds to the "name" property on a method
        /// </summary>
        public string GroupName {get;}

        /// <summary>
        /// Defines host-relative identity in the form, for example, {opname}_{typewidth}X{segwidth}{u | i | f}
        /// </summary>
        public OpIdentity OpId {get;}

        /// <summary>
        /// The defining part
        /// </summary>
        public PartId Part
            => Host.Owner;

        [MethodImpl(Inline)]
        public OpUri(ApiUriScheme scheme, ApiHostUri host, string group, OpIdentity opid)
        {
            Scheme = scheme;
            Host = host;
            OpId = opid;
            GroupName = group;
            UriText = ApiUri.BuildUriText(scheme, host, group, opid);
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Scheme == 0 && Host.IsEmpty && text.blank(GroupName) && OpId.IsEmpty;
        }

        [MethodImpl(Inline)]
        public string Format()
            => UriText;

        public OpUri WithScheme(ApiUriScheme scheme)
            => new OpUri(scheme, Host, GroupName, OpId);

        [MethodImpl(Inline)]
        public int CompareTo(OpUri src)
            => text.denullify(UriText).CompareTo(src.UriText);

        [MethodImpl(Inline)]
        public bool Equals(OpUri src)
            => text.denullify(UriText).Equals(src.UriText, NoCase);

        public override int GetHashCode()
            => UriText?.GetHashCode() ?? 0;

        public override bool Equals(object src)
            => src is OpUri a && Equals(a);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static bool operator==(OpUri a, OpUri b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(OpUri a, OpUri b)
            => !a.Equals(b);

        /// <summary>
        /// Emptiness of nothing
        /// </summary>
        public static OpUri Empty
            => new OpUri(ApiUriScheme.None, ApiHostUri.Empty, string.Empty, OpIdentity.Empty);
    }
}