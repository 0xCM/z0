//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Root interface for value production services
    /// </summary>
    [Free]
    public interface ISource
    {

    }

    /// <summary>
    /// Characterizes an unlimited emitter that produces one element at a time
    /// </summary>
    /// <typeparam name="T">The production element type</typeparam>
    [Free]
    public interface ISource<T>
    {
        /// <summary>
        /// Retrieves the next item from the source
        /// </summary>
        T Next();

        bool Next(out T dst)
        {
            dst = Next();
            return true;
        }
    }

    [Free]
    public interface IDataSource<T> : ISource<T>
        where T : struct
    {
        T ISource<T>.Next()
        {
            Next(out var dst);
            return dst;
        }
    }
}