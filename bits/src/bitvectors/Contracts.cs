//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;    
    using static nfunc;

    /// <summary>
    /// Characterizes a bitvector
    /// </summary>
    public interface IBitVector
    {
        /// <summary>
        /// The maximum number of bits that can be represented by the vector
        /// </summary>
        BitSize Capacity {get;}

        /// <summary>
        /// The actual number of bits represented by the vector
        /// </summary>
        BitSize Length {get;}

        /// <summary>
        /// Returns true if all bits are disabled, false otherwise
        /// </summary>
        bool Empty {get;}

        /// <summary>
        /// Returns true if at least one bit is enabled, false otherwise
        /// </summary>
        bool Nonempty {get;}

        /// <summary>
        /// Counts vector's enabled bits
        /// </summary>
        BitSize Pop();

        /// <summary>
        /// Counts the vector's leading zero bits
        /// </summary>
        /// <param name="src">The bit source</param>
        BitSize Nlz();

        /// <summary>
        /// Counts the vector's trailing zero bits
        /// </summary>
        /// <param name="src">The bit source</param>
        BitSize Ntz();

        /// <summary>
        /// Converts the vector to a bitstring
        /// </summary>
        BitString ToBitString();


        /// <summary>
        /// Enables a bit if it is disabled
        /// </summary>
        /// <param name="pos">The position of the bit to enable</param>
        void Enable(BitPos pos);     
        
        /// <summary>
        /// Disables a bit if it is enabled
        /// </summary>
        /// <param name="pos">The bit position</param>
        void Disable(BitPos pos);

        /// <summary>
        /// Reads a bit value
        /// </summary>
        /// <param name="pos">The bit position</param>
        Bit Get(BitPos pos);

        bit GetBit(BitPos pos);

        void SetBit(BitPos pos, bit value);

        /// <summary>
        /// Sets a bit value
        /// </summary>
        /// <param name="pos">The position of the bit to set</param>
        /// <param name="value">The bit value</param>
        void Set(BitPos pos, Bit value);

        /// <summary>
        /// Determines whether a bit is enabled
        /// </summary>
        /// <param name="pos">The bit position</param>
        bool Test(BitPos pos);        

        /// <summary>
        /// Counts the number of bits set up to and including the specified position
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit for which rank will be calculated</param>
        uint Rank(BitPos pos);

        /// <summary>
        /// Queries/Manipulates individual vector bits
        /// </summary>
        Bit this[BitPos pos] {get; set;}            

        /// <summary>
        /// Vector content represented as a bytespan
        /// </summary>
        Span<byte> Bytes {get;}

        /// <summary>
        /// Formats the bitvector as a bitstring
        /// </summary>
        /// <param name="tlz">True if leadzing zeros should be trimmed, false otherwise</param>
        /// <param name="specifier">True if the prefix specifier '0b' should be prepended</param>
        /// <param name="blockWidth">The width of the blocks, if any</param>
        string Format(bool tlz, bool specifier, int? blockWidth);
 
        /// <summary>
        /// Retrieves an index-identied segment (1 byte)
        /// </summary>
        /// <param name="index">The segment index</param>
        ref byte Byte(int index);

    }


    public interface IBitVector<V> : IBitVector
        where V : unmanaged, IBitVector
    {
        /// <summary>
        /// Selects a contiguous range of bits
        /// </summary>
        /// <param name="first">The first bit position</param>
        /// <param name="last">The last bit position</param>
        V Between(BitPos first, BitPos last);

        /// <summary>
        /// Selects a contiguous range of bits
        /// </summary>
        V this[Range range] {get;}            

        /// <summary>
        /// Selects a contiguous range of bits
        /// </summary>
        /// <param name="first">The position of the first bit</param>
        /// <param name="last">The position of the last bit</param>
        V this[BitPos first, BitPos last] {get;}

        /// <summary>
        /// Constructs a bitvector formed from the n lest significant bits of the current vector
        /// </summary>
        /// <param name="n">The count of least significant bits</param>
        V Lsb(int n);
    
        /// <summary>
        /// Constructs a bitvector formed from the n most significant bits of the current vector
        /// </summary>
        /// <param name="n">The count of most significant bits</param>
        V Msb(int n);

        /// <summary>
        /// Returns a copy of the vector
        /// </summary>
        V Replicate();

        /// <summary>
        /// Replicates a vector to which a permutation is then applied
        /// </summary>
        /// <param name="p">The permutation</param>
        V Replicate(Perm p);

        /// <summary>
        /// Computes in-place the bitwise AND of the source vector and another and returns the result to the caller
        /// </summary>
        /// <param name="y">The other vector</param>
        V And(V y);

        /// <summary>
        /// Computes in-place the bitwise OR of the source vector and another and returns the result to the caller
        /// 
        /// </summary>
        /// <param name="y">The other vector</param>
        V Or(V y);

        /// <summary>
        /// Computes in-place the bitwise XOR of the source vector and another and returns the result to the caller
        /// 
        /// </summary>
        /// <param name="y">The other vector</param>
        V XOr(V y);

        /// <summary>
        /// Computes in-place the bitwise XNOR of the source vector and another and returns the result to the caller
        /// </summary>
        /// <param name="y">The other vector</param>
        V XNor(V y);

        /// <summary>
        /// Computes in-place the bitwise NAND of the source vector and another and returns the result to the caller
        /// </summary>
        /// <param name="y">The other vector</param>
        V Nand(V y);

        /// <summary>
        /// Computes in-place the bitwise NOR of the source vector and another and returns the result to the caller
        /// </summary>
        /// <param name="y">The other vector</param>
        V Nor(V y);

        /// <summary>
        /// Computes in-place the bitwise AND of the source vector and the complement of another and returns the result to the caller
        /// </summary>
        /// <param name="y">The other vector</param>
        V AndNot(V y);

        /// <summary>
        /// Computes in-place the bitwise ternary select between the source vector and the operands and returns the result to the caller
        /// </summary>
        /// <param name="y">The other vector</param>
        V Select(V y, V z);

        /// <summary>
        /// Computes the source vector's bitwise complement in-place and returns the result to the caller
        /// </summary>
        V Not();

        /// <summary>
        /// Computes the source vector's two's complement in-place and returns the result to the caller
        /// </summary>
        V Negate();

        /// <summary>
        /// Increments the source vector in-place and returns the result to the caller
        /// </summary>
        V Inc();

        /// <summary>
        /// Decrements the source vector in-place and returns the result to the caller
        /// </summary>
        V Dec();

        /// <summary>
        /// Shifts the bits in the vector leftwards
        /// </summary>
        /// <param name="offset">The number of bits to shift</param>
        V Sll(int offset);

        /// <summary>
        /// Shifts the bits in the vector rightwards
        /// </summary>
        /// <param name="offset">The number of bits to shift</param>
        V Srl(int offset);
        
        /// <summary>
        /// Rotates vector bits rightwards by a specified offset
        /// </summary>
        /// <param name="offset">The magnitude of the rotation</param>
        V Rotr(int offset);

        /// <summary>
        /// Rotates vector bits leftwards by a specified offset
        /// </summary>
        /// <param name="offset">The magnitude of the rotation</param>
        V Rotl(int offset);

        /// <summary>
        /// Rearranges vector in-place as specified by a permutation and returns the result to the caller
        /// </summary>
        /// <param name="spec">The permutation</param>
        V Permute(Perm p);

        /// <summary>
        /// Reverses the vector's bits in-place
        /// </summary>
        V Reverse();

        /// <summary>
        /// Populates a target vector with specified source bits
        /// </summary>
        /// <param name="spec">Identifies the source bits of interest</param>
        /// <param name="dst">Receives the identified bits</param>
        V Gather(V mask);

        /// <summary>
        /// Computes the scalar product of the source vector and another
        /// </summary>
        /// <param name="rhs">The right operand</param>
        Bit Dot(V rhs);

        T ToScalar<T>()
            where T : unmanaged;

    }

    public interface IPrimalBitVector<V> : IBitVector<V>, IEquatable<V>
        where V : unmanaged, IBitVector

    {


    }

    /// <summary>
    /// Characterizes a bitvector defined over a primal scalar, i.e. one of {BitVector8, BitVector16, BitVector32, BitVector64}
    /// </summary>
    /// <typeparam name="V">The primal vector type</typeparam>
    /// <typeparam name="T">The primal scalar type</typeparam>
    public interface IPrimalBitVector<V,T> : IPrimalBitVector<V>
        where V : unmanaged, IPrimalBitVector<V,T>
        where T : unmanaged        
    {
        /// <summary>
        /// The scalar value that defines the vector
        /// </summary>
        T Scalar {get;}

    }


}