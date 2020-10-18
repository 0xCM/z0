//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection.Metadata;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost(ApiNames.CilApi, true)]
    public readonly partial struct CilApi
    {
        readonly CilOpCodes Data;

        [Op]
        public static CilApi init()
        {
            var buffer = sys.alloc<CilOpCodeRow>(300);
            ref var dst = ref first(span(buffer));
            load(ref dst);
            return new CilApi(buffer);
        }

        [MethodImpl(Inline)]
        CilApi(CilOpCodeRow[] src)
        {
            Data = src;
        }
    }
}