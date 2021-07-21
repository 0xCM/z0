//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;
    using static Rules;

    public readonly struct FencedNumber
    {
        public Fence<string> Fence {get;}

        public ulong Value {get;}

        [MethodImpl(Inline)]
        public FencedNumber(ulong value, string left, string right)
        {
            Fence = (left,right);
            Value = value;
        }

        public string Format()
            => Fence.Format(Value);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Enclosed<ulong,string>(FencedNumber src)
            => enclose(src.Value, src.Fence);
    }
}