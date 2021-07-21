//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Rules;

    public readonly struct FencedNumber<T>
        where T : unmanaged
    {
        public Fence<string> Fence {get;}

        public T Value {get;}

        [MethodImpl(Inline)]
        public FencedNumber(T value, string left, string right)
        {
            Fence = (left,right);
            Value = value;
        }

        [MethodImpl(Inline)]
        public FencedNumber(T value, Fence<string> fence)
        {
            Fence = fence;
            Value = value;
        }

        public string Format()
            => Fence.Format(Value);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Enclosed<T,string>(FencedNumber<T> src)
            => enclose(src.Value, src.Fence);
    }
}