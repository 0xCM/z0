//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    
    using BW = BinaryBitwiseOpKind;
    using BL = BinaryLogicOpKind;

    public class t_truthtable : UnitTest<t_truthtable>
    {
        public void unary_truth_emit()
        {
            using var dst = LogArea.Test.LogWriter(FileName.Define("UnaryTruth.txt"));
            var ops = LogicOpApi.UnaryOpKinds;
            TruthTables.emit(dst,ops);
            TruthTables.emit(dst,OpArityKind.Unary);
        }

        public void binary_truth_emit()
        {
            using var dst = LogArea.Test.LogWriter(FileName.Define("BinaryTruth.txt"));
            var ops = LogicOpApi.BinaryOpKinds;
            TruthTables.emit(dst,ops);
            TruthTables.emit(dst,OpArityKind.Binary);
        }

        public void ternary_truth_emit()
        {
            using var dst = LogArea.Test.LogWriter(FileName.Define("TernaryTruth.txt"));
            var ops = LogicOpApi.TernaryOpKinds;
            TruthTables.emit(dst,ops);
            TruthTables.emit(dst,OpArityKind.Ternary);
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
            => check_truth(BL.And);

        public void check_typed_and_truth()
            => check_truth(BW.And);

        public void check_logical_nand_truth()
            => check_truth(BL.Nand);

        public void check_typed_nand_truth()
            => check_truth(BW.Nand);

        public void check_logical_or_truth()
            => check_truth(BL.Or);

        public void check_typed_or_truth()
            => check_truth(BW.Or);

        public void check_logical_nor_truth()
            => check_truth(BL.Nor);

        public void check_typed_nor_truth()
            => check_truth(BW.Nor);

        public void check_logical_xor_truth()
            => check_truth(BL.XOr);

        public void check_typed_xor_truth()
            => check_truth(BW.XOr);

        public void check_logical_xnor_truth()
            => check_truth(BL.Xnor);

        public void check_typed_xnor_truth()
            => check_truth(BW.Xnor);

        public void check_logical_imply_truth()
            => check_truth(BL.Implication);

        public void check_typed_imply_truth()
            => check_truth(BW.Implication);

        public void check_logical_notimply_truth()
            => check_truth(BL.Nonimplication);

        public void check_typed_notimply_truth()
            => check_truth(BW.Nonimplication);

        public void check_logical_cimply_truth()
            => check_truth(BL.ConverseImplication);

        public void check_typed_cimply_truth()
            => check_truth(BW.ConverseImplication);

        public void check_logical_cnotimply_truth()
            => check_truth(BL.ConverseNonimplication);

        public void check_typed_cnotimply_truth()
            => check_truth(BW.ConverseNonimplication);

        void check_truth(BW op)
        {               
            const byte on = 1;
            const byte off = 0;

            var dst = BitVector.alloc(n4);
            dst[0] = (byte)(ScalarOpApi.eval(op, off,off) & on) == on;
            dst[1] = (byte)(ScalarOpApi.eval(op, on,off) & on) == on;
            dst[2] = (byte)(ScalarOpApi.eval(op, off,on) & on) == on;
            dst[3] = (byte)(ScalarOpApi.eval(op, on,on) & on) == on;
            var sig = TruthTables.sig(op.ToLogical());
            Claim.eq(sig,dst);
        }
        
        void check_truth(BL op)
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

            Trace(TruthTables.definition(BinaryLogicOpKind.And).Format());
            Trace(TruthTables.definition(BinaryLogicOpKind.Or).Format());
            Trace(TruthTables.definition(BinaryLogicOpKind.Nand).Format());
        
        }
    }
}