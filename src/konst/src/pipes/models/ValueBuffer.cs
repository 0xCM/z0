//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct ValueBuffer<T> : IValueBuffer<ValueBuffer<T>, T>
        where T : struct
    {
        readonly TableSpan<T> Data;

        uint Position;

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