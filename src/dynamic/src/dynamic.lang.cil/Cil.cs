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
        readonly CilOpCodeDataset Data;

        [MethodImpl(Inline), Op]
        public static CilFunctionFormatter formatter()
            => new CilFunctionFormatter();

        [MethodImpl(Inline), Op]
        public static CilFunctionFormatter formatter(CilFormatConfig config)
            => new CilFunctionFormatter(config);

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