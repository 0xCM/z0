//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Security;

    using static zfunc;

    [SuppressUnmanagedCodeSecurity]
    public interface Imm8Resolver : IFunc
    {
            
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryImm8Resolver<T> : Imm8Resolver
        where T :struct
    {
        DynamicDelegate<UnaryOp<T>>  @delegate(byte imm8); 

        
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryImm8Resolver<T> : Imm8Resolver
        where T :struct
    {
        DynamicDelegate<BinaryOp<T>>  @delegate(byte imm8);  

        

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryImm8Resolver128<T> : IUnaryImm8Resolver<Vector128<T>>
        where T : unmanaged
    {


    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryImm8Resolver256<T> : IUnaryImm8Resolver<Vector256<T>>
        where T : unmanaged
    {


    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVBinaryImm8Resolver128<T> : IBinaryImm8Resolver<Vector128<T>>
        where T : unmanaged
    {
        

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVBinaryImm8Resolver256<T> : IBinaryImm8Resolver<Vector256<T>>
        where T : unmanaged
    {
        

    }

}