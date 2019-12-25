//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;

    partial class KOpStructs
    {
        public readonly struct And<T> : IPBinOp<T>
            where T : unmanaged        
        {    
            public static And<T> Op => default;

            public const string Name = "and";

            public string Moniker => moniker<T>(Name);


            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b) => gmath.and(a,b);
        }

        public readonly struct Or<T> : IPBinOp<T>
            where T : unmanaged        
        {    
            public static Or<T> Op => default;

            public const string Name = "or";

            public string Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b) => gmath.or(a,b);
        }

        public readonly struct Xor<T> : IPBinOp<T>
            where T : unmanaged        
        {    
            public static Xor<T> Op => default;

            public const string Name = "xor";

            public string Moniker => moniker<T>(Name);


            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b) => gmath.xor(a,b);
        }

        public readonly struct Nand<T> : IPBinOp<T>
            where T : unmanaged        
        {    
            public static Nand<T> Op => default;

            public const string Name = "nand";

            public string Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b) => gmath.nand(a,b);
        }

        public readonly struct Nor<T> : IPBinOp<T>
            where T : unmanaged        
        {    
            public static Nor<T> Op => default;

            public const string Name = "not";

            public string Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b) => gmath.nor(a,b);
        }

        public readonly struct Xnor<T> : IPBinOp<T>
            where T : unmanaged        
        {    
            public static Xnor<T> Op => default;

            public const string Name = "xnor";

            public string Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b) => gmath.xnor(a, b);
        }

        public readonly struct Select<T> : IPTernaryOp<T>
            where T : unmanaged        
        {    
            public static Select<T> Op => default;

            public const string Name = "select";

            public string Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b, T c) => gmath.select(a, b, c);
        }

        public readonly struct NotOp<T> : IPUnaryOp<T>
            where T : unmanaged        
        {
            public static NotOp<T> Op => default;

            public const string Name = "not";

            public string Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a) => gmath.not(a);
        }    

        public readonly struct Srl<T> : IPShiftOp<T>
            where T : unmanaged        
        {
            public static Srl<T> Op => default;

            public const string Name = "srl";

            public string Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a, byte offset) => gmath.srl(a, offset);
        }

        public readonly struct Sll<T> : IPShiftOp<T>
            where T : unmanaged        
        {
            public static Sll<T> Op => default;

            public const string Name = "sll";

            public string Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a, byte offset) => gmath.sll(a, offset);
                
        }
    }
}