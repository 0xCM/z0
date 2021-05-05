//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Relations
    {
        /// <summary>
        /// Represents a foreign key
        /// </summary>
        public readonly struct FK<S,T>
            where S : unmanaged
            where T : unmanaged
        {
            public PK<uint,S> Source {get;}

            public PK<uint,T> Target {get;}

            [MethodImpl(Inline)]
            public FK(PK<uint,S> src, PK<uint,T> dst)
            {
                Source = src;
                Target = dst;
            }

            [MethodImpl(Inline)]
            public FK(uint src, uint dst)
            {
                Source = src;
                Target = dst;
            }

            [MethodImpl(Inline)]
            public static implicit operator FK<S,T>((uint src, uint dst) x)
                => new FK<S,T>(x.src,x.dst);
        }
    }
}