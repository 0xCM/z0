//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Part;
    using static z;

    partial struct ResDataEmitter
    {
        public static ResEmission emit(in ResDescriptor src, FS.FolderPath root)
        {
            var invalid = Path.GetInvalidPathChars();
            var name =  src.Name.ToString().ReplaceAny(invalid, Chars.Underscore);
            var target = root + FS.file(name);
            var utf = Resources.utf8(src);
            using var writer = target.Writer();
            writer.Write(utf);
            return link(src,target);
        }
    }
}