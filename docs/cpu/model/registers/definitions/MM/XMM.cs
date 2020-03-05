//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.CpuModel
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    /// <summary>
    /// Represents a 128-bit vector register
    /// </summary>
    /// <remarks>
    /// When invoking a function that accepts XMM arguments, registers
    /// xmm(0), xmm(1), xmm(2), xmm(3), xmm(4) and xmm(5) specify
    /// the first 6 function arguments when applicable. Moreover, the lo 80 bits of
    /// xmm(0) holds a floating-point return value (when in 64-bit mode)
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, Size = ByteCount)]
    public struct XMM : IMMReg, ICpuReg128, IEquatable<XMM>
    {
        ulong x0;

        ulong x1;

        public const int ByteCount = 16;

        public static readonly BitSize BitWidth = 128;    

        /// <summary>
        /// Defines a 1-filled XMM register
        /// </summary>
        public static readonly XMM Ones = FromCells(ulong.MaxValue, ulong.MaxValue);    

        /// <summary>
        /// Defines a 0-filled XMM register
        /// </summary>
        public static readonly XMM Zero = FromCells(0ul, 0ul);


        /// <summary>
        /// Presents a generic cpu vector as a register
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static XMM From<T>(Vector128<T> src)
            where T : unmanaged
                => Unsafe.As<Vector128<T>,XMM>(ref src);

        [MethodImpl(Inline)]
        public static ref readonly BitMap128<T> BitMap<T>()
            where T : unmanaged
                => ref Z0.BitMap.Map128<T>();

        /// <summary>
        /// Creates a register with content from a cell parameter array
        /// </summary>
        /// <param name="cells">The cell content</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static XMM FromCells<T>(params T[] cells)
            where T : unmanaged
        {
            XMM dst = default;
            var len = Math.Min(cells.Length, CellCount<T>());
            for(var i=0; i<len; i++)              
                dst.Cell<T>(i) = cells[i];
            return dst;
        }

        [MethodImpl(Inline)]
        public static XMM From<T>(Span<T> src)
            where T : unmanaged
        {
            var target = default(XMM);
            var count = Math.Min(CellCount<T>(), src.Length);
            ref var head = ref target.First<T>();
            for(var i=0; i< count; i++)
                Unsafe.Add(ref head, i) = src[i];
            return target;
        }



        /// <summary>
        /// Implicitly converts a source vector to a 256-bit memory block
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator XMM(Vector128<sbyte> src)
            => From(src);

        /// <summary>
        /// Implicitly converts a source vector to a 256-bit memory block
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator XMM(Vector128<byte> src)
            => From(src);

        /// <summary>
        /// Implicitly converts a source vector to a 256-bit memory block
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator XMM(Vector128<short> src)
            => From(src);

        /// <summary>
        /// Implicitly converts a source vector to a 256-bit memory block
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator XMM(Vector128<ushort> src)
            => From(src);

        /// <summary>
        /// Implicitly converts a source vector to a 256-bit memory block
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator XMM(Vector128<int> src)
            => From(src);

        /// <summary>
        /// Implicitly converts a source vector to a 256-bit memory block
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator XMM(Vector128<uint> src)
            => From(src);

        /// <summary>
        /// Implicitly converts a source vector to a 256-bit memory block
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator XMM(Vector128<long> src)
            => From(src);

        /// <summary>
        /// Implicitly converts a source vector to a 256-bit memory block
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator XMM(Vector128<ulong> src)
            => From(src);
        
        /// <summary>
        /// Implicitly converts a source vector to a 256-bit memory block
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator XMM(Vector128<float> src)
            => From(src);

        /// <summary>
        /// Implicitly converts a source vector to a 256-bit memory block
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator XMM(Vector128<double> src)
            => From(src);

        [MethodImpl(Inline)]
        public static bool operator ==(XMM lhs, XMM rhs)
            =>lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(XMM lhs, XMM rhs)
            =>!lhs.Equals(rhs);

        /// <summary>
        /// Presents the data in the register as a span
        /// </summary>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline)]
        public Span<T> AsSpan<T>()
            where T : unmanaged
                => MemoryMarshal.Cast<byte,T>(BitView.Over(ref this).Bytes);

        /// <summary>
        /// Computes type-polymorphic cell count
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int CellCount<T>()
            where T : unmanaged 
                => BitMap<T>().CellCount;

        /// <summary>
        /// Computes type-specific cell bitsize
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitSize CellWidth<T>()
            where T : unmanaged 
                => BitMap<T>().CellWidth;

        /// <summary>
        /// Returns a reference to the first cell
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public ref T First<T>()
            where T : unmanaged
                => ref BitView.Over(ref this).Bytes.As<T>()[0];

        [MethodImpl(Inline)]
        public ref T Cell<T>(int index)
            where T : unmanaged
                => ref Unsafe.Add(ref First<T>(), index);

        /// <summary>
        /// Gets the value of an index-identified cell
        /// </summary>
        /// <param name="index">The zero-based cell index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public ref T Cell<T>(uint index)
            where T : unmanaged
                => ref Unsafe.Add(ref First<T>(), (int)index);

        /// <summary>
        /// Specifies the intrinsic volatility of the register
        /// </summary>
        /// <param name="index">The 0-based register index</param>
        /// <remarks>See https://docs.microsoft.com/en-us/cpp/build/x64-software-conventions?view=vs-2019</remarks>
        [MethodImpl(Inline)]
        public VolatilityKind Volatility(int index)
            => index <= 5 ? CpuModel.VolatilityKind.Volatile : CpuModel.VolatilityKind.NonVolatile;

        public bit this[uint bitpos]
        {
            [MethodImpl(Inline)]
            get => GetBit(bitpos);                                    
            [MethodImpl(Inline)]
            set => SetBit(bitpos, value);
        }        

        /// <summary>
        /// Gets the value of position-identified bit where 0 <= pos < 128
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl]
        public bit GetBit(uint pos)
        {
            ref readonly var index = ref BitMap<ulong>()[pos];
            ref var cell  = ref Cell<ulong>(index.CellIndex);
            return bit.test(cell, index.CellOffset);
        }

        /// <summary>
        /// Sets a position-identified bit where 0 <= pos < 128
        /// </summary>
        /// <param name="pos">The bit position</param>
        /// <param name="value">The bit value</param>
        [MethodImpl]
        public void SetBit(uint pos, bit value)
        {
            ref readonly var index = ref BitMap<ulong>()[pos];
            ref var cell  = ref Cell<ulong>(index.CellIndex);
            cell = bit.set(cell, index.CellOffset, value);
        }
    
        /// <summary>
        /// Evaluates registers for content equality
        /// </summary>
        /// <param name="rhs">The other registers</param>
        [MethodImpl(Inline)]
        public bool Equals(XMM rhs)
            => x0 == rhs.x0 && x1 == rhs.x1;

        public string Format<T>()
            where T : unmanaged
                =>  AsSpan<T>().FormatCellBlocks();

        public override string ToString()
            => Format<ulong>();

        public override bool Equals(object obj)
            => obj is XMM x ? Equals(x) : false;
        
        public override int GetHashCode()
            => x0.GetHashCode() + x1.GetHashCode();

    }
}    
