//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Characterizes an untyped optional value
    /// </summary>
    public interface IOption
    {

        /// <summary>
        /// True if a value does exists, false otherwise
        /// </summary>
        bool IsSome { get; }

        /// <summary>
        /// True if a value does not exist, false otherwise
        /// </summary>
        bool IsNone { get; }
    }

    /// <summary>
    /// Characterizes an typed optional value
    /// </summary>
    public interface IOption<T> : IOption
    {
        /// <summary>
        /// The encapsualted value, if any
        /// </summary>
        T Value { get; }
    }
}