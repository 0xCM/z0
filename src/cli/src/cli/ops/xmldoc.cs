//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct Cli
    {
       public static XmlDocProvider xmldoc(FS.FilePath src)
            => new XmlDocProvider(src.Name);
    }
}