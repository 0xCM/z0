//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;
    using static z;

    partial struct Archives
    {

        [MethodImpl(Inline), Op]
        public static string format(ListedFile src)
            => text.format("{0,-10} | {1}", src.Index, src.Path);
    }
}