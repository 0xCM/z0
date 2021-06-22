//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct FS
    {
        [Op]
        public static FilePath timestamped(FilePath src)
        {
            var name = src.FileName.WithoutExtension;
            var ext = src.Ext;
            var stamped = file(string.Format("{0}.{1}.{2}", name, core.timestamp(), ext));
            return src.FolderPath + stamped;
        }
    }
}