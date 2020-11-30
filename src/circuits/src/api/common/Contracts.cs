//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static SFx;

    /// <summary>
    /// Represents one (or more) logic gates, which is intended to represent
    /// a physical component that receives one or more bits of input and emits a single bit of output;
    /// i.e., boolean function reification
    /// </summary>
    public interface ILogicGate
    {

    }

    /// <summary>
    /// Characterizes a logic gate that receives 1 bit
    /// </summary>
    public interface IUnaryLogicGate : ILogicGate
    {
        Bit32 Invoke(Bit32 a);
    }

    /// <summary>
    /// Characterizes a logic gate that receives 2 bits
    /// </summary>
    public interface IBinaryLogicGate : ILogicGate
    {
        Bit32 Invoke(Bit32 a, Bit32 b);
    }

    /// <summary>
    /// Characterizes a logic gate that receives 3 bits
    /// </summary>
    public interface ITernaryLogicGate : ILogicGate
    {
        Bit32 Invoke(Bit32 a, Bit32 b, Bit32 c);

    }

    /// <summary>
    /// Characterizes a set of logic gates where each member accepts 1 bit of input
    /// </summary>
    /// <typeparam name="T">A type that defines a finite sequence of bits</typeparam>
    public interface IUnaryGate<T> : IUnaryLogicGate, IUnaryOp<T>
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a set of logic gates where each member accepts 2 bits of input
    /// </summary>
    /// <typeparam name="T">A type that defines a finite sequence of bits</typeparam>
    public interface IBinaryGate<T> : IBinaryLogicGate, IBinaryOp<T>
        where T : unmanaged
    {

    }

    public interface IBinaryGateIn<T> : IBinaryOpIn<T>
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a set of logic gates where each member accepts 3 bits of input
    /// </summary>
    /// <typeparam name="T">A type that defines a finite sequence of bits</typeparam>
    public interface ITernaryGate<T> : ITernaryLogicGate, ITernaryOp<T>
        where T : unmanaged
    {

    }

    public interface IVUnaryGate128<T> : IUnaryGate<Vector128<T>>
        where T : unmanaged
    {

    }

    public interface IVUnaryGate256<T> : IUnaryGate<Vector256<T>>
        where T : unmanaged
    {

    }

    public interface IVUnaryGate512<T> : IUnaryGate<Vector512<T>>
        where T : unmanaged
    {

    }

    public interface IBinaryGate128<T> : IBinaryGate<Vector128<T>>
        where T : unmanaged
    {

    }

    public interface IBinaryGate256<T> : IBinaryGate<Vector256<T>>
        where T : unmanaged
    {

    }

    public interface IBinaryGate512<T> : IBinaryGateIn<Vector512<T>>
        where T : unmanaged
    {

    }

    public interface IVTernaryGate128<T> : ITernaryGate<Vector128<T>>
        where T : unmanaged
    {

    }

    public interface IVTernaryGate256<T> : ITernaryGate<Vector256<T>>
        where T : unmanaged
    {

    }

    public interface IVTernaryGate512<T> : ITernaryGate<Vector512<T>>
        where T : unmanaged
    {

    }
}