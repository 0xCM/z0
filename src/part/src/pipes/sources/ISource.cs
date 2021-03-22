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
    /// Characterizes a point emitter
    /// </summary>
    [Free]
    public interface ISource
    {
        /// <summary>
        /// Retrieves the next value from the source
        /// </summary>
        /// <typeparam name="T">The value type</typeparam>
        T Next<T>();

        bool Next<T>(out T dst)
        {
            dst = Next<T>();
            return true;
        }

        uint Fill<T>(Span<T> dst)
        {
            var count = (uint)dst.Length;
            if(count != 0)
            {
                ref var target = ref first(dst);
                for(var i=0; i<count; i++)
                    seek(target,i) = Next<T>();
            }
            return count;
        }
    }

    /// <summary>
    /// Characterizes an unlimited emitter
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
        uint Fill(Span<T> dst)
        {
            var count = (uint)dst.Length;
            if(count != 0)
            {
                ref var target = ref first(dst);
                for(var i=0u; i<count; i++)
                    if(!Next(out target))
                        return i;
            }
            return count;
        }
    }

    [Free]
    public interface ISource<H,T> : ISource<T>
        where H : struct, ISource<H,T>
    {

    }
}