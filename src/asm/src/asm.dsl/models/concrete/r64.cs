//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmDsl;

    using K = RegisterKind;
    using W = W64;
    using T = System.UInt64;
    using G = R64;

    partial struct AsmDsl
    {
        /// <summary>
        /// Defines an operand that specifies a 64-bit gp register
        /// </summary>
        public struct r64 : IRegister<r64,W,T>, IAsmOperand<K,T>
        {
            public T Content {get;}

            public K Kind {get;}

            [MethodImpl(Inline)]
            public r64(T src, K kind)
            {
                Content = src;
                Kind = kind;
            }
        }

        /// <summary>
        /// Represents the <see cref='K.RAX'/> register
        /// </summary>
        /// <remarks>
        /// | 000  | rax    | eax    | ax     | al    |
        /// </remarks>
        public struct rax : IRegister<rax,W,T>
        {
            public T Content {get;}

            [MethodImpl(Inline)]
            public rax(T value)
                => Content = value;

            public eax Eax
            {
                [MethodImpl(Inline)]
                get => new eax((uint)Content);
            }

            public ax Ax
            {
                [MethodImpl(Inline)]
                get => new ax((ushort)Content);
            }

            public al Al
            {
                [MethodImpl(Inline)]
                get => new al((byte)Content);
            }

            public K Kind => K.RAX;

            [MethodImpl(Inline)]
            public static implicit operator G(rax src)
                => new G(src.Content, src.Kind);
        }

        /// <summary>
        /// Register C Extended
        /// </summary>
        public struct rcx : IRegister<rcx,W,T>
        {
            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public static implicit operator G(rcx src)
                => new G(src.Content, src.Kind);

            [MethodImpl(Inline)]
            public rcx(T value)
                => Data = value;

            public K Kind => K.RAX;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get => new G(Content, Kind);
            }
        }

        /// <summary>
        /// Register D Extended
        /// </summary>
        public struct rdx : IRegister<rdx,W,T>
        {
            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public static implicit operator G(rdx src)
                => new G(src.Content, src.Kind);

            [MethodImpl(Inline)]
            public rdx(T value)
                => Data = value;

            public K Kind => K.RDX;
        }

        /// <summary>
        /// Register B Extended
        /// </summary>
        public struct rbx : IRegister<rbx,W,T>
        {
            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public static implicit operator G(rbx src)
                => new G(src.Content, src.Kind);

            [MethodImpl(Inline)]
            public rbx(T value)
                => Data = value;

            public K Kind => K.RBX;
        }

        /// <summary>
        /// Register Source Index: Specifies the source for data copies
        /// </summary>
        public struct rsi : IRegister<rsi,W,T>
        {
            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public static implicit operator G(rsi src)
                => new G(src.Content, src.Kind);

            [MethodImpl(Inline)]
            public rsi(T value)
                => Data = value;

            public K Kind => K.RSI;

        }

        /// <summary>
        /// Register Destination Index: Specifies the target for data copies
        /// </summary>
        public struct rdi : IRegister<rdi,W,T>
        {
            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public rdi(T value)
                => Data = value;

            public K Kind => K.RDI;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, Kind);
            }

            [MethodImpl(Inline)]
            public static implicit operator G(rdi src)
                => new G(src.Content, src.Kind);
        }

        /// <summary>
        /// Register Stack Pointer: Specifies the current location in stack and grows downwards
        /// </summary>
        public struct rsp : IRegister<rsp,W,T>
        {
            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public rsp(T value)
                 => Data = value;

            public K Kind => K.RSP;

            [MethodImpl(Inline)]
            public static implicit operator G(rsp src)
                => new G(src.Content, src.Kind);
        }

        /// <summary>
        /// Register Base Pointer: Specifies the top of the stack
        /// </summary>
        public struct rbp : IRegister<rbp,W,T>
        {
            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public rbp(T value)
                => Data = value;

            public K Kind => K.RBP;

            [MethodImpl(Inline)]
            public static implicit operator G(rbp src)
                => new G(src.Content, src.Kind);
        }

        public struct r8q : IRegister<r8q,W,T>
        {
            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public r8q(T value)
                => Data = value;

            public K Kind => K.R8Q;

            [MethodImpl(Inline)]
            public static implicit operator G(r8q src)
                => new G(src.Content, src.Kind);
        }

        public struct r9q : IRegister<r9q,W,T>
        {
            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public r9q(T value)
                => Data = value;

            public K Kind => K.R9Q;

            [MethodImpl(Inline)]
            public static implicit operator G(r9q src)
                => new G(src.Content, src.Kind);

        }

        public struct r10q : IRegister<r10q,W,T>
        {
            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public r10q(T value)
                => Data = value;

            public K Kind => K.R10Q;

            [MethodImpl(Inline)]
            public static implicit operator G(r10q src)
                => new G(src.Content, src.Kind);

        }

        public struct r11q : IRegister<r11q,W,T>
        {
            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public r11q(T value)
                => Data = value;

            public K Kind => K.R11Q;

            [MethodImpl(Inline)]
            public static implicit operator G(r11q src)
                => new G(src.Content, src.Kind);
        }

        public struct r12q : IRegister<r12q,W,T>
        {
            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public r12q(T value)
                => Data = value;

            public K Kind => K.R12Q;

            [MethodImpl(Inline)]
            public static implicit operator G(r12q src)
                => new G(src.Content, src.Kind);

        }

        public struct r13q : IRegister<r13q,W,T>
        {
            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public r13q(T value)
                => Data = value;

            public K Kind => K.R13Q;

            [MethodImpl(Inline)]
            public static implicit operator G(r13q src)
                => new G(src.Content, src.Kind);
        }

        public struct r14q : IRegister<r14q,W,T>
        {
            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public r14q(T value)
                => Data = value;

            public K Kind => K.R14Q;

            [MethodImpl(Inline)]
            public static implicit operator G(r14q src)
                => new G(src.Content, src.Kind);
        }

        public struct r15q : IRegister<r15q,W,T>
        {
            public T Content {get;}

            [MethodImpl(Inline)]
            public r15q(T value)
                => Content = value;

            public K Kind => K.R15Q;

            [MethodImpl(Inline)]
            public static implicit operator G(r15q src)
                => new G(src.Content, src.Kind);
        }
    }
}