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
    using I = CalcDemo.OpIndex;

    public readonly struct BinaryOpsDemo
    {
        public static BinaryOpsDemo<T> index<T>()
            => new BinaryOpsDemo<T>(new BinaryOp<T>[256]);

        public static BinaryOpsDemo<byte> arithmetic()
        {
            var dst = index<byte>();
            dst[I.Add] = BinaryOpDynamics.create<byte>(OpIdentity.define(nameof(C.add_ᐤ8iㆍ8iᐤ)), C.add_ᐤ8iㆍ8iᐤ);
            dst[I.Sub] = BinaryOpDynamics.create<byte>(OpIdentity.define(nameof(C.sub_ᐤ8uㆍ8uᐤ)), C.sub_ᐤ8uㆍ8uᐤ);
            dst[I.Mul] = BinaryOpDynamics.create<byte>(OpIdentity.define(nameof(C.mul_ᐤ8uㆍ8uᐤ)), C.mul_ᐤ8uㆍ8uᐤ);
            dst[I.Div] = BinaryOpDynamics.create<byte>(OpIdentity.define(nameof(C.div_ᐤ8uㆍ8uᐤ)), C.div_ᐤ8uㆍ8uᐤ);
            return dst;
        }

        public static Index<DynamicOp<BinaryOp<byte>>> dynops()
        {
            var dst = memory.alloc<DynamicOp<BinaryOp<byte>>>(4);
            dst[0] = BinaryOpDynamics.dynop<byte>(nameof(C.add_ᐤ8iㆍ8iᐤ), C.add_ᐤ8iㆍ8iᐤ);
            dst[1] = BinaryOpDynamics.dynop<byte>(nameof(C.sub_ᐤ8uㆍ8uᐤ), C.sub_ᐤ8uㆍ8uᐤ);
            dst[2] = BinaryOpDynamics.dynop<byte>(nameof(C.mul_ᐤ8uㆍ8uᐤ), C.mul_ᐤ8uㆍ8uᐤ);
            dst[3] = BinaryOpDynamics.dynop<byte>(nameof(C.div_ᐤ8uㆍ8uᐤ), C.div_ᐤ8uㆍ8uᐤ);
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

        public ref BinaryOp<T> this[I index]
        {
            [MethodImpl(Inline)]
            get => ref seek(Operators,(byte)index);
        }
    }
}