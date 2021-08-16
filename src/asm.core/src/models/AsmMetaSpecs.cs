//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [ApiHost("asm.specs.metadata")]
    public partial class AsmMetaSpecs : Service<AsmMetaSpecs>
    {
        ushort Capacity = Pow2.T14;

        Index<AsmInfo> Collections;

        Index<AsmInfoRecord> Records;

        AsmInstructions I;

        uint CIx;

        uint RIx;

        public AsmMetaSpecs()
        {
            Collections = alloc<AsmInfo>(Capacity);
            Records = alloc<AsmInfoRecord>(Capacity);
            I = default;
            CIx = 0;
            RIx = 0;
        }

        [Op]
        public void Collect()
        {
            var dst = Collections.Edit;
            collect(I.movzx(), ref CIx, dst);
        }

        [Op]
        public void CreateRecords()
        {
            if(CIx != 0)
            {
                RIx = 0;
                AsmRecords.fill(slice(Collections.View, 0, CIx), ref RIx, Records.Edit);
            }
        }

        public readonly struct M
        {
            [MethodImpl(Inline), Op]
            public static r8 r8()
                => default;

            [MethodImpl(Inline), Op]
            public static r16 r16()
                => default;

            [MethodImpl(Inline), Op]
            public static r32 r32()
                => default;

            [MethodImpl(Inline), Op]
            public static r64 r64()
                => default;

            [MethodImpl(Inline), Op]
            public static m8 m8()
                => default;

            [MethodImpl(Inline), Op]
            public static m16 m16()
                => default;

            [MethodImpl(Inline), Op]
            public static m32 m32()
                => default;

            [MethodImpl(Inline), Op]
            public static m64 m64()
                => default;

            [MethodImpl(Inline), Op]
            public static imm8 imm8()
                => default;

            [MethodImpl(Inline), Op]
            public static imm16 imm16()
                => default;

            [MethodImpl(Inline), Op]
            public static imm32 imm32()
                => default;

            [MethodImpl(Inline), Op]
            public static imm64 imm64()
                => default;
        }
    }
}