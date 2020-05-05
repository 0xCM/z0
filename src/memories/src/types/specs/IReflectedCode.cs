//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Characterizes identified code with a known address and defining member
    /// </summary>
    /// <typeparam name="F"></typeparam>
    /// <typeparam name="C"></typeparam>
    public interface IReflectedCode<F,C> : IMemberCode<F,C>
        where F : struct, IEncoded<F,C>
    {
        /// <summary>
        /// The defining member
        /// </summary>
        MethodInfo Method {get;}
    }
}