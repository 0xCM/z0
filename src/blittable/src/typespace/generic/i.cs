//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace types.generic
{
    using System.Runtime.CompilerServices;

    using static Z0.Root;

    using traits;

    public struct i<S> : I<S>
        where S : unmanaged
    {
        public S Storage;

        public uint N;

        [MethodImpl(Inline)]
        public i(S src, uint n)
        {
            Storage = src;
            N = n;
        }

        uint Scalar.N
            => N;

        S Type<S>.Storage
            => Storage;
    }
}