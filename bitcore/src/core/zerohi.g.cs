//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;
    using static As;
    using static AsIn;

    partial class gbits
    {
        /// <summary>
        /// Replicates the source bits to the target and disables the high target bits starting at a specified index.
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="index">The index at which to begin disabling target bits</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.UnsignedInts)]
        public static T zerohi<T>(T src, int index)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.zerohi(uint8(src), index));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.zerohi(uint16(src), index));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.zerohi(uint32(src), index));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.zerohi(uint64(src),index));
            else            
                throw unsupported<T>();
        }           
    }
}