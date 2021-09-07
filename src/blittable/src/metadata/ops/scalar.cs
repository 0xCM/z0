//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Blit
    {
        partial struct Meta
        {
            [MethodImpl(Inline), Op]
            public static ScalarType scalar(ScalarKind kind, ByteSize storage, BitWidth data)
                => new ScalarType(kind, storage,data);
        }
    }
}