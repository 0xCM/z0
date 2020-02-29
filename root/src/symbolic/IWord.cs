//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;    
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static Root;


    public interface IWord<W,A> : ISymbolic
        where A : struct, IAlphabet<A>
        where W : struct, IWord<W,A> 
    {

    }

}
