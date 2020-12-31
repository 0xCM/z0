//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using K = RegisterKind;

    partial struct XRegisters
    {
        public struct eax : IRegister<eax,W32,uint>
        {
            public uint Content {get;}

            [MethodImpl(Inline)]
            public static implicit operator R32(eax src)
                => src.Generalized;

            [MethodImpl(Inline)]
            public eax(uint value)
                => Content = value;

            public K Kind => K.EAX;

            public R32 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R32(Content, Kind);
            }
        }

        public struct ecx : IRegister<ecx,W32,uint>
        {
            public uint Content {get;}

            [MethodImpl(Inline)]
            public static implicit operator R32(ecx src)
                => src.Generalized;

            [MethodImpl(Inline)]
            public ecx(uint value)
                => Content = value;

            public K Kind => K.ECX;

            public R32 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R32(Content, Kind);
            }
        }

        public struct edx : IRegister<edx,W32,uint>
        {
            public uint Content {get;}


            [MethodImpl(Inline)]
            public static implicit operator R32(edx src)
                => src.Generalized;

            [MethodImpl(Inline)]
            public edx(uint value)
                => Content = value;

            public K Kind => K.EDX;

            public R32 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R32(Content, Kind);
            }
        }

        public struct ebx : IRegister<ebx,W32,uint>
        {
            public uint Content {get;}

            [MethodImpl(Inline)]
            public static implicit operator R32(ebx src)
                => src.Generalized;

            [MethodImpl(Inline)]
            public ebx(uint value)
                => Content = value;

            public K Kind => K.EBX;

            public R32 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R32(Content, Kind);
            }
        }

        public struct esi : IRegister<esi,W32,uint>
        {
            public uint Content {get;}

            [MethodImpl(Inline)]
            public static implicit operator R32(esi src)
                => src.Generalized;

            [MethodImpl(Inline)]
            public esi(uint value)
                => Content = value;

            public K Kind => K.ESI;

            public R32 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R32(Content, Kind);
            }
        }

        public struct edi : IRegister<edi,W32,uint>
        {
            public uint Content {get;}

            [MethodImpl(Inline)]
            public static implicit operator R32(edi src)
                => src.Generalized;

            [MethodImpl(Inline)]
            public edi(uint value)
                => Content = value;

            public K Kind => K.EDI;

            public R32 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R32(Content, Kind);
            }
        }

        public struct esp : IRegister<esp,W32,uint>
        {
            public uint Content {get;}

            [MethodImpl(Inline)]
            public static implicit operator R32(esp src)
                => src.Generalized;

            [MethodImpl(Inline)]
            public esp(uint value)
                => Content = value;

            public K Kind => K.ESP;

            public R32 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R32(Content, Kind);
            }
        }

        public struct ebp : IRegister<ebp,W32,uint>
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

        public struct r8d : IRegister<r8d,W32,uint>
        {
            public uint Content {get;}

            [MethodImpl(Inline)]
            public r8d(uint value)
                => Content = value;

            public K Kind => K.R8D;

            public R32 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R32(Content, Kind);
            }
        }

        public struct r9d : IRegister<r9d,W32,uint>
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

        public struct r10d : IRegister<r10d,W32,uint>
        {
            public uint Content {get;}

            [MethodImpl(Inline)]
            public r10d(uint value)
                => Content = value;

            public K Kind => K.R10D;

            public R32 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R32(Content, Kind);
            }
        }

        public struct r11d : IRegister<r11d,W32,uint>
        {
            public uint Content {get;}

            [MethodImpl(Inline)]
            public r11d(uint value)
                => Content = value;

            public K Kind => K.R11D;

            public R32 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R32(Content, Kind);
            }
        }

        public struct r12d : IRegister<r12d,W32,uint>
        {
            public uint Content {get;}

            [MethodImpl(Inline)]
            public r12d(uint value)
                => Content = value;

            public K Kind => K.R12D;

            public R32 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R32(Content, Kind);
            }
        }

        public struct r13d : IRegister<r13d,W32,uint>
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

        public struct r14d : IRegister<r14d,W32,uint>
        {
            public uint Content {get;}


            [MethodImpl(Inline)]
            public r14d(uint value)
                => Content = value;

            public K Kind => K.R14D;

            public R32 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R32(Content, Kind);
            }
        }

        public struct r15d : IRegister<r15d,W32,uint>
        {
            public uint Content {get;}

            [MethodImpl(Inline)]
            public r15d(uint value)
                => Content = value;

            public K Kind => K.R15D;

            public R32 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R32(Content, Kind);
            }
        }
    }
}