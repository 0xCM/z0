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
        readonly Index<CilOpCodeInfo> Data;

        [Op]
        public static Cil init()
        {
            var buffer = sys.alloc<CilOpCodeInfo>(300);
            ref var dst = ref first(span(buffer));
            CilOpCodes.load(ref dst);
            return new Cil(buffer);
        }

        [MethodImpl(Inline)]
        Cil(CilOpCodeInfo[] src)
            => Data = src;
    }
}