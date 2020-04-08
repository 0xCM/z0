//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static Seed;
    using static Gone;

    using static BinaryBitLogicKind;

    public class t_truthtable : UnitTest<t_truthtable>
    {
        static StreamWriter writer(FileName filename)
            => (Env.Current.LogDir + FolderName.Define("truth") + filename).Writer();
        
        public void unary_truth_emit()
        {
            using var dst = writer(FileName.Define("UnaryTruth.txt"));
            var ops = LogicOpApi.UnaryOpKinds;
            TruthTables.emit(dst,ops);
            TruthTables.emit(dst,ArityValue.Unary);
        }

        public void binary_truth_emit()
        {
            using var dst = writer(FileName.Define("BinaryTruth.txt"));
            var ops = LogicOpApi.BinaryOpKinds;
            TruthTables.emit(dst,ops);
            TruthTables.emit(dst,ArityValue.Binary);
        }

        public void ternary_truth_emit()
        {
            using var dst = writer(FileName.Define("TernaryTruth.txt"));
            var ops = LogicOpApi.TernaryOpKinds;
            TruthTables.emit(dst,ops);
            TruthTables.emit(dst,ArityValue.Ternary);
        }

        public void unary_sig_check()
        {
            foreach(var op in LogicOpApi.UnaryOpKinds)
            {
                var table = TruthTables.build(op);
                var result = table.GetCol(table.ColCount - 1).ToBitVector(n8).Lo;
                var sig = TruthTables.sig(op);
                Claim.eq(result,sig);
            }
        }

        public void binary_sig_check()
        {
            foreach(var op in LogicOpApi.BinaryOpKinds)
            {
                var table = TruthTables.build(op);
                var result = table.GetCol(table.ColCount - 1).ToBitVector(n8).Lo;
                var sig = TruthTables.sig(op);
                Claim.eq(result,sig);
            }
        }

        public void ternary_sig_check()
        {
            foreach(var op in LogicOpApi.TernaryOpKinds)
            {
                var table = TruthTables.build(op);
                var result = table.GetCol(table.ColCount - 1).ToBitVector(n8);
                var sig = TruthTables.sig(op);
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

        void check_typed_truth(BinaryBitLogicKind op)
        {               
            const byte on = 1;
            const byte off = 0;

            var dst = BitVector.alloc(n4);
            dst[0] = (byte)(NumericOpApi.eval(op, off,off) & on) == on;
            dst[1] = (byte)(NumericOpApi.eval(op, on,off) & on) == on;
            dst[2] = (byte)(NumericOpApi.eval(op, off,on) & on) == on;
            dst[3] = (byte)(NumericOpApi.eval(op, on,on) & on) == on;
            var sig = TruthTables.sig(op);
            Claim.eq(sig,dst);
        }
        
        void check_truth(BinaryBitLogicKind op)
        {
            var dst = BitVector.alloc(n4);
            dst[0] = LogicOpApi.eval(op, bit.Off,bit.Off);
            dst[1] = LogicOpApi.eval(op, bit.On,bit.Off);
            dst[2] = LogicOpApi.eval(op, bit.Off,bit.On);
            dst[3] = LogicOpApi.eval(op, bit.On,bit.On);
            var sig = TruthTables.sig(op);
            Claim.eq(sig,dst);
        }

        public void truth_vectors()
        {
            Notify(TruthTables.definition(BinaryBitLogicKind.And).Format());
            Notify(TruthTables.definition(BinaryBitLogicKind.Or).Format());
            Notify(TruthTables.definition(BinaryBitLogicKind.Nand).Format());        
        }
    }
}