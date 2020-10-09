//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;

    using static Konst;
    using static z;

    [ApiHost(ApiNames.ApiIdentity, true)]
    public readonly struct ApiIdentity
    {
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
        public static ApiMetadataUri identify(MethodInfo src)
        {
            var host = src.DeclaringType;
            var dst = vparts(w128, (uint)host.Assembly.Id(), (uint)src.KindId(), (uint)host.MetadataToken, (uint)src.MetadataToken);
            return new ApiMetadataUri(dst);
        }

        [MethodImpl(Inline), Op]
        public static ApiMetadataUri identify(PartId part, ApiPartKindId kind, ClrArtifactKey host, ClrArtifactKey method)
            => new ApiMetadataUri(vparts(w128, (uint)part, (uint)kind, (uint)host, (uint)method));

        [MethodImpl(Inline), Op]
        public static bool eq(in ApiMetadataUri a,in ApiMetadataUri b)
            => a.Data.Equals(b.Data);

        [MethodImpl(Inline), Op]
        public static string identifier(ApiOpId src)
            => string.Format("k{0}", src != 0 ? src.Format() : "0");

        [MethodImpl(Inline), Op]
        public static string identifier(PartId src)
            => src.Format();

        [Op]
        public static string identifier(in ApiMetadataUri src)
        {
            const string Pattern = "{0}_{1}_{2}_{3}";
            return string.Format(Pattern, identifier(src.KindKey), identifier(src.Part), src.HostId, src.OperationId);
        }

        [Op]
        public static string format(in ApiMetadataUri src)
        {
            const string pattern = "metadata://{0}/{1}/{2}/{3}";
            return string.Format(pattern, identifier(src.KindKey), identifier(src.Part), src.HostId, src.OperationId);
        }
    }
}