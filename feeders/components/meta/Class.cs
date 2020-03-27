//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IMetaclass
    {
        
    }

    public interface IClassifier : IMetaclass
    {
        
    }

    /// <summary>
    /// Metaclassification
    /// </summary>
    public interface IClass :  IClassifier
    {

    }

    /// <summary>
    /// Class reification
    /// </summary>
    public interface IClass<C> : IClass
        where C : IClass<C>, new()
    {

    }


}