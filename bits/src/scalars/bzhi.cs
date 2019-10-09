//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;

    using static System.Runtime.Intrinsics.X86.Bmi1;
    using static System.Runtime.Intrinsics.X86.Bmi1.X64;
    using static System.Runtime.Intrinsics.X86.Bmi2;
    using static System.Runtime.Intrinsics.X86.Bmi2.X64;

    using static zfunc;

    partial class Bits
    {                
        /// <summary>
        /// unsigned int _bzhi_u32 (unsigned int a, unsigned int index) BZHI r32a, reg/m32, r32b
        /// Replicates the source bits to the target and disables the high target bits starting at a specified index.
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static byte bzhi(byte src, uint index)
            =>  (byte)ZeroHighBits((uint)src, index);

        /// <summary>
        /// unsigned int _bzhi_u32 (unsigned int a, unsigned int index) BZHI r32a, reg/m32, r32b
        /// Replicates the source bits to the target and disables the high target bits starting at a specified index.
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static ushort bzhi(ushort src, uint index)
            => (ushort)ZeroHighBits((uint)src, index);

        /// <summary>
        /// unsigned int _bzhi_u32 (unsigned int a, unsigned int index) BZHI r32a, reg/m32, r32b
        /// Replicates the source bits to the target and disables the high target bits starting at a specified index.
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static uint bzhi(uint src, uint index)
            => ZeroHighBits(src, index);

        /// <summary>
        /// unsigned __int64 _bzhi_u64 (unsigned __int64 a, unsigned int index) BZHI r64a,reg/m32, r64b 
        /// Disables the high target bits starting at a specified index.
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="index">The index at which to begin disabling bits</param>
        [MethodImpl(Inline)]
        public static ulong bzhi(ulong src, uint index)
            => ZeroHighBits(src, index);

        /// <summary>
        /// unsigned int _bzhi_u32 (unsigned int a, unsigned int index) BZHI r32a, reg/m32, r32b
        /// Replicates the source bits to the target and disables the high target bits starting at a specified index.
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static ref byte bzhi(ref byte src, uint index)
        {
           src = (byte)ZeroHighBits(src, index);
           return ref src;
        }

        /// <summary>
        /// unsigned int _bzhi_u32 (unsigned int a, unsigned int index) BZHI r32a, reg/m32, r32b
        /// Disables the high target bits starting at a specified index.
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static ref ushort bzhi(ref ushort src, uint index)
        {
           src = (ushort)ZeroHighBits(src, index);
           return ref src;
        }

        /// <summary>
        /// unsigned int _bzhi_u32 (unsigned int a, unsigned int index) BZHI r32a, reg/m32, r32b
        /// Disables the high target bits starting at a specified index.
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static ref uint bzhi(ref uint src, uint index)
        {
           src = ZeroHighBits(src, index);
           return ref src;
        }

        /// <summary>
        /// unsigned __int64 _bzhi_u64 (unsigned __int64 a, unsigned int index) BZHI r64a,reg/m32, r64b 
        /// Disables the high target bits starting at a specified index.
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="index">The index at which to begin disabling bits</param>
        [MethodImpl(Inline)]
        public static ref ulong bzhi(ref ulong src, uint index)
        {
            src = ZeroHighBits(src, index);
            return ref src;
        }

        
    }
}