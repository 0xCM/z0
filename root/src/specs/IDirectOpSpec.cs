//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static RootShare;

    public interface IDirectOpSpec : IOpSpec
    {
        MethodInfo ConcreteMethod {get;}        

        MethodInfo IOpSpec.Subject
            => ConcreteMethod;
    }

}