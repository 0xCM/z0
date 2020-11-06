//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public abstract class FixedBuffer<H,T> : FixedBuffer<T>
        where H : FixedBuffer<H,T>, new()
    {
        static H Instance;

        [FixedAddressValueType]
        static IndexedSeq<T> Buffer;

        static object locker = new object();

        [MethodImpl(Inline)]
        public static H fetch()
        {
            lock(locker)
            {
                if(Instance == null)
                {
                    Instance = new H();
                    var count = Instance.CellCount;
                    Buffer = alloc<T>(Instance.CellCount);
                    Instance.Populate(Buffer.Storage);
                    Instance.BufferAddress = address(Buffer);
                }
                return Instance;
            }
        }
    }
}