//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.InteropServices;


    partial struct ClrDataModel
    {
        
        /// <summary>
        /// Represents an array in the target process.
        /// </summary>
        public struct ClrArray : IEquatable<ClrArray>, IEquatable<ClrObject>
        {
            /// <summary>
            /// Gets the address of the object.
            /// </summary>
            public ulong Address { get; }

            /// <summary>
            /// Gets the type of the object.
            /// </summary>
            public ClrType Type { get; }

            private int _length;

            /// <summary>
            /// Gets the count of elements in this array.
            /// </summary>
            public int Length
            {
                get
                {
                    if (_length == -1)
                    {
                        _length = Type.ClrObjectHelpers.DataReader.Read<int>(Address + (ulong)IntPtr.Size);
                    }

                    return _length;
                }
            }

            public int Rank
            {
                get
                {
                    int rank = MultiDimensionalRank;
                    return rank != 0 ? rank : 1;
                }
            }

            private bool IsMultiDimensional 
                => Type.StaticSize > (uint)(3 * IntPtr.Size);

            private int MultiDimensionalRank 
                => (int)((Type.StaticSize - (uint)(3 * IntPtr.Size)) / (2 * sizeof(int)));

            public ClrArray(ulong address, ClrType type)
            {
                Address = address;
                Type = type;
                // default uninitialized value for size. Will be lazy loaded.
                _length = -1;
            }

            /// <summary>
            /// Gets <paramref name="count"/> element values from the array.
            /// </summary>
            /// <typeparam name="T"></typeparam>
            /// <param name="count"></param>
            /// <returns></returns>
            public T[] GetValues<T>(int count) where T : unmanaged
            {
                if ((uint)count > Length)
                {
                    throw new ArgumentOutOfRangeException(nameof(count));
                }

                return Type.GetArrayElementValues<T>(Address, count);
            }

            /// <summary>
            /// Determines whether this instance and another specific <see cref="ClrArray"/> have the same value.
            /// <para>Instances are considered equal when they have the same <see cref="Address"/>.</para>
            /// </summary>
            /// <param name="obj">The <see cref="ClrArray"/> to compare to this instance.</param>
            /// <returns><see langword="true"/> if the <see cref="Address"/> of the parameter is the same as <see cref="Address"/> in this instance; <see langword="false"/> otherwise.</returns>
            public override bool Equals(object obj) => obj switch
            {
                null => false,
                ulong address => Address == address,
                ClrArray clrArray => Address == clrArray.Address,
                ClrObject clrObject => Address == clrObject.Address,
                _ => false
            };

            /// <summary>
            /// Determines whether this instance and another specific <see cref="ClrArray"/> have the same value.
            /// <para>Instances are considered equal when they have the same <see cref="Address"/>.</para>
            /// </summary>
            /// <param name="other">The <see cref="ClrArray"/> to compare to this instance.</param>
            /// <returns><see langword="true"/> if the <see cref="Address"/> of the parameter is the same as <see cref="Address"/> in this instance; <see langword="false"/> otherwise.</returns>
            public bool Equals(ClrArray other) => Address == other.Address;

            /// <summary>
            /// Determines whether this instance and a specified object.
            /// </summary>
            /// <param name="other">The <see cref="ClrObject"/> to compare to this instance.</param>
            /// <returns>
            /// <see langword="true"/> if <paramref name="other"/> is <see cref="ClrObject"/>, and its <see cref="Address"/> is the same as <see cref="Address"/> in this instance; <see langword="false"/>
            /// otherwise.
            /// </returns>
            public bool Equals(ClrObject other) => Address == other.Address;

            /// <summary>
            /// Returns the hash code for this <see cref="ClrArray"/>.
            /// </summary>
            /// <returns>An <see cref="int"/> hash code for this instance.</returns>
            public override int GetHashCode() => Address.GetHashCode();

            public int GetLength(int dimension)
            {
                int rank = MultiDimensionalRank;
                if (rank == 0 && dimension == 0)
                    return Length;

                if ((uint)dimension >= rank)
                    throw new ArgumentOutOfRangeException(nameof(dimension));

                return GetMultiDimensionalBound(dimension);
            }

            public int GetLowerBound(int dimension)
            {
                int rank = MultiDimensionalRank;
                if (rank == 0 && dimension == 0)
                    return 0;

                if ((uint)dimension >= rank)
                    throw new ArgumentOutOfRangeException(nameof(dimension));

                return GetMultiDimensionalBound(rank + dimension);
            }

            public int GetUpperBound(int dimension)
            {
                int rank = MultiDimensionalRank;
                if (rank == 0 && dimension == 0)
                    return Length - 1;

                if ((uint)dimension >= rank)
                    throw new ArgumentOutOfRangeException(nameof(dimension));

                int length = GetMultiDimensionalBound(dimension);
                int lowerBound = GetMultiDimensionalBound(rank + dimension);
                return length + lowerBound - 1;
            }

            public unsafe T GetValue<T>(int index) where T : unmanaged
            {
                if (Rank != 1)
                    throw new ArgumentException("Array was not a one-dimensional array.");

                int valueOffset = index;
                int dataByteOffset = 2 * IntPtr.Size;

                if (IsMultiDimensional)
                {
                    valueOffset -= GetMultiDimensionalBound(1);
                    if ((uint)valueOffset >= GetMultiDimensionalBound(0))
                        throw new ArgumentOutOfRangeException(nameof(index));

                    dataByteOffset += 2 * sizeof(int);
                }
                else
                {
                    if ((uint)valueOffset >= Length)
                        throw new ArgumentOutOfRangeException(nameof(index));
                }

                int elementSize = Type.ComponentSize;
                if (sizeof(T) != elementSize)
                    throw new ArgumentException("Array element was not of the expected size.");

                int valueByteOffset = dataByteOffset + valueOffset * elementSize;
                return Type.ClrObjectHelpers.DataReader.Read<T>(Address + (ulong)valueByteOffset);
            }

            public unsafe T GetValue<T>(params int[] indices) where T : unmanaged
            {
                if (indices is null)
                    throw new ArgumentNullException(nameof(indices));

                int rank = Rank;
                if (rank != indices.Length)
                    throw new ArgumentException("Indices length does not match the array rank.");

                int valueOffset = 0;
                int dataByteOffset = 2 * IntPtr.Size;

                if (rank == 1)
                {
                    if (IsMultiDimensional)
                    {
                        valueOffset = indices[0] - GetMultiDimensionalBound(1);
                        if ((uint)valueOffset >= GetMultiDimensionalBound(0))
                            throw new ArgumentOutOfRangeException(nameof(indices));

                        dataByteOffset += 2 * sizeof(int);
                    }
                    else
                    {
                        valueOffset = indices[0];
                        if ((uint)valueOffset >= Length)
                            throw new ArgumentOutOfRangeException(nameof(indices));
                    }
                }
                else
                {
                    for (int dimension = 0; dimension < rank; dimension++)
                    {
                        int currentValueOffset = indices[dimension] - GetMultiDimensionalBound(rank + dimension);
                        if ((uint)currentValueOffset >= GetMultiDimensionalBound(dimension))
                            throw new ArgumentOutOfRangeException(nameof(indices));

                        valueOffset *= GetMultiDimensionalBound(dimension);
                        valueOffset += currentValueOffset;
                    }

                    dataByteOffset += 2 * sizeof(int) * rank;
                }

                int elementSize = Type.ComponentSize;
                if (sizeof(T) != elementSize)
                    throw new ArgumentException("Array element was not of the expected size.");

                int valueByteOffset = dataByteOffset + valueOffset * elementSize;
                return Type.ClrObjectHelpers.DataReader.Read<T>(Address + (ulong)valueByteOffset);
            }

            public ClrObject GetObjectValue(int index)
            {
                if (!Type.IsObjectReference)
                    throw new InvalidOperationException($"{Type} does not contain object references.");

                ulong address = GetValue<UIntPtr>(index).ToUInt64();
                return Type.Heap.GetObject(address);
            }

            public ClrObject GetObjectValue(params int[] indices)
            {
                if (!Type.IsObjectReference)
                    throw new InvalidOperationException($"{Type} does not contain object references.");

                ulong address = GetValue<UIntPtr>(indices).ToUInt64();
                return Type.Heap.GetObject(address);
            }

            // |<-------------------------- Type.StaticSize -------------------------->|
            // |                                                                       |
            // [    nint    ||       nint       ||  nint  || int[rank] |   int[rank]   ||          ]
            // [ sync block || Type.MethodTable || Length || GetLength | GetLowerBound || elements ]
            //                 ^
            //                 | Address
            private int GetMultiDimensionalBound(int offset) 
                => Type.ClrObjectHelpers.DataReader.Read<int>(Address + (ulong)(2 * IntPtr.Size) + (ulong)(offset * sizeof(int)));

            /// <summary>
            /// Determines whether two specified <see cref="ClrArray"/> have the same value.
            /// </summary>
            /// <param name="left">First <see cref="ClrArray"/> to compare.</param>
            /// <param name="right">Second <see cref="ClrArray"/> to compare.</param>
            /// <returns><see langword="true"/> if <paramref name="left"/> <see cref="Equals(ClrArray)"/> <paramref name="right"/>; <see langword="false"/> otherwise.</returns>
            public static bool operator ==(ClrArray left, ClrArray right) 
                => left.Equals(right);

            /// <summary>
            /// Determines whether two specified <see cref="ClrArray"/> have different values.
            /// </summary>
            /// <param name="left">First <see cref="ClrArray"/> to compare.</param>
            /// <param name="right">Second <see cref="ClrArray"/> to compare.</param>
            /// <returns><see langword="true"/> if the value of <paramref name="left"/> is different from the value of <paramref name="right"/>; <see langword="false"/> otherwise.</returns>
            public static bool operator !=(ClrArray left, ClrArray right) 
                => !(left == right);
        }        
    }
}