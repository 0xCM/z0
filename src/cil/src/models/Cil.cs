//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Reflection.Emit;
    using System.Reflection.Metadata;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    public readonly partial struct Cil
    {
        readonly OpCodeDataset Data;

        [MethodImpl(Inline), Op]
        public static Cil init()
        {
            var buffer = sys.alloc<OpCodeTable>(300);
            ref var dst = ref first(span(buffer));
            load(ref dst);
            return new Cil(buffer);
        }

        [MethodImpl(Inline)]
        Cil(OpCodeTable[] src)
        {
            Data = src;
        }


        [MethodImpl(Inline), Op]
        public static Symbol<ILOpCode,ushort,N16> symbol<K>(K k = default)
            where K : unmanaged, ICilOpCode<K>
                => Symbolic.symbol<ILOpCode,ushort,N16>((ILOpCode)(default(K).Id));
    }
}