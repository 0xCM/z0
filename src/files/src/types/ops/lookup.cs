//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class FileTypes
    {

        [Op]
        public static FileType lookup(FS.FileExt ext)
        {
            if(Lookup.TryGetValue(key(ext), out var value))
                return value;
            else
                return EmptyType;
        }

        [Op]
        public static bool lookup(FS.FileExt ext, out FileType type)
            => Lookup.TryGetValue(key(ext), out type);
    }
}