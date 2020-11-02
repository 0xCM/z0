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

    [ApiHost(ApiNames.Cil, true)]
    public readonly partial struct Cil
    {
        readonly CilOpCodes Data;

        [Op]
        public static Cil init()
        {
            var buffer = sys.alloc<CilOpCodeRow>(300);
            ref var dst = ref first(span(buffer));
            load(ref dst);
            return new Cil(buffer);
        }

        [MethodImpl(Inline)]
        Cil(CilOpCodeRow[] src)
        {
            Data = src;
        }
    }
}