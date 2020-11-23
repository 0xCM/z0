//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Service]
    readonly struct FileTypeFormatter : ITextFormatter<FileType>
    {
        public string Format(FileType src)
            => FS.format(src);
    }
}