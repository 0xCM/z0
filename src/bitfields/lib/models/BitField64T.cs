//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;


    public struct BitField64<T> : ITextual
        where T : unmanaged
    {
        ulong State;

        [MethodImpl(Inline)]
        public BitField64(T state)
            => State = uint64(state);

        /// <summary>
        /// Enables an index-identified bit
        /// </summary>
        /// <param name="index">An integer in the range [0,63]</param>
        [MethodImpl(Inline)]
        public void Enable(byte index)
            => State = enable(State,index);

        /// <summary>
        /// Enables an index-identified bit
        /// </summary>
        /// <param name="index">An integer in the range [0,63]</param>
        [MethodImpl(Inline)]
        public void Disable(byte index)
            => State = disable(State, index);

        /// <summary>
        /// Enables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        static ulong enable(ulong src, byte pos)
            =>  src |= (1ul << pos);

        [MethodImpl(Inline)]
        static ulong disable(ulong src, byte pos)
            => src & ~((1ul << pos));

        [MethodImpl(Inline)]
        public byte Index(T src)
            => (byte)Pow2.log2(uint64(src));

        [MethodImpl(Inline)]
        public string Format()
             => BitFormatter.create<ulong>().Format(State);

        public override string ToString()
            => Format();
    }
}