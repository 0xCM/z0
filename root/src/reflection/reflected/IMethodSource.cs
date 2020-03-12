//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Linq;

    using static Root;

    public interface IMethodSource
    {
        MethodInfo Method {get;}
    }

    public interface IMethodSource<S> : IMethodSource
        where S : IMethodSource<S>
    {

        
    }

    public interface IMethodStreamSource
    {

        IEnumerable<MethodInfo> Methods {get;}
    }

    public interface IMethodStreamSource<S> : IMethodStreamSource
        where S : IMethodStreamSource<S>

    {

    }

}