//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;


    public class t_boxed_number : UnitTest<t_boxed_number>
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
                var converter = default(BoxedNumber).Converter;
                var x = BoxedNumber.Define(Random.Next<byte>());
                var y = converter.Convert<ushort>(x);
                Claim.yea(y.IsSome());
                Claim.eq(Cast.to<ushort>((byte)x.Value), y.Value);                        
            }
        }

        public void get_zero()
        {
            var nk = NumericKind.I64;
            var x = nk.Zero();
            Trace($"{x.Value}:{x.Kind.Format()}");
            Claim.eq(x.Kind, nk);

            nk = NumericKind.U64;
            x = nk.Zero();
            Trace($"{x.Value}:{x.Kind.Format()}");
            Claim.eq(x.Kind, nk);
            
            nk = NumericKind.U8;
            x = nk.Zero();
            Trace($"{x.Value}:{x.Kind.Format()}");
            Claim.eq(x.Kind, nk);

            nk = NumericKind.I8;
            x = nk.Zero();
            Trace($"{x.Value}:{x.Kind.Format()}");
            Claim.eq(x.Kind, nk);

            nk = NumericKind.U16;
            x = nk.Zero();
            Trace($"{x.Value}:{x.Kind.Format()}");
            Claim.eq(x.Kind, nk);

            nk = NumericKind.I16;
            x = nk.Zero();
            Trace($"{x.Value}:{x.Kind.Format()}");
            Claim.eq(x.Kind, nk);

            nk = NumericKind.U32;
            x = nk.Zero();
            Trace($"{x.Value}:{x.Kind.Format()}");
            Claim.eq(x.Kind, nk);

            nk = NumericKind.I32;            
            x = nk.Zero();
            Trace($"{x.Value}:{x.Kind.Format()}");            
            Claim.eq(x.Kind, nk);

            nk = NumericKind.F32;            
            x = nk.Zero();
            Trace($"{x.Value}:{x.Kind.Format()}");            
            Claim.eq(x.Kind, nk);

            nk = NumericKind.F64;            
            x = nk.Zero();
            Trace($"{x.Value}:{x.Kind.Format()}");            
            Claim.eq(x.Kind, nk);
        }
    }
}
