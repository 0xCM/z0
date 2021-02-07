//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct FS
    {
        [Op]
        public static FilePath timestamped(FilePath src)
        {
            var name = src.FileName.WithoutExtension;
            var ext = src.Ext;
            var stamped = file(Z0.text.format("{0}.{1}.{2}", name, root.timestamp(), ext));
            return src.FolderPath + stamped;
        }
    }
}