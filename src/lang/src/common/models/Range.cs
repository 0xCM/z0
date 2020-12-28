//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Represents a range expression
    /// </summary>
    public readonly struct Range<S,T>
        where S : unmanaged
    {
        public S LeftFence {get;}

        public S RightFence {get;}

        public S Delimiter {get;}

        public T FirstValue {get;}

        public T LastValue {get;}

        public Range(Pair<S> fence, Pair<T> bounds, S delimiter)
        {
            LeftFence = fence.Left;
            RightFence = fence.Right;
            Delimiter = delimiter;
            FirstValue = bounds.Left;
            LastValue = bounds.Right;
        }
    }
}