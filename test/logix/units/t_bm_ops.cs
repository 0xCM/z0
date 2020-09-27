//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static BinaryBitLogicKind;

    public class t_bm_ops : LogixTest<t_bm_ops>
    {
        public void bm_not_check()
        {
            bm_not_check<N8,byte>();
            bm_not_check<N16,ushort>();
            bm_not_check<N32,uint>();
            bm_not_check<N64,ulong>();
        }

        public void bm_and_check()
        {
            bm_and_check<N8,byte>();
            bm_and_check<N16,ushort>();
            bm_and_check<N32,uint>();
            bm_and_check<N64,ulong>();
        }

        public void bm_nand_check()
        {
            bm_nand_check<N8,byte>();
            bm_nand_check<N16,ushort>();
            bm_nand_check<N32,uint>();
            bm_nand_check<N64,ulong>();
        }

        public void bm_or_check()
        {
            bm_or_check<N8,byte>();
            bm_or_check<N16,ushort>();
            bm_or_check<N32,uint>();
            bm_or_check<N64,ulong>();
        }

        public void bm_nor_check()
        {
            bm_nor_check<N8,byte>();
            bm_nor_check<N16,ushort>();
            bm_nor_check<N32,uint>();
            bm_nor_check<N64,ulong>();
        }

        public void bm_xor_check()
        {
            bm_xor_check<N8,byte>();
            bm_xor_check<N16,ushort>();
            bm_xor_check<N32,uint>();
            bm_xor_check<N64,ulong>();
        }

        public void bm_xnor_check()
        {
            bm_xnor_check<N8,byte>();
            bm_xnor_check<N16,ushort>();
            bm_xnor_check<N32,uint>();
            bm_xnor_check<N64,ulong>();
        }

        public void bm_imply_check()
        {
            bm_imply_check<N8,byte>();
            bm_imply_check<N16,ushort>();
            bm_imply_check<N32,uint>();
            bm_imply_check<N64,ulong>();
        }

        public void bm_notimply_check()
        {
            bm_notimply_check<N8,byte>();
            bm_notimply_check<N16,ushort>();
            bm_notimply_check<N32,uint>();
            bm_notimply_check<N64,ulong>();
        }

        public void bm_and_bench()
        {
            bm_and_bench<ulong>();
            bm_api_bench<ulong>(And);
            bm_delegate_bench<ulong>(And);
        }

        public void bm_xor_bench()
        {
            bm_xor_bench<ulong>();
            bm_api_bench<ulong>(Xor);
            bm_delegate_bench<ulong>(Xor);
        }
    }
}
