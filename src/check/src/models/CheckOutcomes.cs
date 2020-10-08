//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct CheckOutcomes
    {
        [MethodImpl(Inline), Op]
        public static CheckOutcome define(bit ok, string reason)
            => new CheckOutcome(ok,reason);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static CheckOutcome<A> define<A>(bit ok, string reason, in A a)
            => new CheckOutcome<A>(ok,reason, new A[]{a});

        public readonly struct CheckOutcome : ICheckOutcome<CheckOutcome>
        {
            public bit Ok {get;}

            public utf8 Reason {get;}

            [MethodImpl(Inline)]
            public CheckOutcome(bit success, utf8 reason)
            {
                Ok = success;
                Reason = reason;
            }
        }

        public readonly struct CheckOutcome<A> : ICheckOutcome<CheckOutcome<A>,A>
        {
            public bit Ok {get;}

            public utf8 Reason {get;}

            readonly A[] _A;

            internal CheckOutcome(bit ok, utf8 reason, A[] aspect)
            {
                Ok = ok;
                Reason = reason;
                _A = aspect;
            }

            public ref A Set(in A src)
            {
                _A[0] = src;
                return ref edit(src);
            }

            public ref A Get(out A src)
            {
                src =  _A[0];
                return ref src;
            }
        }

        public readonly struct CheckOutcome<A,B>
        {
            public bit Ok {get;}

            public utf8 Reason {get;}

        }

        public readonly struct CheckOutcome<A,B,C>
        {
            public bit Ok {get;}

            public utf8 Reason {get;}
        }

        public readonly struct CheckOutcome<A,B,C,D>
        {
            public bit Ok {get;}

            public utf8 Reason {get;}
        }

    }
}