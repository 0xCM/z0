//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public sealed class t_config : UnitTest<t_config>
    {
        public void check_config()
        {
            var index = AppSettings.Load(GetType().Name);
            Claim.eq(index["A_Number"],"400");

        }
    }

}