//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes a container that reifies an asci sequence
    /// </summary>
    /// <typeparam name="A">The asci sequence type</typeparam>
    public interface IByteContainer<A> : IBytes, IContented<A>
        where A : unmanaged, IBytes
    {
        int IBytes.Length
            => Content.Length;

        int IBytes.Capacity
            => Content.Capacity;

        ReadOnlySpan<byte> IBytes.View
            => Content.View;

        bool INullity.IsEmpty
            => Content.IsEmpty;
    }
}