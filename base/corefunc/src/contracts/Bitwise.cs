//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Characterizes bitwise operations over an operand
    /// </summary>
    public interface IBitwiseOps<T>  
        where T : unmanaged      
    { 
        /// <summary>
        /// Computes the bitwise AND
        /// </summary>
        /// <param name="a">The left value</param>
        /// <param name="b">The right value</param>
        T And(T a, T b);

        /// <summary>
        /// Computes the bitwise OR
        /// </summary>
        /// <param name="a">The left value</param>
        /// <param name="b">The right value</param>
        T Or(T a, T b);
 
        /// <summary>
        /// Computes the bitwise XOR
        /// </summary>
        /// <param name="a">The left value</param>
        /// <param name="b">The right value</param>
        T XOr(T a, T b);

        /// <summary>
        /// Computes the bitwise complement
        /// </summary>
        /// <param name="a">The operand</param>
        T Not(T a);

    }

    public interface IShiftOps<T>
    {
        T Sll(T a, int offset);

        T Srl(T a, int offset);

        /// <summary>
        /// Rotates bits rightwards, from MSB -> LSB
        /// </summary>
        /// <param name="lhs">The value to rotate</param>
        /// <param name="offset">The magnitude of the rotation</param>
        T RotL(T lhs, int offset);
        
        /// <summary>
        /// Rotates bits leftwards, from LSB -> MSB
        /// </summary>
        /// <param name="lhs">The value to rotate</param>
        /// <param name="rotl">The magnitude of the rotation</param>
        T RotR(T lhs, int rotl);

    }

    public interface IShiftable<S>
        where S : IShiftable<S>, new()
    {
        S ShiftL(int rhs);

        S ShiftR(int rhs);

        /// <summary>
        /// Rotates bits rightwards, from MSB -> LSB
        /// </summary>
        /// <param name="rhs">The magnitude of the rotation</param>
        S RotL(int rhs);
        
        /// <summary>
        /// Rotates bits leftwards, from LSB -> MSB
        /// </summary>
        /// <param name="rhs">The magnitude of the rotation</param>
        S RotR(int rhs);
    }

}