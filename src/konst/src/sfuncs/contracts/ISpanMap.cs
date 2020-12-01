//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    partial struct SFx
    {
        /// <summary>
        /// Characterizes a mapping function that carries cells of one span to another
        /// </summary>
        /// <typeparam name="A">The source span cell type</typeparam>
        /// <typeparam name="B">The target span cell type</typeparam>
        [Free, SFx]
        public interface ISpanMap<A,B> : IFunc
        {
            void Invoke(ReadOnlySpan<A> src, Span<B> dst);
        }
    }
}