//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;


    /// <summary>
    /// Encapsulates register or memory data and values of this type serve 
    /// as an operand for instructs that accept xmm/xem[128]
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = ByteCount)]
    public unsafe struct XMEM  
    {
        public const int ByteCount = 16;

        [FieldOffset(0)]
        fixed byte mem[ByteCount];

        [FieldOffset(0)]
        Vector128<byte> vxmm;

        [FieldOffset(0)]
        XMM xmm;

        [MethodImpl(Inline)]
        XMEM(XMM xmm)
            : this()
        {
            this.xmm = xmm;
        }

        [MethodImpl(Inline)]
        public static XMEM From<T>(Vector128<T> src)
            where T : unmanaged
                => Unsafe.As<Vector128<T>,XMEM>(ref src);

        /// <summary>
        /// Implicitly converts ymem source value to a ymm register
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator XMM(in XMEM src)
            => src.xmm;

        /// Returns a reference to the first memory cell of the encapsulated data
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public ref T First<T>()
            where T : unmanaged
                => ref As.generic<T>(ref mem[0]);
            
    }
}

