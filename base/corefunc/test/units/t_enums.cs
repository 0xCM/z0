//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;
    using static zfunc;

    using static t_enums.Choices8u;

    public sealed class t_enums : UnitTest<t_enums>
    {
        public enum Choices8u : byte
        {
            C0, C1, C2, C3, C4, C5
        }

        public enum Choices32i : int
        {
            C0 = 1,  C1 = 2, C2 = C1*2, C3 = C2*2, 
            C4 = C3*2, C5 = C4*2, C6 = C5*2, C7 = C6*2,
            C99 = byte.MaxValue,
        
        }

        public void check_zfunc()
        {
            var values = lpairs<Choices32i,int>();
            Claim.eq(Enum.GetValues(typeof(Choices32i)).Length, values.Length);

            for(var i = 0; i<values.Length; i++)
            {
                var ival = values[i].B;
                if(ival == byte.MaxValue)
                    break;

                var member = literal<Choices32i,int>(ival);
                Claim.eq(member, values[i].A);

                var expect = (int)Math.Pow(2,i);
                if(expect != ival)
                    Trace($"{values[i]} = {ival} != {expect}");
                Claim.eq(expect, ival);                            
            }
        }
    }
}