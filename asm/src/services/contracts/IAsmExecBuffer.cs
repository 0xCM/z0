
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public interface IAsmExecBuffer : IAsmServiceAllocation
    {                
        /// <summary>
        /// Loads native code into the buffer for execution
        /// </summary>
        /// <param name="src">The source code (pun intended)</param>
        IntPtr Load(in AsmCode src);

        IntPtr Handle {get;}
        
        [MethodImpl(Inline)]
        UnaryOp<T> UnaryOp<T>(in TypedAsm<T> src)
            where T : unmanaged
        {
            Load(src);
            return Dynop.UnaryOp<T>(src.Id, Handle);
        }

        [MethodImpl(Inline)]
        BinaryOp<T> BinaryOp<T>(in TypedAsm<T> src)
            where T : unmanaged
        {
            Load(src);
            return Dynop.BinOp<T>(src.Id, Handle);
        }

        [MethodImpl(Inline)]
        FixedFunc<X0,R> F<X0,R>(in AsmCode src)
            where X0 : unmanaged, IFixed
            where R : unmanaged, IFixed             
                => Dynop.Func<X0,R>(src.Id, Load(src));                                

        [MethodImpl(Inline)]
        FixedFunc<X0,X1,R> F<X0,X1,R>(in AsmCode src)
            where X0 : unmanaged, IFixed
            where X1 : unmanaged, IFixed
            where R : unmanaged, IFixed
                => Dynop.Func<X0,X1,R>(src.Id, Load(src));                
        
        [MethodImpl(Inline)]
        FixedFunc<T,T> UnaryOp<T>(in AsmCode src)
        where T : unmanaged, IFixed
            => F<T,T>(src);

        [MethodImpl(Inline)]
        FixedFunc<T,T,T> BinaryOp<T>(in AsmCode src)
            where T : unmanaged, IFixed
                => F<T,T,T>(src);

        [MethodImpl(Inline)]
        UnaryOp8 UnaryOp(N8 w, in AsmCode src)
        {
            Load(src);
            return Dynop.UnaryOp(w, src.Id, Handle);
        }

        [MethodImpl(Inline)]
        UnaryOp16 UnaryOp(N16 w, in AsmCode src)               
        {
            Load(src);
            return Dynop.UnaryOp(w, src.Id, Handle);
        }

        [MethodImpl(Inline)]
        UnaryOp32 UnaryOp(N32 w, in AsmCode src)
        {
            Load(src);
            return Dynop.UnaryOp(w, src.Id, Handle);
        }

        [MethodImpl(Inline)]
        UnaryOp64 UnaryOp(N64 w, in AsmCode src)
        {
            Load(src);
            return Dynop.UnaryOp(w, src.Id, Handle);
        }

        [MethodImpl(Inline)]
        UnaryOp128 UnaryOp(N128 w, in AsmCode src)
        {
            Load(src);
            return Dynop.UnaryOp(w, src.Id, Handle);
        }

        [MethodImpl(Inline)]
        UnaryOp256 UnaryOp(N256 w, in AsmCode src)
        {
            Load(src);
            return Dynop.UnaryOp(w, src.Id, Handle);
        }

        [MethodImpl(Inline)]
        BinaryOp8 BinaryOp(N8 w, in AsmCode src)
        {
            Load(src);
            return Dynop.BinOp(w, src.Id, Handle);
        }

        [MethodImpl(Inline)]
        BinaryOp16 BinaryOp(N16 w, in AsmCode src)
        {
            Load(src);
            return Dynop.BinOp(w, src.Id, Handle);
        }

        [MethodImpl(Inline)]
        BinaryOp32 BinaryOp(N32 w, in AsmCode src)
        {
            Load(src);
            return Dynop.BinOp(w, src.Id, Handle);
        }

        [MethodImpl(Inline)]
        BinaryOp64 BinaryOp(N64 w, in AsmCode src)
        {
            Load(src);
            return Dynop.BinOp(w, src.Id, Handle);
        }

        [MethodImpl(Inline)]
        BinaryOp128 BinaryOp(N128 w, in AsmCode src)
        {
            Load(src);
            return Dynop.BinOp(w, src.Id, Handle);
        }

        [MethodImpl(Inline)]
        BinaryOp256 BinaryOp(N256 w, in AsmCode src)
        {
            Load(src);
            return Dynop.BinOp(w, src.Id, Handle);
        }
    }   
}