//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Seed;
    using static Memories;

    public interface IArchiveOps
    {
        IArchives Services => Archives.Services;

        UriHex[] SaveUriHex(ApiHostUri host, ParsedMember[] src, FilePath dst)
        {
            using var writer = Services.UriHexWriter(dst);
            var data = src.Map(x => UriHex.Define(x.Uri, x.Encoded.Encoded));
            writer.Write(data);
            return data;
        }
        
        ApiCodeIndex CreateCodeIndex(IMemberLocator locator, IApiSet api, ApiHostUri host, FolderPath root)
        {
            var indexer =  Services.IndexBuilder(api,locator);
            var members = locator.Hosted(api.FindHost(host).Require());
            var apiIndex = ApiIndex.Create(members);
            var archive =  Services.CaptureArchive(root);
            var paths = archive.HostArchive(host);
            var code = UriHexReader.Service.Read(paths.HexPath);

            var opIndex =  UriHexQuery.Service.CreateIndex(code);
            return indexer.CreateIndex(apiIndex, opIndex);            
        }        
    }

}