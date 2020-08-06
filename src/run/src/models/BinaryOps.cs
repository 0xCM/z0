//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using C = CalculatorCode;
    using I = CalcOpIndex;

    public readonly struct BinaryOps
    {
        public static BinaryOps<T> index<T>()
            => new BinaryOps<T>(new BinaryOp<T>[256]);
        
        public static BinaryOps<byte> arithmetic()
        {
            var dst = index<byte>();
            dst[I.Add] = BinaryOpFactory.create<byte>(OpIdentity.set(nameof(C.add_ᐤ8iㆍ8iᐤ)), C.add_ᐤ8iㆍ8iᐤ);
            dst[I.Sub] = BinaryOpFactory.create<byte>(OpIdentity.set(nameof(C.sub_ᐤ8uㆍ8uᐤ)), C.sub_ᐤ8uㆍ8uᐤ);
            dst[I.Mul] = BinaryOpFactory.create<byte>(OpIdentity.set(nameof(C.mul_ᐤ8uㆍ8uᐤ)), C.mul_ᐤ8uㆍ8uᐤ);
            dst[I.Div] = BinaryOpFactory.create<byte>(OpIdentity.set(nameof(C.div_ᐤ8uㆍ8uᐤ)), C.div_ᐤ8uㆍ8uᐤ);
            return dst;
        }        
    }
    
    public ref struct BinaryOps<T>
    {
        readonly Span<BinaryOp<T>> Operators;

        byte Offset;
        
        public BinaryOps(Span<BinaryOp<T>> src)        
        {
            Operators = src;
            Offset = 0;
        }

        public BinaryOps(int count)
        {
            Operators = new BinaryOp<T>[256];
            Offset = 0;
        }

        public ref BinaryOp<T> this[CalcOpIndex index]
        {
            [MethodImpl(Inline)]
            get => ref z.seek(Operators,(byte)index);
        }
    }
}