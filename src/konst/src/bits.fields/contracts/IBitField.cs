//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Characterizes a content-parametric bitfield
    /// </summary>
    /// <typeparam name="T">The bitfield content type</typeparam>
    public interface IBitField<T>
        where T : unmanaged
    {
        /// <summary>
        /// The raw bitfield data
        /// </summary>
        T Content {get;}
    }
}