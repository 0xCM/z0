//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IValueSource : ISource
    {
        /// <summary>
        /// Retrieves the next point from the source, bound only by the domain of the type
        /// </summary>
        /// <typeparam name="T">The point type</typeparam>
        T Next<T>()
            where T : struct;
    }

    /// <summary>
    /// Characterizes an unlimited value emitter that produces one value at a time
    /// </summary>
    /// <typeparam name="T">The production value type</typeparam>
    [Free]
    public interface IValueSource<T> : ISource<T>
        where T : struct
    {

    }

}