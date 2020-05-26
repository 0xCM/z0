//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    using static Seed;
    using static Memories;
    
    public abstract class t_asmd<U> : UnitTest<U,CheckVectorBits, ICheckVectorBits>
        where U : t_asmd<U>, new()
    {     

    }
}
