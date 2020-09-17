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

    [ApiHost("api")]
    public readonly partial struct Cil
    {
        readonly OpCodeDataset Data;

        [MethodImpl(Inline), Op]
        public static CilFunctionFormatter formatter()
            => new CilFunctionFormatter();

        [MethodImpl(Inline), Op]
        public static CilFunctionFormatter formatter(CilFormatConfig config)
            => new CilFunctionFormatter(config);

        [Op]
        public static Cil init()
        {
            var buffer = sys.alloc<CilOpCode>(300);
            ref var dst = ref first(span(buffer));
            load(ref dst);
            return new Cil(buffer);
        }

        [MethodImpl(Inline)]
        Cil(CilOpCode[] src)
        {
            Data = src;
        }
    }

    public readonly partial struct DnCilModel
    {

    }
}