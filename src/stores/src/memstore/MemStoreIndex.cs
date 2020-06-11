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
        MemStoreKey Current;

        [MethodImpl(Inline)]
        public static MemStoreIndex Init()
            => new MemStoreIndex(FirstKey);
        
        const MemStoreKey FirstKey = MemStoreKey.k00;

        const MemStoreKey LastKey = MemStoreKey.k0f;

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
            => new MemStoreIndex((MemStoreKey)src);

        [MethodImpl(Inline)]
        public static implicit operator MemStoreIndex(byte src)
            => new MemStoreIndex((MemStoreKey)src);

        [MethodImpl(Inline)]
        public MemStoreIndex(MemStoreKey value)
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
    }
}