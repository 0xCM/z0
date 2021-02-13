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
    using W = W64;
    using T = System.UInt64;
    using G = AsmRegs.r64;

    partial struct AsmRegs
    {
        /// <summary>
        /// Defines an operand that specifies a 64-bit gp register
        /// </summary>
        public struct r64 : IRegister<r64,W,T>, IRegOp64<T>
        {
            public T Content {get;}

            public K RegKind {get;}

            [MethodImpl(Inline)]
            public r64(T src, K kind)
            {
                Content = src;
                RegKind = kind;
            }
        }

        public struct R64<R> : IRegister<R64<R>,W64,ulong>, IRegOp64<ulong>
            where R : unmanaged, IRegOp64
        {
            public ulong Content {get;}

            [MethodImpl(Inline)]
            public R64(ulong src)
                => Content= src;

            public RegisterKind RegKind
            {
                [MethodImpl(Inline)]
                get => default(R).RegKind;
            }

            [MethodImpl(Inline)]
            public static implicit operator r64(R64<R> src)
                => new r64(src.Content, src.RegKind);
        }

        /// <summary>
        /// Represents the <see cref='K.RAX'/> register
        /// </summary>
        /// <remarks>
        /// | 000  | rax    | eax    | ax     | al    |
        /// </remarks>
        public struct rax : IRegister<rax,W,T>, IRegOp64<T>
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

            public K RegKind => K.RAX;

            [MethodImpl(Inline)]
            public static implicit operator G(rax src)
                => new G(src.Content, src.RegKind);
        }

        /// <summary>
        /// Register C Extended
        /// </summary>
        public struct rcx : IRegister<rcx,W,T>, IRegOp64<T>
        {
            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public static implicit operator G(rcx src)
                => new G(src.Content, src.RegKind);

            [MethodImpl(Inline)]
            public rcx(T value)
                => Data = value;

            public K RegKind => K.RAX;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get => new G(Content, RegKind);
            }
        }

        /// <summary>
        /// Register D Extended
        /// </summary>
        public struct rdx : IRegister<rdx,W,T>, IRegOp64<T>
        {
            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public static implicit operator G(rdx src)
                => new G(src.Content, src.RegKind);

            [MethodImpl(Inline)]
            public rdx(T value)
                => Data = value;

            public K RegKind => K.RDX;
        }

        /// <summary>
        /// Register B Extended
        /// </summary>
        public struct rbx : IRegister<rbx,W,T>, IRegOp64<T>
        {
            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public static implicit operator G(rbx src)
                => new G(src.Content, src.RegKind);

            [MethodImpl(Inline)]
            public rbx(T value)
                => Data = value;

            public K RegKind => K.RBX;
        }

        /// <summary>
        /// Register Source Index: Specifies the source for data copies
        /// </summary>
        public struct rsi : IRegister<rsi,W,T>, IRegOp64<T>
        {
            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public static implicit operator G(rsi src)
                => new G(src.Content, src.RegKind);

            [MethodImpl(Inline)]
            public rsi(T value)
                => Data = value;

            public K RegKind => K.RSI;

        }

        /// <summary>
        /// Register Destination Index: Specifies the target for data copies
        /// </summary>
        public struct rdi : IRegister<rdi,W,T>, IRegOp64<T>
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

            public K RegKind => K.RDI;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, RegKind);
            }

            [MethodImpl(Inline)]
            public static implicit operator G(rdi src)
                => new G(src.Content, src.RegKind);
        }

        /// <summary>
        /// Register Stack Pointer: Specifies the current location in stack and grows downwards
        /// </summary>
        public struct rsp : IRegister<rsp,W,T>, IRegOp64<T>
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

            public K RegKind => K.RSP;

            [MethodImpl(Inline)]
            public static implicit operator G(rsp src)
                => new G(src.Content, src.RegKind);
        }

        /// <summary>
        /// Register Base Pointer: Specifies the top of the stack
        /// </summary>
        public struct rbp : IRegister<rbp,W,T>, IRegOp64<T>
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

            public K RegKind => K.RBP;

            [MethodImpl(Inline)]
            public static implicit operator G(rbp src)
                => new G(src.Content, src.RegKind);
        }

        public struct r8q : IRegister<r8q,W,T>, IRegOp64<T>
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

            public K RegKind => K.R8Q;

            [MethodImpl(Inline)]
            public static implicit operator G(r8q src)
                => new G(src.Content, src.RegKind);
        }

        public struct r9q : IRegister<r9q,W,T>, IRegOp64<T>
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

            public K RegKind => K.R9Q;

            [MethodImpl(Inline)]
            public static implicit operator G(r9q src)
                => new G(src.Content, src.RegKind);

        }

        public struct r10q : IRegister<r10q,W,T>, IRegOp64<T>
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

            public K RegKind => K.R10Q;

            [MethodImpl(Inline)]
            public static implicit operator G(r10q src)
                => new G(src.Content, src.RegKind);

        }

        public struct r11q : IRegister<r11q,W,T>, IRegOp64<T>
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

            public K RegKind => K.R11Q;

            [MethodImpl(Inline)]
            public static implicit operator G(r11q src)
                => new G(src.Content, src.RegKind);
        }

        public struct r12q : IRegister<r12q,W,T>, IRegOp64<T>
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

            public K RegKind => K.R12Q;

            [MethodImpl(Inline)]
            public static implicit operator G(r12q src)
                => new G(src.Content, src.RegKind);

        }

        public struct r13q : IRegister<r13q,W,T>, IRegOp64<T>
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

            public K RegKind => K.R13Q;

            [MethodImpl(Inline)]
            public static implicit operator G(r13q src)
                => new G(src.Content, src.RegKind);
        }

        public struct r14q : IRegister<r14q,W,T>, IRegOp64<T>
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

            public K RegKind => K.R14Q;

            [MethodImpl(Inline)]
            public static implicit operator G(r14q src)
                => new G(src.Content, src.RegKind);
        }

        public struct r15q : IRegister<r15q,W,T>, IRegOp64<T>
        {
            public T Content {get;}

            [MethodImpl(Inline)]
            public r15q(T value)
                => Content = value;

            public K RegKind => K.R15Q;

            [MethodImpl(Inline)]
            public static implicit operator G(r15q src)
                => new G(src.Content, src.RegKind);
        }
    }
}