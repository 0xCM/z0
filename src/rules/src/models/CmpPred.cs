//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        public enum CmpKind : byte
        {
            EQ,

            NEQ,

            LT,

            LTE,

            GT,

            GTE
        }

        public interface ICmpPred : ITextual
        {
            CmpKind Kind {get;}
        }

        public interface ICmpPred<T> : ICmpPred
        {
            T A {get;}

            T B {get;}
        }

        public interface ICmpPred<F,T> : ICmpPred<T>
            where F : ICmpPred<F,T>
        {

        }

        public readonly struct EQ<T> : ICmpPred<EQ<T>,T>
        {
            public T A {get;}

            public T B {get;}

            [MethodImpl(Inline)]
            public EQ(T a, T b)
            {
                A = a;
                B = b;
            }

            public CmpKind Kind
                => CmpKind.EQ;

            [MethodImpl(Inline)]
            public string Format()
                => string.Format("{0}=={1}", A, B);

            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator EQ<T>((T a, T b) src)
                => new EQ<T>(src.a, src.b);
        }

        public readonly struct NEQ<T> : ICmpPred<NEQ<T>,T>
        {
            public T A {get;}

            public T B {get;}

            [MethodImpl(Inline)]
            public NEQ(T a, T b)
            {
                A = a;
                B = b;
            }

            public CmpKind Kind
                => CmpKind.NEQ;

            [MethodImpl(Inline)]
            public string Format()
                => string.Format("{0}!={1}", A, B);

            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator NEQ<T>((T a, T b) src)
                => new NEQ<T>(src.a, src.b);
        }

        public readonly struct LT<T> : ICmpPred<LT<T>,T>
        {
            public T A {get;}

            public T B {get;}

            [MethodImpl(Inline)]
            public LT(T a, T b)
            {
                A = a;
                B = b;
            }


            public CmpKind Kind
                => CmpKind.LT;

            [MethodImpl(Inline)]
            public string Format()
                => string.Format("{0}<{1}", A, B);

            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator LT<T>((T a, T b) src)
                => new LT<T>(src.a, src.b);
        }

        public readonly struct LTE<T> : ICmpPred<LTE<T>,T>
        {
            public T A {get;}

            public T B {get;}

            [MethodImpl(Inline)]
            public LTE(T a, T b)
            {
                A = a;
                B = b;
            }

            public CmpKind Kind
                => CmpKind.LTE;

            [MethodImpl(Inline)]
            public string Format()
                => string.Format("{0}<={1}", A, B);

            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator LTE<T>((T a, T b) src)
                => new LTE<T>(src.a, src.b);
        }

        public readonly struct GT<T> : ICmpPred<GT<T>,T>
        {
            public T A {get;}

            public T B {get;}

            [MethodImpl(Inline)]
            public GT(T a, T b)
            {
                A = a;
                B = b;
            }


            public CmpKind Kind
                => CmpKind.GT;

            [MethodImpl(Inline)]
            public string Format()
                => string.Format("{0}>{1}", A, B);

            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator GT<T>((T a, T b) src)
                => new GT<T>(src.a, src.b);
        }

        public readonly struct GTE<T> : ICmpPred<GTE<T>,T>
        {
            public T A {get;}

            public T B {get;}

            [MethodImpl(Inline)]
            public GTE(T a, T b)
            {
                A = a;
                B = b;
            }

            public CmpKind Kind
                => CmpKind.GTE;


            [MethodImpl(Inline)]
            public string Format()
                => string.Format("{0}>={1}", A, B);

            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator GTE<T>((T a, T b) src)
                => new GTE<T>(src.a, src.b);
        }
    }
}