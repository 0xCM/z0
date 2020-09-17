//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Konst;

    /// <summary>
    /// Defines a memory store index
    /// </summary>
    public struct MemorySlot
    {   
        Hex8Kind Index;

        [MethodImpl(Inline)]
        public static MemorySlot Init()
            => new MemorySlot(FirstKey);        

        [MethodImpl(Inline)]
        public static MemorySlot operator++(MemorySlot src)
            => src.Advance();

        [MethodImpl(Inline)]
        public static MemorySlot operator--(MemorySlot src)
            => src.Retreat();

        [MethodImpl(Inline)]
        public static implicit operator byte(MemorySlot src)
            => (byte)src.Index;

        [MethodImpl(Inline)]
        public static implicit operator MemorySlot(int src)
            => new MemorySlot((Hex8Kind)src);

        [MethodImpl(Inline)]
        public static implicit operator MemorySlot(byte src)
            => new MemorySlot((Hex8Kind)src);

        [MethodImpl(Inline)]
        public MemorySlot(Hex8Kind value)
            => Index = value;

        [MethodImpl(Inline)]
        public MemorySlot Advance()
        {
            if(Index == LastKey)
                Index = FirstKey;
            else
                Index += 1;
            return this;
        }

        [MethodImpl(Inline)]
        public MemorySlot Retreat()
        {
            if(Index == FirstKey)
                Index = LastKey;
            else
                Index -= 1;
            return this;
        }

        const Hex8Kind FirstKey = Hex8Kind.x00;

        const Hex8Kind LastKey = Hex8Kind.xff;
    }
}