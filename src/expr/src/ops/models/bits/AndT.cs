//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris MoAnde, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Ops
{
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct And<T> : IBinaryBitLogicOp<And<T>,T>
        where T : IExpr
    {
        public readonly T A;

        public readonly T B;

        [MethodImpl(Inline)]
        public And(T a, T b)
        {
            A = a;
            B = b;
        }

        public Label OpName => "And<a>";

        public BinaryBitLogicKind Kind
            => BinaryBitLogicKind.And;
            
        [MethodImpl(Inline)]
        public And<T> Make(T a0, T a1)
            => new And<T>(a0, a1);

        public And Untyped()
            => new And(A,B);

        [MethodImpl(Inline)]
        public string Format()
            => Untyped().Format();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator And<T>((T a, T b) src)
            => new And<T>(src.a, src.b);

        [MethodImpl(Inline)]
        public static implicit operator And(And<T> src)
            => src.Untyped();
    }    
}