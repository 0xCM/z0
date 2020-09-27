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

    /// <summary>
    /// Verifies the bit-level equivalence of the binary bitwise operators and the binary logical operators
    /// </summary>
    public class t_bitwise_logic : LogixTest<t_bitwise_logic>
    {
        public void bwl_and_check()
        {
            var op = And;
            bitwise_logic_check<byte>(op);
            bitwise_logic_check<ushort>(op);
            bitwise_logic_check<uint>(op);
            bitwise_logic_check<ulong>(op);
        }

        public void bwl_nand_check()
        {
            var op = Nand;
            bitwise_logic_check<byte>(op);
            bitwise_logic_check<ushort>(op);
            bitwise_logic_check<uint>(op);
            bitwise_logic_check<ulong>(op);
        }

        public void bwl_or_check()
        {
            var op = Or;
            bitwise_logic_check<byte>(op);
            bitwise_logic_check<ushort>(op);
            bitwise_logic_check<uint>(op);
            bitwise_logic_check<ulong>(op);
        }

        public void bwl_nor_check()
        {
            var op = Nor;
            bitwise_logic_check<byte>(op);
            bitwise_logic_check<ushort>(op);
            bitwise_logic_check<uint>(op);
            bitwise_logic_check<ulong>(op);
        }

        public void bwl_xor_check()
        {
            var op = Xor;
            bitwise_logic_check<byte>(op);
            bitwise_logic_check<ushort>(op);
            bitwise_logic_check<uint>(op);
            bitwise_logic_check<ulong>(op);
        }

        public void bwl_xnor_check()
        {
            var op = Xnor;
            bitwise_logic_check<byte>(op);
            bitwise_logic_check<ushort>(op);
            bitwise_logic_check<uint>(op);
            bitwise_logic_check<ulong>(op);
        }

        public void bwl_lnot_check()
        {
            var op = LNot;
            bitwise_logic_check<byte>(op);
            bitwise_logic_check<ushort>(op);
            bitwise_logic_check<uint>(op);
            bitwise_logic_check<ulong>(op);
        }

        public void bwl_rnot_check()
        {
            var op = RNot;
            bitwise_logic_check<byte>(op);
            bitwise_logic_check<ushort>(op);
            bitwise_logic_check<uint>(op);
            bitwise_logic_check<ulong>(op);
        }

        public void bwl_imply_check()
        {
            var op = Impl;
            bitwise_logic_check<byte>(op);
            bitwise_logic_check<ushort>(op);
            bitwise_logic_check<uint>(op);
            bitwise_logic_check<ulong>(op);
        }

        public void bwl_notimply_check()
        {
            var op = NonImpl;
            bitwise_logic_check<byte>(op);
            bitwise_logic_check<ushort>(op);
            bitwise_logic_check<uint>(op);
            bitwise_logic_check<ulong>(op);
        }

        public void bwl_cimply_check()
        {
            var op = CImpl;
            bitwise_logic_check<byte>(op);
            bitwise_logic_check<ushort>(op);
            bitwise_logic_check<uint>(op);
            bitwise_logic_check<ulong>(op);
        }

        public void bwl_cnotimply_check()
        {
            var op = CNonImpl;
            bitwise_logic_check<byte>(op);
            bitwise_logic_check<ushort>(op);
            bitwise_logic_check<uint>(op);
            bitwise_logic_check<ulong>(op);
        }
    }
}