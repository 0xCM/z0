//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public readonly struct AsmDx<T>
        where T : unmanaged
    {
        public T Data {get;}

        [MethodImpl(Inline)]
        public AsmDx(T src)
        {
            Data = src;
        }

        public bool IsZero
        {
            [MethodImpl(Inline)]
            get => bw8(Data) == 0;
        }

        public bool IsNonZero
        {
            [MethodImpl(Inline)]
            get => !IsZero;
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmDx<T>(uint src)
            => new AsmDx<T>(generic<T>(src));

        [MethodImpl(Inline)]
        public static implicit operator AsmDx<T>(ushort src)
            => new AsmDx<T>(generic<T>(src));

        [MethodImpl(Inline)]
        public static implicit operator AsmDx<T>(byte src)
            => new AsmDx<T>(generic<T>(src));
    }
}