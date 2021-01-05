//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    [ApiHost(ApiNames.Cil, true)]
    public readonly partial struct Cil
    {
        readonly Index<OpCodeInfo> Data;

        [Op]
        public static Cil init()
        {
            var buffer = sys.alloc<OpCodeInfo>(300);
            ref var dst = ref first(span(buffer));
            OpCodes.load(ref dst);
            return new Cil(buffer);
        }

        [MethodImpl(Inline)]
        Cil(OpCodeInfo[] src)
            => Data = src;
    }
}