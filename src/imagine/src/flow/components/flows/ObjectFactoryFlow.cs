//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    readonly struct ObjectFactoryFlow<P,S,T> : IObjectFactoryFlow<P,S,T>
        where S : class
        where T : class
        where P : IObjectFactoryPipe<S,T>        
    {

    }
}