//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IApiCaptureArchive : IWfService, IFileExtensions
    {
        void Clear();

        FS.Files ParsedExtractFiles()
            => Db.ParsedExtractFiles();

        FS.Files ApiHexFiles()
            => Db.ApiHexFiles();

        FS.Files ApiExtractFiles(PartId part)
            => Db.RawExtractFiles(part);

        FS.Files ParsedExtractFiles(PartId part)
            => Db.ParsedExtractFiles(part);

        FS.Files AsmFiles(PartId part)
            => Db.AsmFiles(part);

        FS.Files ApiHexFiles(PartId part)
            => Db.ApiHexFiles(part);

        FS.Files CilDataFiles(PartId part)
            => Db.CilDataFiles(part);
    }
}