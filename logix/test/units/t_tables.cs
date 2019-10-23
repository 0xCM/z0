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
    using System.IO;
    using static BitLogicSpec;
    
    using static zfunc;


    public class t_tables : UnitTest<t_tables>
    {

        public void render_check()
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

        public void binary_logic_check()
        {
            using var dst = LogArea.Test.LogWriter(FileName.Define("BinaryTruth.txt"));
            var ops = LogicOpApi.BinaryKinds.ToArray();
            TruthTable.Emit(dst,ops);
            TruthTable.Emit(dst,OpArityKind.Binary);
        }

        public void ternary_logic_check()
        {
            using var dst = LogArea.Test.LogWriter(FileName.Define("TernaryTruth.txt"));
            var ops = LogicOpApi.TernaryKinds.ToArray();
            TruthTable.Emit(dst,ops);
            TruthTable.Emit(dst,OpArityKind.Ternary);

        }

        public void signature_check()
        {
            foreach(var op in LogicOpApi.BinaryKinds)
            {
                var table = TruthTable.Build(op);
                var result = table.GetCol(table.ColCount - 1).ToPrimal(n8).Lo;
                var sig = TruthTable.Signature(op);
                Claim.eq(result,sig);
            }

            foreach(var op in LogicOpApi.TernaryKinds)
            {
                var table = TruthTable.Build(op);
                var result = table.GetCol(table.ColCount - 1).ToPrimal(n8);
                var sig = TruthTable.Signature(op);
                Claim.eq(result,sig);
            }

        }



    }

}