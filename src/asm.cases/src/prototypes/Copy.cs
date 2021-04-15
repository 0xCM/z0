//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using static Part;

    partial struct Prototypes
    {

        [ApiHost(prototypes + "vcopy")]
        public ref struct VCopy
        {
            SpanBlock128<byte> Source;

            SpanBlock128<byte> Target;

            [Op]
            public void copy5x128()
            {
                var v0 = cpu.vload(Source,0);
                var v1 = cpu.vload(Source,1);
                var v2 = cpu.vload(Source,2);
                var v3 = cpu.vload(Source,3);
                var v4 = cpu.vload(Source,4);

                cpu.vstore(v0, ref Target.BlockLead(0));
                cpu.vstore(v1, ref Target.BlockLead(1));
                cpu.vstore(v2, ref Target.BlockLead(2));
                cpu.vstore(v3, ref Target.BlockLead(3));
                cpu.vstore(v4, ref Target.BlockLead(4));
            }

            [Op]
            public static void copy(SpanBlock128<byte> src, SpanBlock128<byte> dst)
            {
                var count = src.BlockCount;
                for(var i=0; i<count; i++)
                    cpu.vstore(cpu.vload(src,i), ref dst.BlockLead(i));
            }
        }
    }
}