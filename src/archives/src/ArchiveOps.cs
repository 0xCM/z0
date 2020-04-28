//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public readonly struct ArchiveOps
    {
        public static UriBits[] SaveUriBits(ApiHostUri host, ParsedMemberExtract[] src, FilePath dst)
        {
            using var writer = Archives.Services.UriBitsWriter(dst);
            var data = src.Map(x => UriBits.Define(x.Uri, x.ParsedContent.Content));
            writer.Write(data);
            return data;
        }

        public static ApiCodeIndex CreateCodeIndex(IMemberLocator locator, IApiSet api, ApiHostUri host, FolderPath root)
        {
            var indexer =  ApiIndexBuilder.Create(api, locator);
            var members = locator.Hosted(api.FindHost(host).Require());
            var apiIndex = ApiIndex.Create(members);
            var archive =  Archives.Services.CaptureArchive(root);
            var paths = archive.CaptureArchive(host);
            var reader = UriBitsReader.Service;
            var code = reader.Read(paths.HexPath);
            var opIndex = code.ToOpIndex(); 
            return indexer.CreateIndex(apiIndex, opIndex);            
        }
    }
}