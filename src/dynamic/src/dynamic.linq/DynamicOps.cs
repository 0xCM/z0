//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static memory;
    using static Part;

    [ApiHost]
    public readonly partial struct DynamicOps
    {
        [FixedAddressValueType]
        static readonly Ops8u _ops8u;

        [FixedAddressValueType]
        static readonly Ops8i _ops8i;

        [FixedAddressValueType]
        static readonly Ops16u _ops16u;

        [FixedAddressValueType]
        static readonly Ops16uC _ops16uC;

        [FixedAddressValueType]
        static readonly Ops32u _ops32u;

        [FixedAddressValueType]
        static readonly Ops32i _ops32i;

        [FixedAddressValueType]
        static readonly DynamicOps Self;

        [Op]
        public static Index<MemoryAddress> init()
        {
            var src = Self;
            var buffer = new MemoryAddress[7];
            ref var dst = ref first(buffer);
            seek(buffer,0) = address(Self);
            seek(buffer,1) = address(_ops8u);
            seek(buffer,2) = address(_ops8i);
            seek(buffer,3) = address(_ops32u);
            seek(buffer,4) = address(_ops32i);
            seek(buffer,5) = address(_ops16u);
            seek(buffer,6) = address(_ops16uC);
            return buffer;
        }
    }
}