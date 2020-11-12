//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public class t_boxed_number : t_numeric<t_boxed_number>
    {
        public void convert_1()
        {
            var x = BoxedNumber.Define((byte)3);
            var y = x.Convert<short>();
            Claim.eq(y, (short)x.Unbox<byte>());

        }

        public void convert_2()
        {
            for(var i=0; i<RepCount; i++)
            {
                var x = BoxedNumber.Define(Random.Next<byte>());
                var y = Converters.convert<BoxedNumber,ushort>(x);
                Claim.Require(y.IsSome());
                Claim.eq(Cast.to<ushort>((byte)x.Boxed), y.Value);
            }
        }

        public void get_zero()
        {
            var nk = NumericKind.I64;
            var x = nk.BoxedZero();
            Trace($"{x.Boxed}:{x.Kind.Format()}");
            Claim.Eq(x.Kind, nk);

            nk = NumericKind.U64;
            x = nk.BoxedZero();
            Trace($"{x.Boxed}:{x.Kind.Format()}");
            Claim.Eq(x.Kind, nk);

            nk = NumericKind.U8;
            x = nk.BoxedZero();
            Trace($"{x.Boxed}:{x.Kind.Format()}");
            Claim.Eq(x.Kind, nk);

            nk = NumericKind.I8;
            x = nk.BoxedZero();
            Trace($"{x.Boxed}:{x.Kind.Format()}");
            Claim.Eq(x.Kind, nk);

            nk = NumericKind.U16;
            x = nk.BoxedZero();
            Trace($"{x.Boxed}:{x.Kind.Format()}");
            Claim.Eq(x.Kind, nk);

            nk = NumericKind.I16;
            x = nk.BoxedZero();
            Trace($"{x.Boxed}:{x.Kind.Format()}");
            Claim.Eq(x.Kind, nk);

            nk = NumericKind.U32;
            x = nk.BoxedZero();
            Trace($"{x.Boxed}:{x.Kind.Format()}");
            Claim.Eq(x.Kind, nk);

            nk = NumericKind.I32;
            x = nk.BoxedZero();
            Trace($"{x.Boxed}:{x.Kind.Format()}");
            Claim.Eq(x.Kind, nk);

            nk = NumericKind.F32;
            x = nk.BoxedZero();
            Trace($"{x.Boxed}:{x.Kind.Format()}");
            Claim.Eq(x.Kind, nk);

            nk = NumericKind.F64;
            x = nk.BoxedZero();
            Trace($"{x.Boxed}:{x.Kind.Format()}");
            Claim.Eq(x.Kind, nk);
        }
    }
}
