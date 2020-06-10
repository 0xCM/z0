//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    using K = RegisterKind;

    partial class Regs
    {
        public readonly struct eax : IRegOp32<eax,N0>
        {            
            public Fixed32 Value {get;}

            [MethodImpl(Inline)]
            public eax(Fixed32 value)
            {
                Value = value;
            }
                        
            public K Kind => K.EAX;
        }

        public readonly struct ecx : IRegOp32<ecx,N1>
        {
            public Fixed32 Value {get;}

            [MethodImpl(Inline)]
            public ecx(Fixed32 value)
            {
                Value = value;
            }

            public K Kind => K.ECX;
        }    

        public readonly struct edx : IRegOp32<edx,N2>
        {
            public Fixed32 Value {get;}


            [MethodImpl(Inline)]
            public edx(Fixed32 value)
            {
                Value = value;
            }

            public K Kind => K.EDX;
        }    

        public readonly struct ebx : IRegOp32<ebx,N3>
        {
            public Fixed32 Value {get;}

            [MethodImpl(Inline)]
            public ebx(Fixed32 value)
            {
                Value = value;
            }

            public K Kind => K.EBX;
        }    

        public readonly struct esi : IRegOp32<esi,N4>
        {            
            public Fixed32 Value {get;}

            [MethodImpl(Inline)]
            public esi(Fixed32 value)
            {
                Value = value;
            }

            public K Kind => K.ESI;
        }    

        public readonly struct edi : IRegOp32<edi,N5>
        {
            public Fixed32 Value {get;}

            [MethodImpl(Inline)]
            public edi(Fixed32 value)
            {
                Value = value;
            }

            public K Kind => K.EDI;
        }        

        public readonly struct esp : IRegOp32<esp,N6>
        {            
            public Fixed32 Value {get;}

            [MethodImpl(Inline)]
            public esp(Fixed32 value)
            {
                Value = value;
            }

            public K Kind => K.ESP;
        }            

        public readonly struct ebp : IRegOp32<ebp,N7>
        {
            public Fixed32 Value {get;}

            public K Kind => K.EBP;
        }                

        public readonly struct r8d : IRegOp32<r8d,N8>
        {
            public Fixed32 Value {get;}

            public K Kind => K.R8D;
        }                    

        public readonly struct r9d : IRegOp32<r9d,N9>
        {            
            public Fixed32 Value {get;}

            public K Kind => K.R9D;
        }                        

        public readonly struct r10d : IRegOp32<r10d,N10>
        {            
            public Fixed32 Value {get;}

            public K Kind => K.R10D;

        }                        

        public readonly struct r11d : IRegOp32<r11d,N11>
        {
            public Fixed32 Value {get;}

            public K Kind => K.R11D;
        }                        

        public readonly struct r12d : IRegOp32<r12d,N12>
        {            
            public Fixed32 Value {get;}

            public K Kind => K.R12D;
        }                    

        public readonly struct r13d : IRegOp32<r13d,N13>
        {
            public Fixed32 Value {get;}
            
            public K Kind => K.R13D;
        }                        

        public readonly struct r14d : IRegOp32<r14d,N14>
        {
            public Fixed32 Value {get;}

            public K Kind => K.R14D;
        }                        

        public readonly struct r15d : IRegOp32<r15d,N15>
        {            
            public Fixed32 Value {get;}

            public K Kind => K.R15D;
        }
    }
}