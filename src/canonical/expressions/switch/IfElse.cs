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
        const long F1_Base = 0x7ffd_8de9d180;

        
        const long F1_Call_F6_Offset = 0x27bdf7fe;

        const long F1_Call_F6 = 0x7ffd_8ce18eb8;

        const long F1_Call_F7 = 0x7ffd_8ce18ec0;

        const long F1_Call_F8 = 0x7ffd_8ce18ec8;


        const long F1_Call_F7_Offset = 0x25bdf7fe;

        const long F1_Call_F8_Offset = 0x22bdf7fe;


        const long F6_Base = 0x7ffd_8de9d1d0;
    

        const long F7_Base = 0x7ffd_8de9d1f0;

        const long F8_Base = 0x7ffd_8de9d210;

        // 17318680
        const long X1 = F6_Base - F1_Call_F6;

        // 17318704
        const long X2 = F7_Base - F1_Call_F7;



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