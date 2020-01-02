//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;
    using static zfunc;

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
        bit Send(bit a);
    }

    /// <summary>
    /// Characterizes a logic gate that receives 2 bits
    /// </summary>
    public interface IBinaryLogicGate : ILogicGate
    {
        bit Send(bit a, bit b);
    }

    /// <summary>
    /// Characterizes a logic gate that receives 3 bits
    /// </summary>
    public interface ITernaryLogicGate : ILogicGate
    {
        bit Send(bit a, bit b, bit c);
    }

    /// <summary>
    /// Characterizes a sequence of logic gates predicated on a parametric type
    /// </summary>
    public interface ITypedLogicGate<T> : ILogicGate
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a set of logic gates where each member accepts 1 bit of input
    /// </summary>
    /// <typeparam name="T">A type that defines a finite sequence of bits</typeparam>
    public interface IUnaryGate<T> : IUnaryLogicGate, ITypedLogicGate<T>
        where T : unmanaged
    {
        T Send(T a);
    }

    /// <summary>
    /// Characterizes a set of logic gates where each member accepts 2 bits of input 
    /// </summary>
    /// <typeparam name="T">A type that defines a finite sequence of bits</typeparam>
    public interface IBinaryGate<T> : IBinaryLogicGate, ITypedLogicGate<T>
        where T : unmanaged
    {
        T Send(T a, T b);
    }

    /// <summary>
    /// Characterizes a set of logic gates where each member accepts 3 bits of input 
    /// </summary>
    /// <typeparam name="T">A type that defines a finite sequence of bits</typeparam>
    public interface ITernaryGate<T> : ITernaryLogicGate, ITypedLogicGate<T>
        where T : unmanaged
    {
        T Send(T a, T b, T c);

    }

}