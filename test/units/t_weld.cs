//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static zfunc;

    public static class DataBlock
    {

    }

    public struct Block128
    {
        ulong x0;

        ulong x1;

        public Block128(ulong x0, ulong x1)
        {
            this.x0 = x0;
            this.x1 = x1;
        }
    }

    public class t_weld : UnitTest<t_weld>
    {        

        public void rotl()
        {
            (var x0, var y0) = Random.NextPair<ulong>();

            

        }
    }
}
