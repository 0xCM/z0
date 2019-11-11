//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    public static class BlockStorage
    {

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


        public ref struct CharBlock2
        {
            public char C0;

            public char C1;

        }

        public ref struct CharBlock4
        {
            public char C0;

            public char C1;

            public char C2;

            public char C3;
        }

        public ref struct CharBlock8
        {
            public char C0;

            public char C1;

            public char C2;

            public char C3;

            public char C4;

            public char C5;

            public char C6;

            public char C7;

        }

        public ref struct CharBlock16
        {
            public char C0;

            public char C1;

            public char C2;

            public char C3;

            public char C4;

            public char C5;

            public char C6;

            public char C7;

            public char C8;

            public char C9;

            public char CA;

            public char CB;

            public char CC;

            public char CD;

            public char CE;

            public char CF;
        
        }
    }

}