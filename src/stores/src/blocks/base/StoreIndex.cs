//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Seed;

    public enum StoreKey : byte
    {
        k00 = 0,

        k01 = 1,

        k02 = 2,

        k03 = 3,

        k04 = 4,

        k05 = 5,

        k06 = 6,

        k07 = 7,

        k08 = 8,

        k09 = 9,

        k0a = 0xA,

        k0b = 0xB,

        k0c = 0xC,

        k0d = 0xD,

        k0e = 0xE,

        k0f = 0xF,

    }
    
    public struct StoreIndex
    {   
        StoreKey Current;

        [MethodImpl(Inline)]
        public static StoreIndex Init()
            => new StoreIndex(FirstKey);
        
        const StoreKey FirstKey = StoreKey.k00;

        const StoreKey LastKey = StoreKey.k0f;

        [MethodImpl(Inline)]
        public static StoreIndex operator++(StoreIndex src)
            => src.Advance();

        [MethodImpl(Inline)]
        public static StoreIndex operator--(StoreIndex src)
            => src.Retreat();

        [MethodImpl(Inline)]
        public static implicit operator byte(StoreIndex src)
            => (byte)src.Current;

        [MethodImpl(Inline)]
        public static implicit operator StoreIndex(int src)
            => new StoreIndex((StoreKey)src);

        [MethodImpl(Inline)]
        public static implicit operator StoreIndex(byte src)
            => new StoreIndex((StoreKey)src);

        [MethodImpl(Inline)]
        public StoreIndex(StoreKey value)
        {
            this.Current = value;
        }        

        [MethodImpl(Inline)]
        public StoreIndex Advance()
        {
            if(Current == LastKey)
                Current = FirstKey;
            else
                Current += 1;
            return this;
        }

        [MethodImpl(Inline)]
        public StoreIndex Retreat()
        {
            if(Current == FirstKey)
                Current = LastKey;
            else
                Current -= 1;
            return this;
        }
    }
}