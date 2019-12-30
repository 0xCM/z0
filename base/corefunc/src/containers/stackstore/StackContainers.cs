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

    public static class StackContainers
    {
        public ref struct Stack128
        {
            public ulong X0;

            public ulong X1;                    
        }

        /// <summary>
        /// Stack-allocated storage that covers 128 bits with 8 16-bit segments
        /// </summary>
        public ref struct Stack128x16
        {
            internal ushort X0;

            ushort X1;        

            ushort X2;        

            ushort X3;

            ushort X4;        

            ushort X5;

            ushort X6;        

            ushort X7;        

        }

        public ref struct Stack256
        {
            internal Stack128 X0;

            Stack128 X1;
            
        }

        public ref struct Stack512
        {
            internal ulong X0;

            ulong X1;
            
            ulong X2;

            ulong X3;

            ulong X4;

            ulong X5;
            
            ulong X6;

            ulong X7;
        }

        public ref struct Stack1024
        {
            internal ulong X0;

            ulong X1;
            
            ulong X2;

            ulong X3;

            ulong X4;

            ulong X5;
            
            ulong X6;

            ulong X7;

            ulong X8;

            ulong X9;
            
            ulong XA;

            ulong XB;

            ulong XC;

            ulong XD;
            
            ulong XE;

            ulong XF;
        }

        public ref struct CharStack2
        {
            internal char C0;

            char C1;

        }

        public ref struct CharStack4
        {
            internal char C0;

            char C1;

            char C2;

            char C3;
        }

        public ref struct CharStack8
        {
            internal char C0;

            char C1;

            char C2;

            char C3;

            char C4;

            char C5;

            char C6;

            char C7;

        }

        public ref struct CharStack16
        {
            internal char C0;

            char C1;

            char C2;

            char C3;

            char C4;

            char C5;

            char C6;

            char C7;

            char C8;

            char C9;

            char CA;

            char CB;

            char CC;

            char CD;

            char CE;

            char CF;
        
        }
    }
}