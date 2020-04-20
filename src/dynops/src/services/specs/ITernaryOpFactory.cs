//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public interface ITernaryOpFactory<T> : IOperatorFactory<Func<T,T,T,T>,T>
    {

    }

}