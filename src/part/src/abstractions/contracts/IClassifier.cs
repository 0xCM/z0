//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes a discriminator
    /// </summary>
    public interface IClassifier
    {
        /// <summary>
        /// The discriminating value
        /// </summary>
        IClassValue[] ClassValues {get;}

        /// <summary>
        /// The discriminator type
        /// </summary>
        Type ClassType {get;}
    }

    /// <summary>
    /// Characterizes a parametric discriminator
    /// </summary>
    public interface IClassifier<C> : IClassifier
        where C : IClassValue<C>
    {
        new C[] ClassValues {get;}

        IClassValue[] IClassifier.ClassValues
            => ClassValues.Select(x => (IClassValue)x);

        Type IClassifier.ClassType
            => typeof(C);
    }
}