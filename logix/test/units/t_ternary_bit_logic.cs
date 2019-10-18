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
    
    using static zfunc;


    public class t_ternary_bit_logic : UnitTest<t_ternary_bit_logic>
    {
        static readonly bit off = bit.Off;
        
        static readonly bit on = bit.On;
        
        void FormatTable()
        {            
            foreach(var op in BitOps.TernaryKinds)
            {
                var tv = truthvector(op);
                var opbs = ((byte)op).ToBitString();
                Trace($"tv({op} := {opbs}) = {tv}");
            }
    
        }

        static BitVector8 truthvector(TernaryLogicOpKind id)
        {
            var op = BitOps.lookup(id);
            var x = BitVector8.Zero;
            x[0] = op(off,off,off);
            x[1] = op(on,off,off);
            x[2] = op(off,on,off);
            x[3] = op(on,on,off);
            x[4] = op(off,off,on);
            x[5] = op(on,off,on);
            x[6] = op(off,on,on);
            x[7] = op(on,on,on);
            return x;
        }



    }




}