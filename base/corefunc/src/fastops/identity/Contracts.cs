//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;

    using static zfunc;


    public interface IOpSpecifier<S>    
        where S : OpSpec
    {
        IEnumerable<S> FromHost(Type host);
    }    
}
