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

    public readonly struct eax : IRegOperand32<eax,uint>
    {            
        public uint Content {get;}

        [MethodImpl(Inline)]
        public static implicit operator R32(eax src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public eax(uint value)
        {
            Content = value;
        }
                    
        public K Kind => K.EAX;

        public R32 Generalized
        {
            [MethodImpl(Inline)]
            get =>new R32(Content, Kind);
        }
    }

    public readonly struct ecx : IRegOperand32<ecx,uint>
    {
        public uint Content {get;}

        [MethodImpl(Inline)]
        public static implicit operator R32(ecx src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public ecx(uint value)
        {
            Content = value;
        }

        public K Kind => K.ECX;

        public R32 Generalized
        {
            [MethodImpl(Inline)]
            get =>new R32(Content, Kind);
        }
    }    

    public readonly struct edx : IRegOperand32<edx,uint>
    {
        public uint Content {get;}


        [MethodImpl(Inline)]
        public static implicit operator R32(edx src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public edx(uint value)
        {
            Content = value;
        }

        public K Kind => K.EDX;

        public R32 Generalized
        {
            [MethodImpl(Inline)]
            get =>new R32(Content, Kind);
        }
    }    

    public readonly struct ebx : IRegOperand32<ebx,uint>
    {
        public uint Content {get;}

        [MethodImpl(Inline)]
        public static implicit operator R32(ebx src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public ebx(uint value)
        {
            Content = value;
        }

        public K Kind => K.EBX;

        public R32 Generalized
        {
            [MethodImpl(Inline)]
            get =>new R32(Content, Kind);
        }
    }    

    public readonly struct esi : IRegOperand32<esi,uint>
    {            
        public uint Content {get;}

        [MethodImpl(Inline)]
        public static implicit operator R32(esi src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public esi(uint value)
        {
            Content = value;
        }

        public K Kind => K.ESI;

        public R32 Generalized
        {
            [MethodImpl(Inline)]
            get =>new R32(Content, Kind);
        }
    }    

    public readonly struct edi : IRegOperand32<edi,uint>
    {
        public uint Content {get;}

        [MethodImpl(Inline)]
        public static implicit operator R32(edi src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public edi(uint value)
        {
            Content = value;
        }

        public K Kind => K.EDI;

        public R32 Generalized
        {
            [MethodImpl(Inline)]
            get =>new R32(Content, Kind);
        }
    }        

    public readonly struct esp : IRegOperand32<esp,uint>
    {            
        public uint Content {get;}

        [MethodImpl(Inline)]
        public static implicit operator R32(esp src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public esp(uint value)
        {
            Content = value;
        }

        public K Kind => K.ESP;

        public R32 Generalized
        {
            [MethodImpl(Inline)]
            get =>new R32(Content, Kind);
        }
    }            

    public readonly struct ebp : IRegOperand32<ebp,uint>
    {
        public uint Content {get;}

        [MethodImpl(Inline)]
        public static implicit operator R32(ebp src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public ebp(uint value)
        {
            Content = value;
        }

        public K Kind => K.EBP;

        public R32 Generalized
        {
            [MethodImpl(Inline)]
            get =>new R32(Content, Kind);
        }
    }                

    public readonly struct r8d : IRegOperand32<r8d,uint>
    {
        public uint Content {get;}

        [MethodImpl(Inline)]
        public r8d(uint value)
        {
            Content = value;
        }

        public K Kind => K.R8D;

        public R32 Generalized
        {
            [MethodImpl(Inline)]
            get =>new R32(Content, Kind);
        }
    }                    

    public readonly struct r9d : IRegOperand32<r9d,uint>
    {            
        public uint Content {get;}

        [MethodImpl(Inline)]
        public r9d(uint value)
        {
            Content = value;
        }

        public K Kind => K.R9D;

        public R32 Generalized
        {
            [MethodImpl(Inline)]
            get =>new R32(Content, Kind);
        }
    }                        

    public readonly struct r10d : IRegOperand32<r10d,uint>
    {            
        public uint Content {get;}

        [MethodImpl(Inline)]
        public r10d(uint value)
        {
            Content = value;
        }

        public K Kind => K.R10D;

        public R32 Generalized
        {
            [MethodImpl(Inline)]
            get =>new R32(Content, Kind);
        }
    }                        

    public readonly struct r11d : IRegOperand32<r11d,uint>
    {
        public uint Content {get;}

        [MethodImpl(Inline)]
        public r11d(uint value)
        {
            Content = value;
        }

        public K Kind => K.R11D;

        public R32 Generalized
        {
            [MethodImpl(Inline)]
            get =>new R32(Content, Kind);
        }
    }                        

    public readonly struct r12d : IRegOperand32<r12d,uint>
    {            
        public uint Content {get;}

        [MethodImpl(Inline)]
        public r12d(uint value)
        {
            Content = value;
        }

        public K Kind => K.R12D;

        public R32 Generalized
        {
            [MethodImpl(Inline)]
            get =>new R32(Content, Kind);
        }
    }                    

    public readonly struct r13d : IRegOperand32<r13d,uint>
    {
        public uint Content {get;}
        
        [MethodImpl(Inline)]
        public r13d(uint value)
        {
            Content = value;
        }
        
        public K Kind => K.R13D;

        public R32 Generalized
        {
            [MethodImpl(Inline)]
            get =>new R32(Content, Kind);
        }
    }                        

    public readonly struct r14d : IRegOperand32<r14d,uint>
    {
        public uint Content {get;}


        [MethodImpl(Inline)]
        public r14d(uint value)
        {
            Content = value;
        }

        public K Kind => K.R14D;

        public R32 Generalized
        {
            [MethodImpl(Inline)]
            get =>new R32(Content, Kind);
        }
    }                        

    public readonly struct r15d : IRegOperand32<r15d,uint>
    {            
        public uint Content {get;}

        [MethodImpl(Inline)]
        public r15d(uint value)
        {
            Content = value;
        }

        public K Kind => K.R15D;

        public R32 Generalized
        {
            [MethodImpl(Inline)]
            get =>new R32(Content, Kind);
        }
    } 
}