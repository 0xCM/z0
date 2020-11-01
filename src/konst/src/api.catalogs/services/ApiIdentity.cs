//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Reflection.Metadata.Ecma335;

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
        public static ArtifactKey operation(in ApiMetadataUri src)
            => new ArtifactKey(TableIndex.MethodDef, (ClrArtifactKey)vcell(src.Data, OpIndex));

        [MethodImpl(Inline), Op]
        public static ArtifactKey host(in ApiMetadataUri src)
            => new ArtifactKey(TableIndex.TypeDef, (ClrArtifactKey)vcell(src.Data, HostIndex));

        [MethodImpl(Inline), Op]
        public static ApiOpId kind(in ApiMetadataUri src)
            => (ApiOpId)vcell(src.Data, KeyIndex);

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
        public static ApiMetadataUri identify(Type src)
            => new ApiMetadataUri(vparts(w128, (uint)src.Assembly.Id(), (uint)src.MetadataToken, (uint)0, (uint)0));

        [MethodImpl(Inline), Op]
        public static ref ApiMetadataUri identify(MethodInfo src, out ApiMetadataUri dst)
        {
            dst = identify(src);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ApiMetadataUri host(PartId part, ClrArtifactKey host, ApiPartKindId kind, ClrArtifactKey method)
            => new ApiMetadataUri(vparts(w128, (uint)part, (uint)host, (uint)kind, (uint)method));

        [MethodImpl(Inline), Op]
        public static bool eq(in ApiMetadataUri a,in ApiMetadataUri b)
            => a.Data.Equals(b.Data);

        [MethodImpl(Inline), Op]
        public static string identifier(ApiOpId src)
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