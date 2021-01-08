//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct FS
    {
        [MethodImpl(Inline), Op]
        public static bool has(FilePath src, FileExt ext)
            => src.Ext == ext;
    }
}