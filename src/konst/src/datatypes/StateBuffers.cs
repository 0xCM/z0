//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    [ApiHost(ApiNames.StateBuffers)]
    public readonly struct StateBuffers
    {
        [Op]
        public static StateBuffer<uint1,uint1> create(W1 w)
            => new StateBuffer<uint1,uint1>(uint1.Count);

        [Op]
        public static StateBuffer<uint2,uint2> create(W2 w)
            => new StateBuffer<uint2,uint2>(uint2.Mod);

        [Op]
        public static StateBuffer<uint3,uint3> create(W3 w)
            => new StateBuffer<uint3,uint3>(uint3.Mod);

        [Op]
        public static StateBuffer<uint4,uint4> create(W4 w)
            => new StateBuffer<uint4,uint4>(uint4.Mod);

        [Op]
        public static StateBuffer<uint5,uint5> create(W5 w)
            => new StateBuffer<uint5,uint5>(uint5.Mod);

        [Op]
        public static StateBuffer<uint6,uint6> create(W6 w)
            => new StateBuffer<uint6,uint6>(uint6.Mod);

        [Op]
        public static StateBuffer<uint7,uint7> create(W7 w)
            => new StateBuffer<uint7,uint7>(uint7.Mod);

        [Op]
        public static StateBuffer<uint8T,uint8T> create(W8 w)
            => new StateBuffer<uint8T,uint8T>(256);

        [Op]
        public static StateBuffer<T> create<T>(uint count)
            where T : unmanaged
                => new StateBuffer<T>(count);
    }
}