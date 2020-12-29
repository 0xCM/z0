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
    using static z;

    [ApiHost(ApiNames.ApiIdentity, true)]
    public readonly struct ApiIdentity
    {
        public const string IdentifierPattern = "{0}_{1}_{2}_{3}";

        public const string UriPattern = "metadata://{0}/{1}/{2}/{3}";

        internal const byte PartIndex = 0;

        internal const byte HostIndex = 1;

        internal const byte KeyIndex = 2;

        internal const byte OpIndex = 3;

        public static FS.FileName file(ApiHostUri host, FS.FileExt ext)
            => FS.file(text.concat(host.Owner.Format(), Chars.Dot, host.Name), ext);

        public static FS.FileName file(ApiHostUri host, FS.FileExt a, FS.FileExt b)
            => FS.file(text.concat(host.Owner.Format(), Chars.Dot, host.Name, a), b);

        [MethodImpl(Inline), Op]
        public static OpUri uri(ApiUriScheme scheme, ApiHostUri host, string group, OpIdentity opid)
            => new OpUri(scheme, host, group, opid);

        [MethodImpl(Inline)]
        public static int compare<T>(in T a, in T b)
            where T : IIdentified
                => text.denullify(a.Identifier).CompareTo(b.Identifier);

        [MethodImpl(Inline)]
        public static bool equals<T>(in T a, object b)
            where T : IIdentified
                => text.equals(a.Identifier, b is T x ? x.Identifier : EmptyString, NoCase);

        [MethodImpl(Inline)]
        public static bool equals<T>(in T a, in T b)
            where T : IIdentified
                => text.equals(a.Identifier, b.Identifier, NoCase);

        [MethodImpl(Inline)]
        public static int hash<T>(in T src)
            where T : IIdentified
                => text.denullify(src.Identifier).GetHashCode();

        /// <summary>
        /// Defines the name of an api member predicated on a tag, if present, or the metadata-defined name if not
        /// </summary>
        /// <param name="m">The source method</param>
        public static string name(MethodInfo m)
        {
            var attrib = m.Tag<OpAttribute>();

            if(attrib.IsNone())
                return m.Name;
            else
            {
                var name = attrib.Value.GroupName;
                if(text.empty(name))
                    return m.Name;
                else
                    return name;
            }
        }

        [MethodImpl(Inline), Op]
        public static ApiClass kind(in ApiMetadataUri src)
            => (ApiClass)vcell(src.Data, KeyIndex);

        [MethodImpl(Inline), Op]
        public static PartId part(in ApiMetadataUri src)
            => (PartId)vcell(src.Data, PartIndex);

        /// <summary>
        /// Creates a <see cref='ApiMetadataUri'/> that identifies a specified method
        /// </summary>
        /// <param name="src">The source method</param>
        [MethodImpl(Inline), Op]
        public static ApiMetadataUri identify(MethodInfo src)
        {
            var host = src.DeclaringType;
            return new ApiMetadataUri(vparts(w128, (uint)host.Assembly.Id(), (uint)host.MetadataToken, (uint)src.KindId(), (uint)src.MetadataToken));
        }

        [MethodImpl(Inline), Op]
        public static bool eq(in ApiMetadataUri a,in ApiMetadataUri b)
            => a.Data.Equals(b.Data);

        [MethodImpl(Inline), Op]
        public static string identifier(ApiClass src)
            => string.Format("{0}", src != 0 ? src.Format() : "unkinded");

        [MethodImpl(Inline), Op]
        public static string identifier(PartId src)
            => src.Format();

        [Op]
        public static string identifier(in ApiMetadataUri src)
            => string.Format(IdentifierPattern, identifier(src.Part), identifier(src.KindKey), src.HostId, src.OperationId);

        [Op]
        public static string format(in ApiMetadataUri src)
            => string.Format(UriPattern, identifier(src.Part), identifier(src.KindKey), src.HostId, src.OperationId);
    }
}