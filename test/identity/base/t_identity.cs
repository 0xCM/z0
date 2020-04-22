//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    public abstract class t_identity<U> : UnitTest<U,CheckVectors,ICheckVectors>
        where U : t_identity<U>
    {
        
    }
}