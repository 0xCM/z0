//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    readonly struct ValueFactoryFlow<S,T> : IValueFactoryFlow<S,T>
        where S : struct
        where T : struct
    {

    }
    
    readonly struct ValueFactoryFlow<P,S,T> : IValueFactoryFlow<P,S,T>
        where S : struct
        where T : struct
        where P : IValueFactoryPipe<S,T>        
    {

    }
}