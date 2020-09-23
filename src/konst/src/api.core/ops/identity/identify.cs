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

    partial struct ApiIdentity
    {
        [Op]
        public static ApiCodeIndex index(IApiMemberLocator locator, ApiParts api, ApiHostUri uri, FilePath src)
        {
            var code = ApiIdentity.index(ApiCodeReader.Service.Read(src));
            var members = index(locator.Locate(api.FindHost(uri).Require()));
            return ApiIdentity.index(members, code);
        }

        [Op]
        public static ApiCodeIndex index(IApiMemberLocator locator, ApiParts api, ApiHostUri host, FolderPath root)
        {
            var members = locator.Locate(api.FindHost(host).Require());
            var idx = index(members);
            var archive =  ApiArchives.capture(root);
            var paths =  HostCaptureArchive.create(root, host);
            var code = ApiCodeReader.Service.Read(paths.HostX86Path);
            var opIndex =  ApiCodeQuery.Service.CreateIndex(code);
            return ApiIdentity.index(idx, opIndex);
        }

        [Op]
        public static ApiMemberIndex index(ApiMembers src)
        {
            var index = ApiIdentity.index(src.Storage.Select(h => (h.Id, h)),true);
            return new ApiMemberIndex(index.HashTable, index.Duplicates);
        }

        [Op]
        public static Option<SegmentedIdentity> identify(ApiIdentityPart part)
        {
            if(part.IsSegment && parse(part.Identifier, out var seg))
                return seg;
            else
                return none<SegmentedIdentity>();
        }

        /// <summary>
        /// Identifies a type
        /// </summary>
        /// <param name="src">The type to identify</param>
        [Op]
        public static TypeIdentity identify(Type src)
        {
            var component = src.Assembly;
            var id = text.format(RP.SlotDot3,
                "type",
                ClrArtifactKey.from(component),
                ClrArtifactKey.from(src)
                );
            return TypeIdentity.define(id);
        }

        /// <summary>
        /// Identifies a method
        /// </summary>
        /// <param name="src">The method to identify</param>
        [Op]
        public static OpIdentity identify(MethodInfo src)
        {
            var type = src.DeclaringType;
            var component = type.Assembly;
            var id = text.format(RP.SlotDot4,
                "method",
                ClrArtifactKey.from(component),
                ClrArtifactKey.from(type),
                ClrArtifactKey.from(src)
                );

            return OpIdentity.define(id);
        }

        /// <summary>
        /// Identifies a delegate
        /// </summary>
        /// <param name="src">The method to identify</param>
        [Op]
        public static OpIdentity identify(Delegate src)
        {
            var method =src.Method;
            var type = method.DeclaringType;
            var component = type.Assembly;
            var id = text.format(RP.SlotDot5,
                "delegate",
                ClrArtifactKey.from(component),
                ClrArtifactKey.from(type),
                ClrArtifactKey.from(method),
                src.GetHashCode()
                );
            return OpIdentity.define(id);
        }
    }
}