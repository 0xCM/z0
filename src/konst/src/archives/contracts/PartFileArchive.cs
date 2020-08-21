//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using X = FileExtensions;

    public readonly struct PartCaptureArchive
    {
        [MethodImpl(Inline)]
        public static PartCaptureArchive create(IPartCaptureArchive src)
            => new PartCaptureArchive(src);

        readonly IPartCaptureArchive Archive;

        [MethodImpl(Inline)]
        public PartCaptureArchive(IPartCaptureArchive archive)
            => Archive = archive;

        static void Clear(PartId part, FilePath file, Action<FilePath> handler)
            => file.Delete().OnSome(handler);

        static void Clear(PartId part, ReadOnlySpan<FilePath> files, Action<FilePath> handler)
        {
            var count = files.Length;
            for(var i=0u; i<count; i++)
                Clear(part, skip(files,i), handler);
        }

        static void Clear(PartId part, FolderPath src, FileExtension ext, Action<FilePath> handler)
            => Clear(part, src.Files(ext), handler);

        public void ClearExtracts(PartId part, Action<FilePath> handler)
            => Clear(part, Archive.ExtractDir, X.Extract, handler);

        public void ClearParsed(PartId part, Action<FilePath> handler)
            => Clear(part, Archive.ParsedDir, X.Parsed, handler);

        public void ClearAsm(PartId part, Action<FilePath> handler)
            => Clear(part, Archive.AsmDir, X.Asm, handler);

        public void ClearHexCode(PartId part, Action<FilePath> handler)
            => Clear(part, Archive.CodeDir, X.HexLine, handler);

        public void ClearUnparsed(PartId part, Action<FilePath> handler)
            => Clear(part, Archive.UnparsedDir, X.Unparsed, handler);

        public void Clear(PartId part, Action<FilePath> handler)
        {
            ClearExtracts(part,handler);
            ClearParsed(part,handler);
            ClearAsm(part,handler);
            ClearHexCode(part,handler);
            ClearUnparsed(part,handler);
        }
    }
}