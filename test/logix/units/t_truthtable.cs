//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Konst;
    using static BinaryLogicKind;

    using BLK = BinaryLogicKind;

    public class t_truthtable : UnitTest<t_truthtable>
    {
        BitLogix bitlogix => BitLogix.Service;

        public void unary_truth()
        {
            using var dst = UnitWriter(FileName.define(caller()));
            var src = bitlogix.UnaryOpKinds;
            TabularTruth.save(src, dst);
            //TabularTruth.save(dst,ArityValue.Unary);
        }

        public void binary_truth()
        {
            using var dst = UnitWriter(FileName.define(caller()));
            var src = bitlogix.BinaryOpKinds;
            TabularTruth.save(src, dst);
            //TabularTruth.save(dst,ArityValue.Binary);
        }

        public void ternary_truth()
        {
            using var dst = UnitWriter(FileName.define(caller()));
            var src = bitlogix.TernaryOpKinds;
            TabularTruth.save(src, dst);
            //TabularTruth.save(dst, ArityValue.Ternary);
        }

        public void unary_sig_check()
        {
            foreach(var op in bitlogix.UnaryOpKinds)
            {
                var table = TabularTruth.table(op);
                var result = table.GetCol(table.ColCount - 1).ToBitVector(n8).Lo;
                var sig = TabularTruth.vector(n4, op);
                Claim.eq(result,sig);
            }
        }

        public void binary_sig_check()
        {
            foreach(var op in bitlogix.BinaryOpKinds)
            {
                var table = TabularTruth.table(op);
                var result = table.GetCol(table.ColCount - 1).ToBitVector(n8).Lo;
                var sig = TabularTruth.vector(n4,op);
                Claim.eq(result,sig);
            }
        }

        public void ternary_sig_check()
        {
            foreach(var op in bitlogix.TernaryOpKinds)
            {
                var table = TabularTruth.table(op);
                var result = table.GetCol(table.ColCount - 1).ToBitVector(n8);
                var sig = TabularTruth.vector(n8,op);
                Claim.eq(result,sig);
            }
        }

        public void check_logical_and_truth()
            => check_truth(And);

        public void check_typed_and_truth()
            => check_typed_truth(And);

        public void check_logical_nand_truth()
            => check_truth(Nand);

        public void check_typed_nand_truth()
            => check_typed_truth(Nand);

        public void check_logical_or_truth()
            => check_truth(Or);

        public void check_typed_or_truth()
            => check_typed_truth(Or);

        public void check_logical_nor_truth()
            => check_truth(Nor);

        public void check_typed_nor_truth()
            => check_typed_truth(Nor);

        public void check_logical_xor_truth()
            => check_truth(Xor);

        public void check_typed_xor_truth()
            => check_typed_truth(Xor);

        public void check_logical_xnor_truth()
            => check_truth(Xnor);

        public void check_typed_xnor_truth()
            => check_typed_truth(Xnor);

        public void check_logical_imply_truth()
            => check_truth(Impl);

        public void check_typed_imply_truth()
            => check_typed_truth(Impl);

        public void check_logical_notimply_truth()
            => check_truth(NonImpl);

        public void check_typed_notimply_truth()
            => check_typed_truth(NonImpl);

        public void check_logical_cimply_truth()
            => check_truth(CImpl);

        public void check_typed_cimply_truth()
            => check_typed_truth(CImpl);

        public void check_logical_cnotimply_truth()
            => check_truth(CNonImpl);

        public void check_typed_cnotimply_truth()
            => check_typed_truth(CNonImpl);

        void check_typed_truth(BinaryLogicKind op)
        {
            const byte on = 1;
            const byte off = 0;

            var dst = BitVector.alloc(n4);
            dst[0] = (byte)(NumericLogixHost.eval(op, off,off) & on) == on;
            dst[1] = (byte)(NumericLogixHost.eval(op, on,off) & on) == on;
            dst[2] = (byte)(NumericLogixHost.eval(op, off,on) & on) == on;
            dst[3] = (byte)(NumericLogixHost.eval(op, on,on) & on) == on;
            var sig = TabularTruth.vector(n4, op);
            Claim.eq(sig,dst);
        }

        void check_truth(BinaryLogicKind op)
        {
            var dst = BitVector.alloc(n4);
            dst[0] = bitlogix.Evaluate(op, bit.Off,bit.Off);
            dst[1] = bitlogix.Evaluate(op, bit.On,bit.Off);
            dst[2] = bitlogix.Evaluate(op, bit.Off,bit.On);
            dst[3] = bitlogix.Evaluate(op, bit.On,bit.On);
            var sig = TabularTruth.vector(n4, op);
            Claim.eq(sig,dst);
        }

        public void truth_vectors()
        {
            Notify(TabularTruth.vector(n16, BLK.And).Format());
            Notify(TabularTruth.vector(n16, BLK.Or).Format());
            Notify(TabularTruth.vector(n16,BLK.Nand).Format());
        }
    }
}