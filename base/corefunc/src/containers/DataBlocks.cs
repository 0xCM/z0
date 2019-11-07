//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;



    public static class DataBlocks
    {
        [MethodImpl(Inline)]
        public static Block256 alloc(N256 n)
            => default;

        [MethodImpl(Inline)]
        public static Block128 alloc(N128 n)
            => default;

        [MethodImpl(Inline)]
        public static Block512 alloc(N512 n)
            => default;

        [MethodImpl(Inline)]
        public static Block1024 alloc(N1024 n)
            => default;

    }

    public ref struct Block128
    {
        public ulong X0;

        public ulong X1;        
    }

    public ref struct Block256
    {
        public ulong X0;

        public ulong X1;
        
        public ulong X2;

        public ulong X3;
    }

    public ref struct Block512
    {
        public ulong X0;

        public ulong X1;
        
        public ulong X2;

        public ulong X3;

        public ulong X4;

        public ulong X5;
        
        public ulong X6;

        public ulong X7;
    }

    public ref struct Block1024
    {
        public ulong X0;

        public ulong X1;
        
        public ulong X2;

        public ulong X3;

        public ulong X4;

        public ulong X5;
        
        public ulong X6;

        public ulong X7;

        public ulong X8;

        public ulong X9;
        
        public ulong XA;

        public ulong XB;

        public ulong XC;

        public ulong XD;
        
        public ulong XE;

        public ulong XF;
    }
}