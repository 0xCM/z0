//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Root;

    public interface IValueConverter : IConverter
    {

    }

    public interface IValueConveter<in S, out T> : IValueConverter, IConverter<S,T>
        where S: struct
        where T: struct
    {
        
    }

    public interface IValueConverter<S> : IBiconverter<S>
        where S : struct
    {
        /// <summary>
        /// Converts an incoming value of the target type to a value of specified type, if possible
        /// </summary>
        /// <param name="incoming">The value to convert</param>
        T Convert<T>(S incoming)
            where T : struct;
        
        /// <summary>
        /// converts an incoming value to a value of target type
        /// </summary>
        /// <param name="incoming">The value to convert</param>
        /// <typeparam name="T">The incoming value type</typeparam>
        S Convert<T>(T incoming)
            where T : struct;
    }
}