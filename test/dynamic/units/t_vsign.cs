//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;


    public class t_vsign : t_dynamic<t_vsign>
    {
        public void check_vsign_8i()
        {
            var fp = Pointers.fptr<BinaryOp<uint>>(math.add);
            term.print(fp.P);
        }
    }
}