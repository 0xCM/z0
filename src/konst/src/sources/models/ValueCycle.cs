//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct ValueCycle<T> : IDataSource<ValueCycle<T>,T>
        where T : struct
    {
        readonly Index<T> Data;

        uint Position;

        [MethodImpl(Inline)]
        public ValueCycle(Index<T> src)
        {
            Data = src;
            Position = 0;
        }

        [MethodImpl(Inline)]
        public ref readonly T NextRef()
        {
            if(Position >= Data.Count)
                Position = 0;

            return ref Data[Position++];
        }

        [MethodImpl(Inline)]
        public ref T Next(out T dst)
        {
            dst = Next();
            return ref dst;
        }

        [MethodImpl(Inline)]
        public T Next()
            => NextRef();
    }
}