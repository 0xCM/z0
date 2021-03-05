//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;


    public class BitsTestApp : TestApp<BitsTestApp>
    {
        static void Main(params string[] args)
        {
            if(args.Length != 0)
                RunSelected(args);
            else
                 Run(args);
        }
    }
}
