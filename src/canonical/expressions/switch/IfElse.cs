//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    partial class AsmExpr
    {
        [Op, MethodImpl(NotInline)]
        public uint f1(uint a, uint b)
        {
            if(a > b)
                return f6(a,b);
            else if(a < b)
                return f7(a,b);
            else if(a == b)
                return f8(a,b);
            else
                return 0xAAFFAA;        
        }


        [Op, MethodImpl(NotInline)]
        public uint f2(uint a, uint b)
            => a == b ? f6(a,b) : f7(a,b);
        

        [Op, MethodImpl(NotInline)]
        public uint f6(uint a, uint b)
            => a*a + b*b + 19;            

        [Op, MethodImpl(NotInline)]
        public uint f7(uint a, uint b)
            => a*b + 13;


        [Op, MethodImpl(NotInline)]
        public uint f8(uint a, uint b)
            => a - b + 9;
    }
}