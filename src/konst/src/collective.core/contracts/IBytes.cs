//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IBytes : INullity, ITextual
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

    [Free]
    public interface IBytes<F> : IBytes
        where F : struct, IBytes<F>
    {
    }

    [Free]
    public interface IBytes<F,N> : IBytes<F>, IEquatable<F>, INullary<F>
        where N : unmanaged, ITypeNat
        where F : struct, IBytes<F,N>
    {
        int IBytes.Capacity
            => (int)TypeNats.value<N>();
    }
}