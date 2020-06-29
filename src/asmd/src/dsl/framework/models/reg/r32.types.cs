//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    using K = RegisterKind;

    public readonly struct eax : IRegOp32<eax,N0>
    {            
        public uint Content {get;}

        [MethodImpl(Inline)]
        public static implicit operator r32(eax src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public eax(uint value)
        {
            Content = value;
        }
                    
        public K Kind => K.EAX;

        public r32 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r32(Content, Kind);
        }
    }

    public readonly struct ecx : IRegOp32<ecx,N1>
    {
        public uint Content {get;}

        [MethodImpl(Inline)]
        public static implicit operator r32(ecx src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public ecx(uint value)
        {
            Content = value;
        }

        public K Kind => K.ECX;

        public r32 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r32(Content, Kind);
        }
    }    

    public readonly struct edx : IRegOp32<edx,N2>
    {
        public uint Content {get;}


        [MethodImpl(Inline)]
        public static implicit operator r32(edx src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public edx(uint value)
        {
            Content = value;
        }

        public K Kind => K.EDX;

        public r32 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r32(Content, Kind);
        }
    }    

    public readonly struct ebx : IRegOp32<ebx,N3>
    {
        public uint Content {get;}

        [MethodImpl(Inline)]
        public static implicit operator r32(ebx src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public ebx(uint value)
        {
            Content = value;
        }

        public K Kind => K.EBX;

        public r32 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r32(Content, Kind);
        }
    }    

    public readonly struct esi : IRegOp32<esi,N4>
    {            
        public uint Content {get;}

        [MethodImpl(Inline)]
        public static implicit operator r32(esi src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public esi(uint value)
        {
            Content = value;
        }

        public K Kind => K.ESI;

        public r32 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r32(Content, Kind);
        }
    }    

    public readonly struct edi : IRegOp32<edi,N5>
    {
        public uint Content {get;}

        [MethodImpl(Inline)]
        public static implicit operator r32(edi src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public edi(uint value)
        {
            Content = value;
        }

        public K Kind => K.EDI;

        public r32 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r32(Content, Kind);
        }
    }        

    public readonly struct esp : IRegOp32<esp,N6>
    {            
        public uint Content {get;}

        [MethodImpl(Inline)]
        public static implicit operator r32(esp src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public esp(uint value)
        {
            Content = value;
        }

        public K Kind => K.ESP;

        public r32 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r32(Content, Kind);
        }
    }            

    public readonly struct ebp : IRegOp32<ebp,N7>
    {
        public uint Content {get;}

        [MethodImpl(Inline)]
        public static implicit operator r32(ebp src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public ebp(uint value)
        {
            Content = value;
        }

        public K Kind => K.EBP;

        public r32 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r32(Content, Kind);
        }
    }                

    public readonly struct r8d : IRegOp32<r8d,N8>
    {
        public uint Content {get;}

        [MethodImpl(Inline)]
        public r8d(uint value)
        {
            Content = value;
        }

        public K Kind => K.R8D;

        public r32 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r32(Content, Kind);
        }
    }                    

    public readonly struct r9d : IRegOp32<r9d,N9>
    {            
        public uint Content {get;}

        [MethodImpl(Inline)]
        public r9d(uint value)
        {
            Content = value;
        }

        public K Kind => K.R9D;

        public r32 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r32(Content, Kind);
        }
    }                        

    public readonly struct r10d : IRegOp32<r10d,N10>
    {            
        public uint Content {get;}

        [MethodImpl(Inline)]
        public r10d(uint value)
        {
            Content = value;
        }

        public K Kind => K.R10D;

        public r32 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r32(Content, Kind);
        }
    }                        

    public readonly struct r11d : IRegOp32<r11d,N11>
    {
        public uint Content {get;}

        [MethodImpl(Inline)]
        public r11d(uint value)
        {
            Content = value;
        }

        public K Kind => K.R11D;

        public r32 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r32(Content, Kind);
        }
    }                        

    public readonly struct r12d : IRegOp32<r12d,N12>
    {            
        public uint Content {get;}

        [MethodImpl(Inline)]
        public r12d(uint value)
        {
            Content = value;
        }

        public K Kind => K.R12D;

        public r32 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r32(Content, Kind);
        }
    }                    

    public readonly struct r13d : IRegOp32<r13d,N13>
    {
        public uint Content {get;}
        
        [MethodImpl(Inline)]
        public r13d(uint value)
        {
            Content = value;
        }
        
        public K Kind => K.R13D;

        public r32 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r32(Content, Kind);
        }
    }                        

    public readonly struct r14d : IRegOp32<r14d,N14>
    {
        public uint Content {get;}


        [MethodImpl(Inline)]
        public r14d(uint value)
        {
            Content = value;
        }

        public K Kind => K.R14D;

        public r32 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r32(Content, Kind);
        }
    }                        

    public readonly struct r15d : IRegOp32<r15d,N15>
    {            
        public uint Content {get;}

        [MethodImpl(Inline)]
        public r15d(uint value)
        {
            Content = value;
        }

        public K Kind => K.R15D;

        public r32 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r32(Content, Kind);
        }
    } 
}