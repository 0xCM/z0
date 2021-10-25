//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Flows
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct flows
    {
        /// <summary>
        /// Creates a <see cref='Flow{S,T}'/> from a specified source to a specified target;
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static Flow<S,T> flow<S,T>(in S src, in T dst)
            where S : IChannel
            where T : IChannel
                => new Flow<S,T>(src,dst);

        [MethodImpl(Inline)]
        public static Flow<K,S,T> flow<K,S,T>(K kind, in S src, in T dst)
            where K : unmanaged
            where S : IChannel
            where T : IChannel
                => new Flow<K,S,T>(kind,src,dst);
    }
}