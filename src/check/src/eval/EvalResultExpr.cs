//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static memory;

    using C = AsciCharCode;

    public readonly struct EvalResultExpr
    {
        [MethodImpl(Inline)]
        public static Eq<T> eq<T>(T a, T b, bit state)
            => new Eq<T>(a,b,state);

        public readonly struct Eq<T>
        {
            public T A {get;}

            public T B {get;}

            public bit State {get;}

            [MethodImpl(Inline)]
            public Eq(T a, T b, bit state)
            {
                A = a;
                B = b;
                State = state;
            }

            public string Format()
                => string.Format("{0} {1} {2}", A, State ? "=" : "!=", B);

            public override string ToString()
                => Format();

        }

        public readonly struct EvalSymbol
        {
            public static EvalSymbol Eq => new EvalSymbol(C.Eq);

            public static EvalSymbol NEq => new EvalSymbol(C.Bang, C.Eq);

            public static EvalSymbol Lt => new EvalSymbol(C.Lt);

            public static EvalSymbol Gt => new EvalSymbol(C.Gt);

            readonly uint Data;

            [MethodImpl(Inline)]
            internal EvalSymbol(AsciSymbol s0)
            {
                Data = (uint)s0;
            }

            [MethodImpl(Inline)]
            internal EvalSymbol(AsciSymbol s0, AsciSymbol s1)
            {
                Data = (uint)s0 | ((uint)s1 << 8);
            }

            [MethodImpl(Inline)]
            internal EvalSymbol(AsciSymbol s0, AsciSymbol s1, AsciSymbol s2)
            {
                Data = (uint)s0 | ((uint)s1 << 8) | ((uint)s2 << 16);
            }

            [MethodImpl(Inline)]
            internal EvalSymbol(AsciSymbol s0, AsciSymbol s1, AsciSymbol s2, AsciSymbol s3)
            {
                Data = (uint)s0 | ((uint)s1 << 8) | ((uint)s2 << 16) | ((uint)s3 << 24);
            }

            public string Format()
            {
                Span<char> dst = stackalloc char[4];
                var index = 0;
                var s0 = S0;
                if(s0 != 0)
                {
                    seek(dst,index++) = s0;
                    var s1 = S1;
                    if(s1 != 0)
                    {
                        seek(dst,index++) = s1;

                        var s2 = S2;
                        if(s2 != 0)
                        {
                            seek(dst,index++) = s2;

                            var s3 = S3;
                            if(s3 != 0)
                                seek(dst,index++) = s3;
                        }

                    }
                }
                return text.format(slice(dst,index));
            }

            public override string ToString()
                => Format();

            char S0
            {
                [MethodImpl(Inline)]
                get => (char)((byte)Data);
            }

            char S1
            {
                [MethodImpl(Inline)]
                get => (char)((byte)((uint)Data >> 8));
            }

            char S2
            {
                [MethodImpl(Inline)]
                get => (char)((byte)((uint)Data >> 16));
            }

            char S3
            {
                [MethodImpl(Inline)]
                get => (char)((byte)((uint)Data >> 24));
            }

        }

    }

}