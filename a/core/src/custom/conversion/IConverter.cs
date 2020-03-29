//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    public interface IConverter
    {
        
    }
    
    /// <summary>
    /// Characterizes a one-way converter
    /// </summary>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    public interface IConverter<in S, out T> : IConverter
    {
        T Convert(S src);
    }   
}