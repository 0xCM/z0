//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    partial struct Prototypes
    {

        [ApiHost(prototypes + "vcopy")]
        public ref struct VCopy
        {
            SpanBlock128<byte> Source;

            SpanBlock128<byte> Target;

            [Op]
            public void copy4x128()
            {
                var v0 = cpu.vload(Source,0);
                var v1 = cpu.vload(Source,1);
                var v2 = cpu.vload(Source,2);
                var v3 = cpu.vload(Source,3);

                cpu.vstore(v0, ref Target.BlockRef(0));
                cpu.vstore(v0, ref Target.BlockRef(1));
                cpu.vstore(v0, ref Target.BlockRef(2));
                cpu.vstore(v0, ref Target.BlockRef(3));
            }
        }
    }
}