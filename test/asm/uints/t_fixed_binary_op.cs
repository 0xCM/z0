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
 
    using FK = FixedOpKinds;

    public class t_fixed_binary_op : t_asm<t_fixed_binary_op>
    {
        ITestFixedBinaryOp Checker => CheckFixed.BinaryOp(Random);
        
        void check_fixed_lists()
        {

            var kinds = FixedOpKinds.Known.ToArray();
            Control.iter(kinds, k => Trace(k));
        }
    }
}
