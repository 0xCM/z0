//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Records
    {
        [MethodImpl(Inline), Op]
        public static RecordEmission<T> emission<T>(T[] src, FS.FilePath dst)
            where T : struct
                => new RecordEmission<T>(src,dst);
    }
}