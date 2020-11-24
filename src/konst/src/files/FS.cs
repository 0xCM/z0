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

    [ApiHost(ApiNames.FS, true)]
    public readonly partial struct FS
    {
        static RenderPattern<A,B> PathJoin<A,B>()
            where A : IFsEntry
            where B : IFsEntry
                => "{0}/{1}";

    }
}