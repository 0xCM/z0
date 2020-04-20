//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    interface IInnerContext : IContext
    {
        OpIdentity Identify(MethodInfo src);

        TypeIdentity Identify(Type src);

        OpIdentity Identify(Delegate src);
    }
}