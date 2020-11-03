//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;


    public interface IWfController
    {
        Assembly Component {get;}
    }

    public interface IWfControl<P> : IWfController
        where P : IPart<P>, new()
    {

    }
}