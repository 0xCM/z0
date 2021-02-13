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
    using G = AsmRegs.r32;

    partial struct AsmRegs
    {
        /// <summary>
        /// Defines an operand that specifies a 32-bit gp register
        /// </summary>
        public struct r32 : IRegister<r32,W,T>, IRegOp32<T>
        {
            public T Content {get;}

            public K RegKind {get;}

            [MethodImpl(Inline)]
            public r32(T src, K kind)
            {
                Content = src;
                RegKind = kind;
            }
        }

        public readonly struct R32<R> : IRegister<R32<R>,W32,uint>, IRegOp32<uint>
            where R : unmanaged, IRegOp32
        {
            public uint Content {get;}

            [MethodImpl(Inline)]
            public R32(uint value)
                => Content = value;

            public RegisterKind RegKind
            {
                [MethodImpl(Inline)]
                get => default(R).RegKind;
            }

            [MethodImpl(Inline)]
            public static implicit operator r32(R32<R> src)
                => new r32(src.Content, src.RegKind);
        }
        public struct eax : IRegister<eax,W,T>, IRegOp32<T>
        {
            public T Content {get;}

            [MethodImpl(Inline)]
            public eax(T value)
                => Content = value;

            public K RegKind => K.EAX;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get => new G(Content, RegKind);
            }

            [MethodImpl(Inline)]
            public static implicit operator G(eax src)
                => src.Generalized;
        }

        public struct ecx : IRegister<ecx,W,T>, IRegOp32<T>
        {
            public T Content {get;}


            [MethodImpl(Inline)]
            public ecx(T value)
                => Content = value;

            public K RegKind => K.ECX;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get => new G(Content, RegKind);
            }

            [MethodImpl(Inline)]
            public static implicit operator G(ecx src)
                => src.Generalized;
        }

        public struct edx : IRegister<edx,W,T>, IRegOp32<T>
        {
            public T Content {get;}

            [MethodImpl(Inline)]
            public edx(T value)
                => Content = value;

            public K RegKind => K.EDX;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, RegKind);
            }

            [MethodImpl(Inline)]
            public static implicit operator G(edx src)
                => src.Generalized;
        }

        public struct ebx : IRegister<ebx,W,T>, IRegOp32<T>
        {
            public T Content {get;}


            [MethodImpl(Inline)]
            public ebx(T value)
                => Content = value;

            public K RegKind => K.EBX;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, RegKind);
            }

            [MethodImpl(Inline)]
            public static implicit operator G(ebx src)
                => src.Generalized;
        }

        public struct esi : IRegister<esi,W,T>, IRegOp32<T>
        {
            public T Content {get;}

            [MethodImpl(Inline)]
            public static implicit operator G(esi src)
                => src.Generalized;

            [MethodImpl(Inline)]
            public esi(T value)
                => Content = value;

            public K RegKind => K.ESI;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, RegKind);
            }
        }

        public struct edi : IRegister<edi,W,T>, IRegOp32<T>
        {
            public T Content {get;}

            [MethodImpl(Inline)]
            public static implicit operator G(edi src)
                => src.Generalized;

            [MethodImpl(Inline)]
            public edi(T value)
                => Content = value;

            public K RegKind => K.EDI;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, RegKind);
            }
        }

        public struct esp : IRegister<esp,W,T>, IRegOp32<T>
        {
            public T Content {get;}

            [MethodImpl(Inline)]
            public static implicit operator G(esp src)
                => src.Generalized;

            [MethodImpl(Inline)]
            public esp(T value)
                => Content = value;

            public K RegKind => K.ESP;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, RegKind);
            }
        }

        public struct ebp : IRegister<ebp,W,T>, IRegOp32<T>
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

            public K RegKind => K.EBP;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, RegKind);
            }
        }

        public struct r8d : IRegister<r8d,W,T>, IRegOp32<T>
        {
            public T Content {get;}

            [MethodImpl(Inline)]
            public r8d(T value)
                => Content = value;

            public K RegKind => K.R8D;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, RegKind);
            }
        }

        public struct r9d : IRegister<r9d,W,T>, IRegOp32<T>
        {
            public T Content {get;}

            [MethodImpl(Inline)]
            public r9d(T value)
            {
                Content = value;
            }

            public K RegKind => K.R9D;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, RegKind);
            }
        }

        public struct r10d : IRegister<r10d,W,T>, IRegOp32<T>
        {
            public T Content {get;}

            [MethodImpl(Inline)]
            public r10d(T value)
                => Content = value;

            public K RegKind => K.R10D;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, RegKind);
            }
        }

        public struct r11d : IRegister<r11d,W,T>, IRegOp32<T>
        {
            public T Content {get;}

            [MethodImpl(Inline)]
            public r11d(T value)
                => Content = value;

            public K RegKind => K.R11D;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, RegKind);
            }
        }

        public struct r12d : IRegister<r12d,W,T>, IRegOp32<T>
        {
            public T Content {get;}

            [MethodImpl(Inline)]
            public r12d(T value)
                => Content = value;

            public K RegKind => K.R12D;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, RegKind);
            }
        }

        public struct r13d : IRegister<r13d,W,T>, IRegOp32<T>
        {
            public T Content {get;}

            [MethodImpl(Inline)]
            public r13d(T value)
            {
                Content = value;
            }

            public K RegKind => K.R13D;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, RegKind);
            }
        }

        public struct r14d : IRegister<r14d,W,T>, IRegOp32<T>
        {
            public T Content {get;}


            [MethodImpl(Inline)]
            public r14d(T value)
                => Content = value;

            public K RegKind => K.R14D;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, RegKind);
            }
        }

        public struct r15d : IRegister<r15d,W,T>, IRegOp32<T>
        {
            public T Content {get;}

            [MethodImpl(Inline)]
            public r15d(T value)
                => Content = value;

            public K RegKind => K.R15D;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, RegKind);
            }
        }
    }
}