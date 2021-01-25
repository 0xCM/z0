//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IByteSeq : INullity, ITextual
    {
        /// <summary>
        /// The sequence presented as an encoded byte span
        /// </summary>
        ReadOnlySpan<byte> View {get;}

        /// <summary>
        /// The maximum number of asci characters the sequence can cover
        /// </summary>
        int Capacity {get;}

        /// <summary>
        /// Specifies the number of characters that precede a null terminator, if any; otherwise, returns the capacity
        /// </summary>
        int Length {get;}
    }

    /// <summary>
    /// Characterizes a container that reifies an asci sequence
    /// </summary>
    /// <typeparam name="A">The asci sequence type</typeparam>
    [Free]
    public interface IByteSeq<A> : IByteSeq, IContented<A>
        where A : unmanaged, IByteSeq
    {
        int IByteSeq.Length
            => Content.Length;

        int IByteSeq.Capacity
            => Content.Capacity;

        ReadOnlySpan<byte> IByteSeq.View
            => Content.View;

        bool INullity.IsEmpty
            => Content.IsEmpty;
    }

    [Free]
    public interface IBytes<F> : IByteSeq
        where F : struct, IBytes<F>
    {
    }

    [Free]
    public interface IBytes<F,N> : IBytes<F>, IEquatable<F>, INullary<F>
        where N : unmanaged, ITypeNat
        where F : struct, IBytes<F,N>
    {
        int IByteSeq.Capacity
            => Length;

        int IByteSeq.Length
            => (int)default(N).NatValue;

        F INullary<F>.Zero
            => default;
    }

    [Free]
    public interface IBytes<F,C,N> : IBytes<F,N>, IContented<C>
        where N : unmanaged, ITypeNat
        where F : struct, IBytes<F,N>
    {

    }
}