//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Linq;

    using static Part;

    public readonly struct ApiProjector<S,T>
        where S : IDataType<S>
        where T : IDataType<T>
    {
        public ApiClass Class {get;}
    }


    public readonly struct ApiDataType<T>
        where T : IDataType<T>
    {

    }


}