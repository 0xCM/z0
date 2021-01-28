//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using K = RegisterKind;
    using W = W32;
    using T = System.UInt32;
    using G = R32;

    partial struct AsmDsl
    {
        /// <summary>
        /// Defines an operand that specifies a 32-bit gp register
        /// </summary>
        public struct r32 : IRegister<r32,W,T>, IAsmOperand<K,T>
        {
            public T Content {get;}

            public K Kind {get;}

            [MethodImpl(Inline)]
            public r32(T src, K kind)
            {
                Content = src;
                Kind = kind;
            }
        }

        public struct eax : IRegister<eax,W,T>
        {
            public T Content {get;}

            [MethodImpl(Inline)]
            public eax(T value)
                => Content = value;

            public K Kind => K.EAX;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, Kind);
            }

            [MethodImpl(Inline)]
            public static implicit operator R32(eax src)
                => src.Generalized;
        }

        public struct ecx : IRegister<ecx,W,T>
        {
            public T Content {get;}

            [MethodImpl(Inline)]
            public static implicit operator G(ecx src)
                => src.Generalized;

            [MethodImpl(Inline)]
            public ecx(T value)
                => Content = value;

            public K Kind => K.ECX;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get => new G(Content, Kind);
            }
        }

        public struct edx : IRegister<edx,W,T>
        {
            public T Content {get;}


            [MethodImpl(Inline)]
            public static implicit operator G(edx src)
                => src.Generalized;

            [MethodImpl(Inline)]
            public edx(T value)
                => Content = value;

            public K Kind => K.EDX;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, Kind);
            }
        }

        public struct ebx : IRegister<ebx,W,T>
        {
            public T Content {get;}

            [MethodImpl(Inline)]
            public static implicit operator G(ebx src)
                => src.Generalized;

            [MethodImpl(Inline)]
            public ebx(T value)
                => Content = value;

            public K Kind => K.EBX;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, Kind);
            }
        }

        public struct esi : IRegister<esi,W,T>
        {
            public T Content {get;}

            [MethodImpl(Inline)]
            public static implicit operator G(esi src)
                => src.Generalized;

            [MethodImpl(Inline)]
            public esi(T value)
                => Content = value;

            public K Kind => K.ESI;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, Kind);
            }
        }

        public struct edi : IRegister<edi,W,T>
        {
            public T Content {get;}

            [MethodImpl(Inline)]
            public static implicit operator G(edi src)
                => src.Generalized;

            [MethodImpl(Inline)]
            public edi(T value)
                => Content = value;

            public K Kind => K.EDI;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, Kind);
            }
        }

        public struct esp : IRegister<esp,W,T>
        {
            public T Content {get;}

            [MethodImpl(Inline)]
            public static implicit operator G(esp src)
                => src.Generalized;

            [MethodImpl(Inline)]
            public esp(T value)
                => Content = value;

            public K Kind => K.ESP;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, Kind);
            }
        }

        public struct ebp : IRegister<ebp,W,T>
        {
            public T Content {get;}

            [MethodImpl(Inline)]
            public static implicit operator G(ebp src)
                => src.Generalized;

            [MethodImpl(Inline)]
            public ebp(T value)
            {
                Content = value;
            }

            public K Kind => K.EBP;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, Kind);
            }
        }

        public struct r8d : IRegister<r8d,W,T>
        {
            public T Content {get;}

            [MethodImpl(Inline)]
            public r8d(T value)
                => Content = value;

            public K Kind => K.R8D;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, Kind);
            }
        }

        public struct r9d : IRegister<r9d,W,T>
        {
            public T Content {get;}

            [MethodImpl(Inline)]
            public r9d(T value)
            {
                Content = value;
            }

            public K Kind => K.R9D;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, Kind);
            }
        }

        public struct r10d : IRegister<r10d,W,T>
        {
            public T Content {get;}

            [MethodImpl(Inline)]
            public r10d(T value)
                => Content = value;

            public K Kind => K.R10D;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, Kind);
            }
        }

        public struct r11d : IRegister<r11d,W,T>
        {
            public T Content {get;}

            [MethodImpl(Inline)]
            public r11d(T value)
                => Content = value;

            public K Kind => K.R11D;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, Kind);
            }
        }

        public struct r12d : IRegister<r12d,W,T>
        {
            public T Content {get;}

            [MethodImpl(Inline)]
            public r12d(T value)
                => Content = value;

            public K Kind => K.R12D;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, Kind);
            }
        }

        public struct r13d : IRegister<r13d,W,T>
        {
            public T Content {get;}

            [MethodImpl(Inline)]
            public r13d(T value)
            {
                Content = value;
            }

            public K Kind => K.R13D;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, Kind);
            }
        }

        public struct r14d : IRegister<r14d,W,T>
        {
            public T Content {get;}


            [MethodImpl(Inline)]
            public r14d(T value)
                => Content = value;

            public K Kind => K.R14D;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, Kind);
            }
        }

        public struct r15d : IRegister<r15d,W,T>
        {
            public T Content {get;}

            [MethodImpl(Inline)]
            public r15d(T value)
                => Content = value;

            public K Kind => K.R15D;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, Kind);
            }
        }
    }
}