//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.IO;
    
    using static zfunc;


    public class t_tables : UnitTest<t_tables>
    {

        public void binary_logic_check()
        {
            using var dst = LogArea.Test.LogWriter(FileName.Define("BinaryTruth.txt"));
            var ops = BitOpApi.BinaryKinds.ToArray();
            TruthTable.Emit(dst,ops);
            TruthTable.Emit(dst,OpArityKind.Binary);
        }

        public void ternary_logic_check()
        {
            using var dst = LogArea.Test.LogWriter(FileName.Define("TernaryTruth.txt"));
            var ops = BitOpApi.TernaryKinds.ToArray();
            TruthTable.Emit(dst,ops);
            TruthTable.Emit(dst,OpArityKind.Ternary);

        }

        public void signature_check()
        {
            foreach(var op in BitOpApi.BinaryKinds)
            {
                var table = TruthTable.Build(op);
                var result = table.GetCol(table.ColCount - 1).ToPrimal(n8).Lo;
                var sig = TruthTable.Signature(op);
                Claim.eq(result,sig);
            }

            foreach(var op in BitOpApi.TernaryKinds)
            {
                var table = TruthTable.Build(op);
                var result = table.GetCol(table.ColCount - 1).ToPrimal(n8);
                var sig = TruthTable.Signature(op);
                Claim.eq(result,sig);
            }

        }



    }

}