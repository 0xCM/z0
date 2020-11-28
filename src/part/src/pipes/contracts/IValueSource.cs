//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static memory;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes an unlimited value emitter that produces one value at a time
    /// </summary>
    /// <typeparam name="T">The production value type</typeparam>
    [Free]
    public interface IValueSource<T> : ISource<T>
        where T : struct
    {

    }

    [Free]
    public interface IValueSource
    {
        /// <summary>
        /// Retrieves the next point from the source, bound only by the domain of the type
        /// </summary>
        /// <typeparam name="T">The point type</typeparam>
        T Next<T>()
            where T : struct;

        bool Next<T>(out T dst)
            where T : struct
        {
            dst = Next<T>();
            return true;
        }

        void Fill<T>(Span<T> dst)
            where T : struct
        {
            var count = dst.Length;
            if(count != 0)
            {
                ref var target = ref first(dst);
                for(var i=0; i<count; i++)
                    seek(target,i) = Next<T>();
            }
        }
    }
}