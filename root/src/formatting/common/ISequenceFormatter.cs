//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static RootShare;

    /// <summary>
    /// Base interface for formatters that format sequences of formattable things
    /// </summary>
    /// <typeparam name="T">The sequence element type</typeparam>
    public interface ISequenceFormatter<T> : IFormatter
        where T : IFormattable<T>
    {
        string Delimiter {get;}
    }     
}