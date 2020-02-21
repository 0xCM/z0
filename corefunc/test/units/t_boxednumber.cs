//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public sealed class t_boxednumber : UnitTest<t_boxednumber>
    {

        public void get_zero()
        {

            var x = NumericKind.I64.Zero();
            Trace($"{x.Value}:{x.Kind.Format()}");

            x = NumericKind.U64.Zero();
            Trace($"{x.Value}:{x.Kind.Format()}");
            
            x = NumericKind.U8.Zero();
            Trace($"{x.Value}:{x.Kind.Format()}");

            x = NumericKind.I8.Zero();
            Trace($"{x.Value}:{x.Kind.Format()}");

            x = NumericKind.U16.Zero();
            Trace($"{x.Value}:{x.Kind.Format()}");

            x = NumericKind.I16.Zero();
            Trace($"{x.Value}:{x.Kind.Format()}");

            x = NumericKind.U32.Zero();
            Trace($"{x.Value}:{x.Kind.Format()}");

            x = NumericKind.I32.Zero();
            Trace($"{x.Value}:{x.Kind.Format()}");            

            x = NumericKind.F32.Zero();
            Trace($"{x.Value}:{x.Kind.Format()}");            

            x = NumericKind.F64.Zero();
            Trace($"{x.Value}:{x.Kind.Format()}");            
        }
    }
}