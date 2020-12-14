//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IFileDb : IFileDbPaths, IFileDbOps, IArchiveOps, IFileArchive
    {
        PartFiles PartFiles()
        {
            var parsed = ParsedExtractFiles();
            var hex = CapturedHexFiles();
            var asm = CapturedAsmFiles();
            return new PartFiles(parsed, hex, asm);
        }
    }
}