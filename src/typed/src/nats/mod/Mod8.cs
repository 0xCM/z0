//-----------------------------------------------------------------------------
// Copyrhs   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
        
    using static Seed;    

    public static class Mod4
    {
        const ulong N = 4;

        const ulong M = (ulong.MaxValue / N) + 1;        
        
        [MethodImpl(Inline)]
        public static uint mod(uint a)
            => ModOps.mod(M, N, a);

        [MethodImpl(Inline)]
        public static uint div(uint a)
            => ModOps.div(M, N, a);
    }

    public static class Mod8
    {
        const ulong N = 8;

        const ulong M = (ulong.MaxValue / N) + 1;
                
        [MethodImpl(Inline)]
        public static uint mod(uint a)
            => ModOps.mod(M, N, a);

        [MethodImpl(Inline)]
        public static uint div(uint a)
            => ModOps.div(M, N, a);

        [MethodImpl(Inline)]
        public static int mod(int a)
            => (int)ModOps.mod(M, N, (uint)a);

        [MethodImpl(Inline)]
        public static int div(int a)
            => (int)ModOps.div(M, N, (uint)a);
    }

    public static class Mod16
    {
        const ulong N = 16;

        const ulong M = (ulong.MaxValue / N) + 1;
        
        
        [MethodImpl(Inline)]
        public static uint mod(uint a)
            => ModOps.mod(M, N, a);

        [MethodImpl(Inline)]
        public static uint div(uint a)
            => ModOps.div(M, N, a);
    }

    public static class Mod25
    {                
        const ulong N = 25;

        const ulong M = (ulong.MaxValue / N) + 1;
        
        [MethodImpl(Inline)]
        public static uint mod(uint a)
            => ModOps.mod(M, N, a);

        [MethodImpl(Inline)]
        public static uint div(uint a)
            => ModOps.div(M, N, a);
    }

    public static class Mod32
    {
        const ulong N = 32;

        const ulong M = (ulong.MaxValue / N) + 1;        

        [MethodImpl(Inline)]
        public static uint mod(uint a)
            => ModOps.mod(M, N, a);

        [MethodImpl(Inline)]
        public static uint div(uint a)
            => ModOps.div(M, N, a);
    }

    public static class Mod64
    {
        const ulong N = 64;

        const ulong M = (ulong.MaxValue / N) + 1;        

        [MethodImpl(Inline)]
        public static uint mod(uint a)
            => ModOps.mod(M, N, a);

        [MethodImpl(Inline)]
        public static uint div(uint a)
            => ModOps.div(M, N, a);
    }

    public static class Mod128
    {
        const ulong N = 128;

        const ulong M = (ulong.MaxValue / N) + 1;        

        [MethodImpl(Inline)]
        public static uint mod(uint a)
            => ModOps.mod(M, N, a);

        [MethodImpl(Inline)]
        public static uint div(uint a)
            => ModOps.div(M, N, a);
    }

    public static class Mod256
    {
        const ulong N = 32;

        const ulong M = (ulong.MaxValue / N) + 1;        

        [MethodImpl(Inline)]
        public static uint mod(uint a)
            => ModOps.mod(M, N, a);

        [MethodImpl(Inline)]
        public static uint div(uint a)
            => ModOps.div(M, N, a);
    }
}