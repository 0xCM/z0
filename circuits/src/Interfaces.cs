//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
    /// Represents one (or more) logic gates
    /// A logic gate is a physical component that receives one 
    /// or more bits of input and emits a single bit of output; in other words,
    /// it reifies a boolean function
    /// </summary>
    public interface ILogicGate
    {

    }

    /// <summary>
    /// Characterizes a logic gate that receives 1 bit
    /// </summary>
    public interface IUnaryBitGate : ILogicGate
    {
        Bit Send(Bit a);
    }

    /// <summary>
    /// Characterizes a logic gate that receives 2 bits
    /// </summary>
    public interface IBinaryBitGate : ILogicGate
    {
        Bit Send(Bit a, Bit b);
    }

    /// <summary>
    /// Characterizes a logic gate that receives 3 bits
    /// </summary>
    public interface ITernaryBitGate : ILogicGate
    {
        Bit Send(Bit a, Bit b, Bit c);
    }


    /// <summary>
    /// Characterizes a set of logic gates where each member accepts 1 bit of input
    /// </summary>
    /// <typeparam name="T">A type that defines a finite sequence of bits</typeparam>
    public interface IUnaryGate<T> : IUnaryBitGate
        where T : unmanaged
    {
        T Send(T a);
    }

    /// <summary>
    /// Characterizes a set of logic gates where each member accepts 2 bits of input 
    /// </summary>
    /// <typeparam name="T">A type that defines a finite sequence of bits</typeparam>
    public interface IBinaryGate<T> : IBinaryBitGate
        where T : unmanaged
    {
        T Send(T a, T b);
    }

    /// <summary>
    /// Characterizes a set of logic gates where each member accepts 3 bits of input 
    /// </summary>
    /// <typeparam name="T">A type that defines a finite sequence of bits</typeparam>
    public interface ITernaryGate<T> : ITernaryBitGate
        where T : unmanaged
    {
        T Send(T a, T b, T c);

    }


    public interface ICircuit<A, out B>
    {
        B Send(A a);
    }
    
    public interface ICircuit<A, B, out C>
    {
        C Send(A a, B b);
    }



}