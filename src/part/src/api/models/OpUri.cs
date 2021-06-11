//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public class OpUri : IApiUri<OpUri>
    {
        /// <summary>
        /// The full uri in the form {scheme}://{hostpath}/{opid}
        /// </summary>
        public string UriText {get;}

        /// <summary>
        /// The host fragment, of the form {assembly_short_name}/{hostname}
        /// </summary>
        public ApiHostUri Host {get;}

        /// <summary>
        /// Defines host-relative identity in the form, for example, {opname}_{typewidth}X{segwidth}{u | i | f}
        /// </summary>
        public OpIdentity OpId {get;}

        OpUri()
        {
            UriText = EmptyString;
            Host = ApiHostUri.Empty;
            OpId = OpIdentity.Empty;
        }
        internal OpUri(in ApiHostUri host, in OpIdentity opid, string uritext)
        {
            Host = host;
            OpId = opid;
            UriText = Require.notnull(uritext);
        }

        /// <summary>
        /// The defining part
        /// </summary>
        public PartId Part
            => Host.Part;

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Host.IsEmpty && OpId.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }

        [MethodImpl(Inline)]
        public string Format()
            => UriText;

        public int CompareTo(OpUri src)
            => (UriText).CompareTo(src.UriText);

        public bool Equals(OpUri src)
            => (UriText).Equals(src.UriText, NoCase);

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
            => new OpUri();
    }
}