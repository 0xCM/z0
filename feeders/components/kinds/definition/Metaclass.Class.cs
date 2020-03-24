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

    public interface IClassifier
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
    /// Characterizes type classifiers predicated on enumerations
    /// </summary>
    /// <typeparam name="E">The enum type defining potential classifications</typeparam>
    public interface ITypeLevelEnum<E> : IClassifier
        where E : unmanaged, Enum
    {
        E Class {get;}

        string Name => Class.ToString().ToLower();
    }
}