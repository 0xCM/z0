
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    partial class AsmExtend
    {
        /// <summary>
        /// Loads native code into the buffer for execution
        /// </summary>
        /// <param name="src">The source code (pun intended)</param>
        [MethodImpl(Inline)]
        public static ExecBufferToken Load(this ExecBufferToken buffer, in AsmCode src)
        {
            buffer.Fill(src.Encoded);
            return buffer;
        }

        [MethodImpl(Inline)]
        public static UnaryOp<T> UnaryOp<T>(this ExecBufferToken buffer, in TypedAsm<T> src)
            where T : unmanaged
                => buffer.Load(src).UnaryOp<T>(src.Id);

        [MethodImpl(Inline)]
        public static BinaryOp<T> BinaryOp<T>(this ExecBufferToken buffer, in TypedAsm<T> src)
            where T : unmanaged
                => buffer.Load(src).BinaryOp<T>(src.Id);
        
        [MethodImpl(Inline)]
        public static FixedFunc<X0,R> F<X0,R>(this ExecBufferToken buffer, in AsmCode src)
            where X0 : unmanaged, IFixed
            where R : unmanaged, IFixed             
                => buffer.Load(src).Func<X0,R>(src.Id);                                

        [MethodImpl(Inline)]
        public static FixedFunc<X0,X1,R> F<X0,X1,R>(this ExecBufferToken buffer, in AsmCode src)
            where X0 : unmanaged, IFixed
            where X1 : unmanaged, IFixed
            where R : unmanaged, IFixed
                => buffer.Load(src).Func<X0,X1,R>(src.Id);

        [MethodImpl(Inline)]
        public static FixedFunc<T,T> UnaryOp<T>(this ExecBufferToken buffer, in AsmCode src)
            where T : unmanaged, IFixed
                => buffer.F<T,T>(src);

        [MethodImpl(Inline)]
        public static FixedFunc<T,T,T> BinaryOp<T>(this ExecBufferToken buffer, in AsmCode src)
            where T : unmanaged, IFixed
                => buffer.Load(src).F<T,T,T>(src);
        
        [MethodImpl(Inline)]
        public static UnaryOp8 UnaryOp(this ExecBufferToken buffer, N8 w, in AsmCode src)
            => buffer.Load(src).UnaryOp(w, src.Id);

        [MethodImpl(Inline)]
        public static UnaryOp16 UnaryOp(this ExecBufferToken buffer, N16 w, in AsmCode src)               
            => buffer.Load(src).UnaryOp(w, src.Id);

        [MethodImpl(Inline)]
        public static UnaryOp32 UnaryOp(this ExecBufferToken buffer, N32 w, in AsmCode src)
            => buffer.Load(src).UnaryOp(w, src.Id);

        [MethodImpl(Inline)]
        public static UnaryOp64 UnaryOp(this ExecBufferToken buffer, N64 w, in AsmCode src)
            => buffer.Load(src).UnaryOp(w, src.Id);

        [MethodImpl(Inline)]
        public static UnaryOp128 UnaryOp(this ExecBufferToken buffer, N128 w, in AsmCode src)
            => buffer.Load(src).UnaryOp(w, src.Id);

        [MethodImpl(Inline)]
        public static UnaryOp256 UnaryOp(this ExecBufferToken buffer, N256 w, in AsmCode src)
            => buffer.Load(src).UnaryOp(w, src.Id);

        [MethodImpl(Inline)]
        public static BinaryOp8 BinaryOp(this ExecBufferToken buffer, N8 w, in AsmCode src)
            => buffer.Load(src).BinOp(w, src.Id);

        [MethodImpl(Inline)]
        public static BinaryOp16 BinaryOp(this ExecBufferToken buffer, N16 w, in AsmCode src)
            => buffer.Load(src).BinOp(w, src.Id);

        [MethodImpl(Inline)]
        public static BinaryOp32 BinaryOp(this ExecBufferToken buffer, N32 w, in AsmCode src)
            => buffer.Load(src).BinOp(w, src.Id);

        [MethodImpl(Inline)]
        public static BinaryOp64 BinaryOp(this ExecBufferToken buffer, N64 w, in AsmCode src)
            => buffer.Load(src).BinOp(w, src.Id);

        [MethodImpl(Inline)]
        public static BinaryOp128 BinaryOp(this ExecBufferToken buffer, N128 w, in AsmCode src)
            => buffer.Load(src).BinOp(w, src.Id);

        [MethodImpl(Inline)]
        public static BinaryOp256 BinaryOp(this ExecBufferToken buffer, N256 w, in AsmCode src)
            => buffer.Load(src).BinOp(w, src.Id); 
    }
}