//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IClassifier
    {
        
    }

    public interface IMetaclass
    {
        
    }

    /// <summary>
    /// Metaclassification
    /// </summary>
    public interface IClass : IMetaclass, IClassifier
    {

    }


    /// <summary>
    /// Class reification
    /// </summary>
    public interface IClass<C> : IClass
        where C : IClass<C>, new()
    {

    }

    /// <summary>
    /// Metaclass stratification
    /// </summary>
    public interface IKind : IClassifier
    {
        
    }

    /// <summary>
    /// Kind reification
    /// </summary>
    public interface IKind<K> : IKind
        where K : IKind<K>, new()
    {

    }
}