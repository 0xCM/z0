//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public abstract class t_bitspans<X> : t_bitgrids_base<X>
        where X : t_bitspans<X>, new()
    {

    }
}