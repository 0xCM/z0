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

        /// <summary>
        /// Fills the span, from stem-to-stern with <typeparamref name='T'/> cells from the reifying source
        /// </summary>
        /// <param name="dst">The target spen</param>
        void Fill(Span<T> dst)
        {
            var count = dst.Length;
            if(count != 0)
            {
                ref var target = ref first(dst);
                for(var i=0; i<count; i++)
                    seek(target,i) = Next();
            }
        }
    }

    [Free]
    public interface ISource
    {
        /// <summary>
        /// Retrieves the next point from the source, bound only by the domain of the type
        /// </summary>
        /// <typeparam name="T">The point type</typeparam>
        T Next<T>();

        bool Next<T>(out T dst)
        {
            dst = Next<T>();
            return true;
        }

        void Fill<T>(Span<T> dst)
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