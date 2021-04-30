//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    using C = CalculatorCode;
    using I = CalcOpDemoIndex;

    public readonly struct BinaryOpsDemo
    {
        public static BinaryOpsDemo<T> index<T>()
            => new BinaryOpsDemo<T>(new BinaryOp<T>[256]);

        public static BinaryOpsDemo<byte> arithmetic()
        {
            var dst = index<byte>();
            dst[I.Add] = BinaryOpFactory.create<byte>(OpIdentity.define(nameof(C.add_ᐤ8iㆍ8iᐤ)), C.add_ᐤ8iㆍ8iᐤ);
            dst[I.Sub] = BinaryOpFactory.create<byte>(OpIdentity.define(nameof(C.sub_ᐤ8uㆍ8uᐤ)), C.sub_ᐤ8uㆍ8uᐤ);
            dst[I.Mul] = BinaryOpFactory.create<byte>(OpIdentity.define(nameof(C.mul_ᐤ8uㆍ8uᐤ)), C.mul_ᐤ8uㆍ8uᐤ);
            dst[I.Div] = BinaryOpFactory.create<byte>(OpIdentity.define(nameof(C.div_ᐤ8uㆍ8uᐤ)), C.div_ᐤ8uㆍ8uᐤ);
            return dst;
        }
    }

    public ref struct BinaryOpsDemo<T>
    {
        readonly Span<BinaryOp<T>> Operators;

        byte Offset;

        public BinaryOpsDemo(Span<BinaryOp<T>> src)
        {
            Operators = src;
            Offset = 0;
        }

        public ref BinaryOp<T> this[CalcOpDemoIndex index]
        {
            [MethodImpl(Inline)]
            get => ref seek(Operators,(byte)index);
        }
    }
}