//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes a weakly-typed two-way converter
    /// </summary>
    public interface IBiconverter : IConverter
    {
        /// <summary>
        /// The supported type
        /// </summary>
        Type TargetType {get;}

        /// <summary>
        /// Converts an incoming value to a value of target type, if possible
        /// </summary>
        /// <param name="src">The value to convert</param>
        Option<object> ConvertToTarget(object src);

        /// <summary>
        /// Converts an incoming value of the target type to a value of specified type, if possible
        /// </summary>
        /// <param name="src">The value to convert</param>
        Option<object> ConvertFromTarget(object src, Type dst);
    }

   /// <summary>
   /// Characterizes a strongly-typed two-way converter
   /// </summary>
    public interface IBiconverter<S> : IBiconverter
    {
        Type IBiconverter.TargetType
            => typeof(S);

        T Convert<T>(S src);

        S Convert<T>(T src);
    }
}