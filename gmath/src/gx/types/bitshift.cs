//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;

    partial class GXTypes
    {
        public readonly struct Srl<T> : IShiftOp<T>
            where T : unmanaged        
        {
            public static Srl<T> Op => default;

            public const string Name = "srl";

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a, byte offset) => gmath.srl(a, offset);
        }

        public readonly struct Sll<T> : IShiftOp<T>
            where T : unmanaged        
        {
            public static Sll<T> Op => default;

            public const string Name = "sll";

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a, byte offset) => gmath.sll(a, offset);
                
        }
    }
}