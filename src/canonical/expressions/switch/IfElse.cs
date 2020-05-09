//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    partial class AsmExpr
    {
        const long F1_Base = 0x7ffd8f68c4f0;

        const long F1_Call_F6_Offset_Encoded = 0xf9c9f7;

        const long F1_Call_F6_Source = 0x7ffd8f68c4fc;

        const long F1_Call_F6_NextIp = F1_Call_F6_Source + 5;            

        const long F6_F1_NextIp_Delta = F6_Base - F1_Call_F6_NextIp;

        const long F1_Call_F7_Source = 0x7ffd8f68c506;

        const long F1_Call_F7_NextIp = F1_Call_F7_Source + 5;

        const long F1_Call_F7_Target = 0x7ffd8e628f00;

        const long F1_Call_F8_Source = 0x7ffd8f68c511;

        const long F1_Call_F8_NextIp = F1_Call_F8_Source + 5;

        const long F1_Call_F8_Target = 0x7ffd8e628f08;

        const long F6_Base_F1_Base_Delta = F6_Base - F1_Base;

        const long F7_Base_F1_Base_Delta = F7_Base - F1_Base;

        const long F8_Base_F1_Base_Delta = F8_Base - F1_Base;

        // 140727009461568
        const long F6_Base = 0x7ffd8f68c540;

        const long F7_Base = 0x7ffd8f68c560;

        const long F8_Base = 0x7ffd8f68c580;


        [Op, MethodImpl(NotInline)]
        public uint f1()
        {
            return f6() * f7() * f8();
        }

        [Op, MethodImpl(NotInline)]
        public uint f6()
            =>0xFF;

        [Op, MethodImpl(NotInline)]
        public uint f7()
            => 0xFFAAFF;

        [Op, MethodImpl(NotInline)]
        public uint f8()
            => 0x555555;
    }
}