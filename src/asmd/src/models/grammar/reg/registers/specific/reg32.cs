//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{

    using S = Fixed32;
    using K = Z0.Asm.Data.RegisterKind;

    partial class Registers
    {
        public readonly struct EAX : IRegOp32<EAX,N0>
        {
            public const uint Width = IRegOp32.Width;

            public const int Index = 0;
        
            public K Kind => K.EAX;
        }

        public readonly struct ECX : IRegOp32<ECX,N1>
        {
            public const uint Width = IRegOp32.Width;

            public const int Index = 1;

            public K Kind => K.ECX;
        }    

        public readonly struct EDX : IRegOp32<EDX,N2>
        {
            public const uint Width = IRegOp32.Width;

            public const int Index = 2;

            public K Kind => K.EDX;
        }    

        public readonly struct EBX : IRegOp32<EBX,N3>
        {
            public const uint Width = IRegOp32.Width;

            public const int Index = 3;

            public K Kind => K.EBX;
        }    

        public readonly struct ESI : IRegOp32<ESI,N4>
        {
            public const uint Width = IRegOp32.Width;

            public const int Index = 4;

            public K Kind => K.ESI;
        }    

        public readonly struct EDI : IRegOp32<EDI,N5>
        {
            public const uint Width = IRegOp32.Width;

            public const int Index = 5;

            public K Kind => K.EDI;
        }        

        public readonly struct ESP : IRegOp32<ESP,N6>
        {
            public const uint Width = IRegOp32.Width;

            public const int Index = 6;

            public S State {get;}

            public K Kind => K.ESP;
        }            

        public readonly struct EBP : IRegOp32<EBP,N7>
        {
            public const uint Width = IRegOp32.Width;

            public const int Index = 7;

            public K Kind => K.EBP;
        }                

        public readonly struct R8D : IRegOp32<R8D,N8>
        {
            public const uint Width = IRegOp32.Width;

            public const int Index = 8;

            public K Kind => K.R8D;
        }                    

        public readonly struct R9D : IRegOp32<R9D,N9>
        {
            public const uint Width = IRegOp32.Width;

            public const int Index = 9;

            public K Kind => K.R9D;
        }                        

        public readonly struct R10D : IRegOp32<R10D,N10>
        {
            public const uint Width = IRegOp32.Width;

            public const int Index = 10;

            public K Kind => K.R10D;
        }                        

        public readonly struct R11D : IRegOp32<R11D,N11>
        {
            public const uint Width = IRegOp32.Width;

            public const int Index = 11;

            public K Kind => K.R11D;
        }                        

        public readonly struct R12D : IRegOp32<R12D,N12>
        {
            public const uint Width = IRegOp32.Width;

            public const int Index = 12;

            public K Kind => K.R12D;
        }                    

        public readonly struct R13D : IRegOp32<R13D,N13>
        {
            public const uint Width = IRegOp32.Width;

            public const int Index = 13;

            public K Kind => K.R13D;
        }                        

        public readonly struct R14D : IRegOp32<R14D,N14>
        {
            public const uint Width = IRegOp32.Width;

            public const int Index = 14;

            public K Kind => K.R14D;
        }                        

        public readonly struct R15D : IRegOp32<R15D,N15>
        {
            public const uint Width = IRegOp32.Width;

            public const int Index = 15;

            public K Kind => K.R15D;
        }
    }
}