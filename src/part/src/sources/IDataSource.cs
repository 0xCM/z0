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
    public interface IDataSource
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

    /// <summary>
    /// Characterizes an unlimited emitter
    /// </summary>
    /// <typeparam name="T">The production element type</typeparam>
    [Free]
    public interface IDataSource<T>
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
        int Fill(Span<T> dst)
        {
            var count = dst.Length;
            if(count != 0)
            {
                ref var target = ref first(dst);
                for(var i=0; i<count; i++)
                    if(!Next(out target))
                        return i;
            }
            return count;
        }
    }

    [Free]
    public interface IDataSource<H,T> : IDataSource<T>
        where H : struct, IDataSource<H,T>
    {

    }
}