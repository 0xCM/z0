//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
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