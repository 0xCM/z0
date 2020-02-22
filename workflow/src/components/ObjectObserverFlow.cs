//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Threading.Tasks;

    using static zfunc;

    readonly struct ObjectObserverFlow<T> : IObjectObserverFlow<T>
        where T : class
    {

    }

    readonly struct ObjectObserverFlow<P, T> : IObjectObserverFlow<P, T>
        where T : class
        where P : IObjectObserverPipe<T>
    {

    }    
}