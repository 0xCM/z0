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

    public class Archives
    {
        public static ApiCodeIndex code(IMemberLocator locator, IApiSet api, ApiHostUri host, FolderPath root)
        {
            var indexer =  ApiIndexBuilder.Create(api, locator);
            var members = locator.Hosted(api.FindHost(host).Require());
            var apiIndex = ApiIndex.Create(members);
            var archive =  CaptureArchive.Create(root);
            var paths = archive.CaptureArchive(host);
            var reader = UriBitsReader.Service;
            var code = reader.Read(paths.HexPath);
            var opIndex = code.ToOpIndex(); 
            return indexer.CreateIndex(apiIndex, opIndex);            
        }
    }
}