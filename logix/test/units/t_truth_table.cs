//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static zfunc;
    using static TypedLogicSpec;
    using static BitLogicSpec;

    public class t_truth_table : UnitTest<t_truth_table>
    {
        const byte off = 0;
        const byte on = 1;


        public void truth_emit()
        {
            unary_truth_emit();
            binary_truth_emit();
            ternary_truth_emit();
        }

        public void signature_check()
        {
            foreach(var op in LogicOpApi.UnaryOpKinds)
            {
                var table = TruthTables.Build(op);
                var result = table.GetCol(table.ColCount - 1).ToPrimal(n8).Lo;
                var sig = TruthTables.Signature(op);
                Claim.eq(result,sig);
            }

            foreach(var op in LogicOpApi.BinaryOpKinds)
            {
                var table = TruthTables.Build(op);
                var result = table.GetCol(table.ColCount - 1).ToPrimal(n8).Lo;
                var sig = TruthTables.Signature(op);
                Claim.eq(result,sig);
            }

            foreach(var op in LogicOpApi.TernaryOpKinds)
            {
                var table = TruthTables.Build(op);
                var result = table.GetCol(table.ColCount - 1).ToPrimal(n8);
                var sig = TruthTables.Signature(op);
                Claim.eq(result,sig);
            }

        }

        public void check_logical_and_truth()
            => check_truth(BinaryLogicOpKind.And);

        public void check_typed_and_truth()
            => check_truth(BinaryBitwiseOpKind.And);

        public void check_logical_nand_truth()
            => check_truth(BinaryLogicOpKind.Nand);

        public void check_typed_nand_truth()
            => check_truth(BinaryBitwiseOpKind.Nand);

        public void check_logical_or_truth()
            => check_truth(BinaryLogicOpKind.Or);

        public void check_typed_or_truth()
            => check_truth(BinaryBitwiseOpKind.Or);

        public void check_logical_nor_truth()
            => check_truth(BinaryLogicOpKind.Nor);

        public void check_typed_nor_truth()
            => check_truth(BinaryBitwiseOpKind.Nor);

        public void check_logical_xor_truth()
            => check_truth(BinaryLogicOpKind.XOr);

        public void check_typed_xor_truth()
            => check_truth(BinaryBitwiseOpKind.XOr);

        public void check_logical_xnor_truth()
            => check_truth(BinaryLogicOpKind.Xnor);

        public void check_typed_xnor_truth()
            => check_truth(BinaryBitwiseOpKind.Xnor);

        public void check_logical_imply_truth()
            => check_truth(BinaryLogicOpKind.Implication);

        public void check_typed_imply_truth()
            => check_truth(BinaryBitwiseOpKind.Implication);

        public void check_logical_notimply_truth()
            => check_truth(BinaryLogicOpKind.Nonimplication);

        public void check_typed_notimply_truth()
            => check_truth(BinaryBitwiseOpKind.Nonimplication);

        public void check_logical_cimply_truth()
            => check_truth(BinaryLogicOpKind.ConverseImplication);

        public void check_typed_cimply_truth()
            => check_truth(BinaryBitwiseOpKind.ConverseImplication);

        public void check_logical_cnotimply_truth()
            => check_truth(BinaryLogicOpKind.ConverseNonimplication);

        public void check_typed_cnotimply_truth()
            => check_truth(BinaryBitwiseOpKind.ConverseNonimplication);

        void check_truth(BinaryBitwiseOpKind op)
        {               
            var dst = BitVector4.Alloc();
            dst[0] = (byte)(ScalarOpApi.eval(op, off,off) & on) == on;
            dst[1] = (byte)(ScalarOpApi.eval(op, on,off) & on) == on;
            dst[2] = (byte)(ScalarOpApi.eval(op, off,on) & on) == on;
            dst[3] = (byte)(ScalarOpApi.eval(op, on,on) & on) == on;
            var sig = TruthTables.Signature(op.ToLogical());
            Claim.eq(sig,dst);
        }
        
        void check_truth(BinaryLogicOpKind op)
        {
            var dst = BitVector4.Alloc();
            dst[0] = LogicOpApi.eval(op, bit.Off,bit.Off);
            dst[1] = LogicOpApi.eval(op, bit.On,bit.Off);
            dst[2] = LogicOpApi.eval(op, bit.Off,bit.On);
            dst[3] = LogicOpApi.eval(op, bit.On,bit.On);
            var sig = TruthTables.Signature(op);
            Claim.eq(sig,dst);
        }

        public void xor1_truth_emit()
        {
            using var dst = LogArea.Test.LogWriter(FileName.Define("Xor1Truth.txt"));

            var rows = RowBits.alloc<byte>(255);
            for(var i=0u; i<255; i++)
            {
                BitVector8 input = (byte)i;
                BitVector8 output = (byte)ScalarOps.xor1(i);   
                dst.Write(input.Format());
                dst.Write(AsciSym.Space);
                dst.Write(AsciSym.Pipe);
                dst.Write(AsciSym.Space);
                dst.Write(output.Format());
                dst.WriteLine();                                
            }
            

        }

        void unary_truth_emit()
        {
            using var dst = LogArea.Test.LogWriter(FileName.Define("UnaryTruth.txt"));
            var ops = LogicOpApi.UnaryOpKinds;
            TruthTables.Emit(dst,ops);
            TruthTables.Emit(dst,OpArityKind.Unary);
        }

        void binary_truth_emit()
        {
            using var dst = LogArea.Test.LogWriter(FileName.Define("BinaryTruth.txt"));
            var ops = LogicOpApi.BinaryOpKinds;
            TruthTables.Emit(dst,ops);
            TruthTables.Emit(dst,OpArityKind.Binary);
        }

        void ternary_truth_emit()
        {
            using var dst = LogArea.Test.LogWriter(FileName.Define("TernaryTruth.txt"));
            var ops = LogicOpApi.TernaryOpKinds;
            TruthTables.Emit(dst,ops);
            TruthTables.Emit(dst,OpArityKind.Ternary);
        }

        void render_check()
        {
            var v1 = variable("a");
            var v2 = variable("b");
            var expr1 = and(v1,v2);
            var expr4 = xnor(v1,v2);
            var expr2 = and(expr1,expr4);
            var expr3 = not(expr2);
            Trace(expr1.Format());
            Trace(expr2.Format());
            Trace(expr3.Format());
        }


    }

}