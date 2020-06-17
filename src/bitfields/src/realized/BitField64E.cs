//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct BitField64<E> : ITextual
        where E : unmanaged, Enum
    {
        ulong State;

        [MethodImpl(Inline)]
        public static BitField64<E> Define(E state)
            => new BitField64<E>(state);

        [MethodImpl(Inline)]
        BitField64(E state)
        {
            State = Enums.e64u(state);            
        }

        /// <summary>
        /// Determines whether an index-identified bit is enabled
        /// </summary>
        /// <param name="index">An integer in the range [0,63]</param>
        [MethodImpl(Inline)]
        public bit Test(byte index)
            => math.nonz(math.and(math.pow2(index), State));

        /// <summary>
        /// Enables or disables an index-identified bit
        /// </summary>
        /// <param name="index">An integer in the range [0,63]</param>
        /// <param name="state">If 1, turns the bit on; otherwise, the bit is turned off</param>
        [MethodImpl(Inline)]
        public void Set(byte index, bit state)
        {
            if(state)
                Enable(index);
            else
                Disable(index);
        }

        /// <summary>
        /// Enables an index-identified bit
        /// </summary>
        /// <param name="index">An integer in the range [0,63]</param>
        [MethodImpl(Inline)]
        public void Enable(byte index)
            => State = Bits.enable(State,index);

        /// <summary>
        /// Enables an index-identified bit
        /// </summary>
        /// <param name="index">An integer in the range [0,63]</param>
        [MethodImpl(Inline)]
        public void Disable(byte index)
            => State = Bits.disable(State, index);

        [MethodImpl(Inline)]
        public byte Index(E src)
            => (byte)math.log2(Enums.e64u(src));

        public bit this[byte i]
        {
            [MethodImpl(Inline)]
            get => Test(i);

            [MethodImpl(Inline)]
            set => Set(i,value);
        }

        public string Format()        
             => Formatters.bits<ulong>().Format(State);
        
        public override string ToString()
            => Format();
    }    
}