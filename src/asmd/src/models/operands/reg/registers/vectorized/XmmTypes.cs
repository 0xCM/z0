//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 210210
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    using K = RegisterKind;

    public partial class Registers
    {                
        public readonly struct XMM0 : IXmmRegOp<XMM0,N0>
        {
            public K Kind => K.XMM0;
        }

        public readonly struct XMM1 : IXmmRegOp<XMM1,N1>
        {
            public K Kind => K.XMM1;
        }

        public readonly struct XMM2 : IXmmRegOp<XMM2,N2>
        {
            public K Kind => K.XMM2;
        }

        public readonly struct XMM3 : IXmmRegOp<XMM3,N3>
        {
            public K Kind => K.XMM3;
        }

        public readonly struct XMM4 : IXmmRegOp<XMM4,N4>
        {                        
            public K Kind => K.XMM4;
        }

        public readonly struct XMM5 : IXmmRegOp<XMM5,N5>
        {            
            public K Kind => K.XMM5;
        }

        public readonly struct XMM6 : IXmmRegOp<XMM6,N6>
        {

            public K Kind => K.XMM6;
        }

        public readonly struct XMM7 : IXmmRegOp<XMM7,N7>
        {
            public K Kind => K.XMM7;
        }

        public readonly struct XMM8 : IXmmRegOp<XMM8,N8>
        {
            public K Kind => K.XMM8;
        }

        public readonly struct XMM9 : IXmmRegOp<XMM9,N9>
        {            
            public K Kind => K.XMM9;
        }

        public readonly struct XMM10 : IXmmRegOp<XMM10,N10>
        {
            
            public const int Index = 10;

            public K Kind => K.XMM10;
        }

        public readonly struct XMM11 : IXmmRegOp<XMM11,N11>
        {
            public const int Index = 11;

            public K Kind => K.XMM11;
        }

        public readonly struct XMM12 : IXmmRegOp<XMM12,N12>
        {
            public K Kind => K.XMM12;
        }

        public readonly struct XMM13 : IXmmRegOp<XMM13,N13>
        {            

            public K Kind => K.XMM13;
        }

        public readonly struct XMM14 : IXmmRegOp<XMM14,N14>
        {
            
            public K Kind => K.XMM14;
        }

        public readonly struct XMM : IXmmRegOp<XMM,N15>
        {            
            public K Kind => K.XMM15;
        }

        public readonly struct XMM16 : IXmmRegOp<XMM16,N16>
        {
            public K Kind => K.XMM16;
        }

        public readonly struct XMM17 : IXmmRegOp<XMM17,N17>
        {
            public K Kind => K.XMM17;
        }

        public readonly struct XMM18 : IXmmRegOp<XMM18,N18>
        {            
            public K Kind => K.XMM18;
        }

        public readonly struct XMM19 : IXmmRegOp<XMM19,N19>
        {
            public K Kind => K.XMM19;
        }

        public readonly struct XMM20 : IXmmRegOp<XMM20,N20>
        {            
            public K Kind => K.XMM20;
        }

        public readonly struct XMM21 : IXmmRegOp<XMM21,N21>
        {               
            public K Kind => K.XMM21;
        }

        public readonly struct XMM22 : IXmmRegOp<XMM22,N22>
        {
            public K Kind => K.XMM22;
        }

        public readonly struct XMM23 : IXmmRegOp<XMM23,N23>
        {
            public K Kind => K.XMM23;
        }

        public readonly struct XMM24 : IXmmRegOp<XMM24,N24>
        {            
            public K Kind => K.XMM24;
        }

        public readonly struct XMM25 : IXmmRegOp<XMM25,N25>
        {            
            public K Kind => K.XMM25;
        }

        public readonly struct XMM26 : IXmmRegOp<XMM26,N26>
        {            
            public K Kind => K.XMM26;
        }

        public readonly struct XMM27 : IXmmRegOp<XMM27,N27>
        {            
            public K Kind => K.XMM27;
        }

        public readonly struct XMM28 : IXmmRegOp<XMM28,N28>
        {
            public K Kind => K.XMM28;
        }

        public readonly struct XMM29 : IXmmRegOp<XMM29,N29>
        {
            public K Kind => K.XMM29;
        }

        public readonly struct XMM30 : IXmmRegOp<XMM30,N30>
        {
            public K Kind => K.XMM30;
        }

        public readonly struct XMM31 : IXmmRegOp<XMM31,N31>
        {       
            public K Kind => K.XMM31;
        }
    }
}