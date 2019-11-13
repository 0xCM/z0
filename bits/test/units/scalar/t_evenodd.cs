//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static BitParts;
        
    public class t_evenodd : ScalarBitTest<t_evenodd>
    {

        public void even_64()
        {
            for(var i=0; i<SampleSize; i++)
            {
                BitVector64 x = Random.BitVector(n64);
                BitVector32 y = (uint)BitParts.select(x, Even64.Select);
                BitVector32 z = default;

                for(int j=0, k = 0; j<64; j+=2, k++)
                    z[k] = x[j];

                Claim.eq(z, y);

            }
            
        }

        public void odd_64()
        {
            for(var i=0; i<SampleSize; i++)
            {
                BitVector64 x = Random.BitVector(n64);
                BitVector32 y = (uint)BitParts.select(x, Odd64.Select);
                BitVector32 z = default;

                for(int j=1, k = 0; j<64; j+=2, k++)
                    z[k] = x[j];

                Claim.eq(z, y);
            }
        }
    }

}