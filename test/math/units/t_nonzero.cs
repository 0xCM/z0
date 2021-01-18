//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;


    public class t_nonzero : t_numeric<t_nonzero>
    {
        public void nonzero_create()
        {
            Claim.nonzero(nonzero.create(0u).Value);
            Claim.eq(nonzero.create(5), 5);
        }
    }
}