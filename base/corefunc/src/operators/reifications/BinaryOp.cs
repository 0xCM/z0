//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;
    using R = ZOpR;
    
    partial class ZOps
    {
        [MethodImpl(Inline)]
        public static R.UnaryOp<T> unary<T>(Func<T,T> f, string name, T t = default)
            => new R.UnaryOp<T>(f,name);

        [MethodImpl(Inline)]
        public static R.UnaryPred<T> unarypred<T>(Func<T,bit> f, string name, T t = default)
            => new R.UnaryPred<T>(f,name);

        [MethodImpl(Inline)]
        public static R.BinaryOp<T> binary<T>(Func<T,T,T> f, string name, T t = default)
            => new R.BinaryOp<T>(f,name);
            
        [MethodImpl(Inline)]
        public static R.BinaryPred<T> binarypred<T>(Func<T,T,bit> f, string name, T t = default)
            => new R.BinaryPred<T>(f,name);

        [MethodImpl(Inline)]
        public static R.TernaryOp<T> ternary<T>(Func<T,T,T,T> f, string name, T t = default)
            => new R.TernaryOp<T>(f,name);
    }

    partial class ZOpR
    {                

        public readonly struct UnaryOp<T> : IUnaryOp<T>
        {
            public readonly string Name;

            readonly Func<T,T> F;

            [MethodImpl(Inline)]
            internal UnaryOp(Func<T,T> f, string name)            
            {
                this.F = f;
                this.Name = name;
            }
            
            public string Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a) => F(a);
        }

        public readonly struct UnaryPred<T> : IUnaryPred<T>
        {
            public readonly string Name;

            readonly Func<T,bit> F;

            [MethodImpl(Inline)]
            internal UnaryPred(Func<T,bit> f, string name)            
            {
                this.F = f;
                this.Name = name;
            }
            
            public string Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public bit Invoke(T a) => F(a);
        }


        public readonly struct BinaryOp<T> : IBinaryOp<T>
        {
            public readonly string Name;

            readonly Func<T,T,T> F;

            [MethodImpl(Inline)]
            internal BinaryOp(Func<T,T,T> f, string name)            
            {
                this.F = f;
                this.Name = name;
            }
            
            public string Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a, T b) => F(a, b);
        }

        public readonly struct BinaryPred<T> : IBinaryPred<T>
        {
            public readonly string Name;

            readonly Func<T,T,bit> F;

            [MethodImpl(Inline)]
            internal BinaryPred(Func<T,T,bit> f, string name)            
            {
                this.F = f;
                this.Name = name;
            }
            
            public string Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public bit Invoke(T a, T b) => F(a, b);
        }

        public readonly struct TernaryOp<T> : ITernaryOp<T>
        {
            public readonly string Name;

            readonly Func<T,T,T,T> F;

            [MethodImpl(Inline)]
            internal TernaryOp(Func<T,T,T,T> f, string name)            
            {
                this.F = f;
                this.Name = name;
            }
            
            public string Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a, T b, T c) => F(a, b, c);
        }
    }
}