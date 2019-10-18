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
    { 
        /// <summary>
        /// Computes the bitwise and from the supplied values
        /// </summary>
        /// <param name="lhs">The left value</param>
        /// <param name="rhs">The right value</param>
        /// <returns></returns>
        T and(T lhs, T rhs);

        /// <summary>
        /// Computes the bitwise or from the supplied values
        /// </summary>
        /// <param name="lhs">The left value</param>
        /// <param name="rhs">The right value</param>
        T or(T lhs, T rhs);
 
        /// <summary>
        /// Computes the bitwise exlusive or from the supplied values
        /// </summary>
        /// <param name="lhs">The left value</param>
        /// <param name="rhs">The right value</param>
        T xor(T lhs, T rhs);

        T ShiftL(T lhs, int rhs);

        T ShiftR(T lhs, int rhs);


        /// <summary>
        /// Calculates the bitwise two's-complement of the input
        /// </summary>
        /// <param name="x">The source value</param>
        T flip(T x); 

        /// <summary>
        /// Computes the bitwise and
        /// </summary>
        /// <param name="rhs">The right value</param>
        T And(T rhs);
        
        /// <summary>
        /// Computes the bitwise or
        /// </summary>
        /// <param name="rhs">The right  value</param>
        T Or(T rhs);

        /// <summary>
        /// Computes the bitwise exlusive or
        /// </summary>
        /// <param name="rhs">The right  value</param>
        T XOr(T rhs);

        /// <summary>
        /// Calculates the bitwise two's-complement
        /// </summary>
        T Flip();

        /// <summary>
        /// Rotates bits rightwards, from MSB -> LSB
        /// </summary>
        /// <param name="lhs">The value to rotate</param>
        /// <param name="rhs">The magnitude of the rotation</param>
        T RotL(T lhs, int rhs);
        
        /// <summary>
        /// Rotates bits leftwards, from LSB -> MSB
        /// </summary>
        /// <param name="lhs">The value to rotate</param>
        /// <param name="rhs">The magnitude of the rotation</param>
        T RotR(T lhs, int rhs);


    }

    public interface IBitwise<S>
        where S : IBitwise<S>, new()
    {
        /// <summary>
        /// Determines whether a bit at a specified position is on
        /// </summary>
        bool TestBit(int pos);

        /// <summary>
        /// Interprets the source as an array of bytes
        /// </summary>
        /// <param name="src">The source value</param>
        byte[] Bytes {get;}

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