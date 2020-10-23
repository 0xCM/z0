//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Reflection;
    using System.Linq;

    using static Konst;

    public class t_fixed_binary_op : t_asm<t_fixed_binary_op>
    {
        TTestFixedBinaryOp Checker => CheckFixed.BinaryOp(Random);

        void check_fixed_lists()
        {

            var kinds = CellOpKinds.kinds();
            Root.iter(kinds, k => Trace(k));
        }
    }
}
