//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static zfunc;
    

    public static class GpRegOps
    {
        public static string Format<N,R>(this ref R register)
            where N : unmanaged, ITypeNat, INatPow2
            where R : struct, ICpuReg<N>
        {
            ref var src = ref Unsafe.As<R,byte>(ref register);
            Span<byte> dst = stackalloc byte[register.ByteSize];
            Unsafe.CopyBlock(ref head(dst), ref src, register.ByteSize);
            return dst.FormatHexBytes();
        }

        /// <summary>
        /// Determines the bank address of an identified register
        /// </summary>
        /// <param name="src">The soruce register</param>
        [MethodImpl(Inline)]
        public static BankAddress Address(this GpRegId src)
            => new BankAddress
            {
                Offset = (uint)((ulong)src >> 32),
                Size = (uint)src            
            };
        
        /// <summary>
        /// Retrieves a reference to the first byte of a register bank
        /// </summary>
        /// <param name="bank">The source bank</param>
        [MethodImpl(Inline)]
        public static ref byte Head(this ref GpRegBank bank)
            => ref bank.al.content;

        [MethodImpl(Inline)]
        public static ref byte Head<T>(this ref T src)
            where T : unmanaged
                => ref Unsafe.As<T, byte>(ref mutable(in src));

        /// <summary>
        /// Retrieves a memory reference determined by a bank address
        /// </summary>
        /// <param name="bank">The source bank</param>
        /// <param name="bank">The bank-relative address</param>
        [MethodImpl(Inline)]
        public static ref byte Ref(this ref GpRegBank bank, BankAddress address)
            => ref Unsafe.Add(ref bank.Head(), (int)address.Offset);

        [MethodImpl(Inline)]
        public static void CopyTo(this ref byte src, ref byte dst, ByteSize count)
            => Unsafe.CopyBlock(ref dst, ref src, count);
    }
}