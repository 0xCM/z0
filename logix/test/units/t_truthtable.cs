//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;    
    using static BinaryBitLogicKind;

    public class t_truthtable : UnitTest<t_truthtable>
    {
        static StreamWriter writer(FileName filename)
            => datasink(FolderName.Define("truth"), filename);
        
        public void unary_truth_emit()
        {
            using var dst = writer(FileName.Define("UnaryTruth.txt"));
            var ops = LogicOpApi.UnaryOpKinds;
            TruthTables.emit(dst,ops);
            TruthTables.emit(dst,OpArityKind.Unary);
        }

        public void binary_truth_emit()
        {
            using var dst = writer(FileName.Define("BinaryTruth.txt"));
            var ops = LogicOpApi.BinaryOpKinds;
            TruthTables.emit(dst,ops);
            TruthTables.emit(dst,OpArityKind.Binary);
        }

        public void ternary_truth_emit()
        {
            using var dst = writer(FileName.Define("TernaryTruth.txt"));
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
            => check_truth(XOr);

        public void check_typed_xor_truth()
            => check_typed_truth(XOr);

        public void check_logical_xnor_truth()
            => check_truth(Xnor);

        public void check_typed_xnor_truth()
            => check_typed_truth(Xnor);

        public void check_logical_imply_truth()
            => check_truth(Implication);

        public void check_typed_imply_truth()
            => check_typed_truth(Implication);

        public void check_logical_notimply_truth()
            => check_truth(Nonimplication);

        public void check_typed_notimply_truth()
            => check_typed_truth(Nonimplication);

        public void check_logical_cimply_truth()
            => check_truth(ConverseImplication);

        public void check_typed_cimply_truth()
            => check_typed_truth(ConverseImplication);

        public void check_logical_cnotimply_truth()
            => check_truth(ConverseNonimplication);

        public void check_typed_cnotimply_truth()
            => check_typed_truth(ConverseNonimplication);

        void check_typed_truth(BinaryBitLogicKind op)
        {               
            const byte on = 1;
            const byte off = 0;

            var dst = BitVector.alloc(n4);
            dst[0] = (byte)(ScalarOpApi.eval(op, off,off) & on) == on;
            dst[1] = (byte)(ScalarOpApi.eval(op, on,off) & on) == on;
            dst[2] = (byte)(ScalarOpApi.eval(op, off,on) & on) == on;
            dst[3] = (byte)(ScalarOpApi.eval(op, on,on) & on) == on;
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
            Trace(TruthTables.definition(BinaryBitLogicKind.And).Format());
            Trace(TruthTables.definition(BinaryBitLogicKind.Or).Format());
            Trace(TruthTables.definition(BinaryBitLogicKind.Nand).Format());        
        }
    }
}