//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Security;

    using static zfunc;

    public readonly struct FixedDelegate
    {
        public static FixedDelegate Define(OpIdentity id, IntPtr src, DynamicMethod enclosure, Delegate dynop)        
            => new FixedDelegate(id,src,enclosure,dynop);

        public static implicit operator Delegate(FixedDelegate src)            
            => src.DynamicOp;
            
        FixedDelegate(OpIdentity id, IntPtr src, DynamicMethod enclosure, Delegate dynop)
        {
            this.Id = id;
            this.SourceAddress = src;
            this.Enclosure = enclosure;
            this.DynamicOp = dynop;
        }

        public readonly OpIdentity Id;

        public readonly IntPtr SourceAddress;

        public readonly DynamicMethod Enclosure;

        public readonly Delegate DynamicOp;        
    }    

    [SuppressUnmanagedCodeSecurity]
    public delegate R FixedFunc<R>()
        where R : IFixed;

    [SuppressUnmanagedCodeSecurity]
    public delegate R FixedFunc<X0,R>(X0 x0)
        where R : IFixed
        where X0 : IFixed;

    [SuppressUnmanagedCodeSecurity]
    public delegate R FixedFunc<X0,X1,R>(X0 x0, X1 x1)
        where R : IFixed
        where X1 : IFixed
        where X0 : IFixed;

    [SuppressUnmanagedCodeSecurity]
    public delegate R FixedFunc<X0,X1,X2,R>(X0 x0, X1 x1, X2 x2)
        where R : IFixed
        where X0 : IFixed
        where X1 : IFixed
        where X2 : IFixed;

    [SuppressUnmanagedCodeSecurity]
    public delegate R FixedFunc<X0,X1,X2,X3,R>(X0 x0, X1 x1, X2 x2, X3 x3)
        where R : IFixed
        where X0 : IFixed
        where X1 : IFixed
        where X2 : IFixed
        where X3 : IFixed;

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed8 UnaryOp8(Fixed8 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed16 UnaryOp16(Fixed16 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed32 UnaryOp32(Fixed32 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed64 UnaryOp64(Fixed64 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed128 UnaryOp128(Fixed128 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed256 UnaryOp256(Fixed256 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed8 BinaryOp8(Fixed8 a, Fixed8 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed16 BinaryOp16(Fixed16 a, Fixed16 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed32 BinaryOp32(Fixed32 a, Fixed32 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed64 BinaryOp64(Fixed64 a, Fixed64 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed128 BinaryOp128(Fixed128 a, Fixed128 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed256 BinaryOp256(Fixed256 a, Fixed256 b);
}