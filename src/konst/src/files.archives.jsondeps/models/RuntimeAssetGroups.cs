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

    partial struct JsonDeps
    {
        public struct RuntimeAssetGroups
        {
            public IndexedSeq<RuntimeAssetGroup> Data;

            [MethodImpl(Inline)]
            public RuntimeAssetGroups(RuntimeAssetGroup[] src)
                => Data = src;

            [MethodImpl(Inline)]
            public static implicit operator RuntimeAssetGroups(RuntimeAssetGroup[] src)
                => new RuntimeAssetGroups(src);
        }
    }
}