//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using static zfunc;

    [Flags]
    public enum FixedFuncKind : ulong
    {
        None = 0,

        W8 = 1,

        W16 = 2,

        W32 = 4,

        W64 = 8,

        W128 = 16,

        W256 = 32,

        W512 = 64,

        Unary = 1 << 16,

        Binary = 1 << 17,

        Termary = 1 << 18,

        Numeric = 1ul << 32,

        Vector = 1ul << 33,

        Block = 1ul << 34,
        
    }

    public static partial class HK
    {

        public readonly struct FixedFunc<R>
            where R : unmanaged, IFixed
        {


        }

        public readonly struct FixedFunc<T0,R>
            where T0 : unmanaged, IFixed
            where R : unmanaged, IFixed
        {

            
        }

        public readonly struct FixedFunc<T0,T1,R>
            where T0 : unmanaged, IFixed
            where T1 : unmanaged, IFixed
            where R : unmanaged, IFixed
        {

            
        }

        public readonly struct FixedFunc<T0,T1,T2,R>
            where T0 : unmanaged, IFixed
            where T1 : unmanaged, IFixed
            where T2 : unmanaged, IFixed
            where R : unmanaged, IFixed
        {

            
        }

    }

}