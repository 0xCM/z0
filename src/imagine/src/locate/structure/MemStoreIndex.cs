//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Konst;

    public struct MemStoreIndex
    {   
        Hex8Kind Current;

        [MethodImpl(Inline)]
        public static MemStoreIndex Init()
            => new MemStoreIndex(FirstKey);        

        [MethodImpl(Inline)]
        public static MemStoreIndex operator++(MemStoreIndex src)
            => src.Advance();

        [MethodImpl(Inline)]
        public static MemStoreIndex operator--(MemStoreIndex src)
            => src.Retreat();

        [MethodImpl(Inline)]
        public static implicit operator byte(MemStoreIndex src)
            => (byte)src.Current;

        [MethodImpl(Inline)]
        public static implicit operator MemStoreIndex(int src)
            => new MemStoreIndex((Hex8Kind)src);

        [MethodImpl(Inline)]
        public static implicit operator MemStoreIndex(byte src)
            => new MemStoreIndex((Hex8Kind)src);

        [MethodImpl(Inline)]
        public MemStoreIndex(Hex8Kind value)
        {
            this.Current = value;
        }        

        [MethodImpl(Inline)]
        public MemStoreIndex Advance()
        {
            if(Current == LastKey)
                Current = FirstKey;
            else
                Current += 1;
            return this;
        }

        [MethodImpl(Inline)]
        public MemStoreIndex Retreat()
        {
            if(Current == FirstKey)
                Current = LastKey;
            else
                Current -= 1;
            return this;
        }

        const Hex8Kind FirstKey = Hex8Kind.x00;

        const Hex8Kind LastKey = Hex8Kind.xff;
    }
}