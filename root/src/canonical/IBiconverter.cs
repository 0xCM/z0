//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    /// <summary>
    /// Characterizes a weakly-byped two-way converter
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
        /// <param name="incoming">The value to conver</param>
        Option<object> ConvertToTarget(object incoming);
        
        /// <summary>
        /// Converts an incoming value of the target type to a value of specified type, if possible
        /// </summary>
        /// <param name="incoming">The value to convert</param>
        Option<object> ConvertFromTarget(object incoming, Type dst);
    }

   /// <summary>
   /// Characterizes a strongly-byped two-way converter
   /// </summary>
    public interface IBiconverter<S> : IBiconverter
    {
        Type IBiconverter.TargetType => typeof(S);
    }
}