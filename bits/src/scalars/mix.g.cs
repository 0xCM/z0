//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;
    using static As;
    using static AsIn;

    partial class gbits
    {

        /// <summary>
        /// Selects/intersperses even bits from the source operands
        /// </summary>
        /// <param name="parity">The parity selector</param>
        /// <param name="x">The left operand</param>
        /// <param name="y">The riight operand</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T mix<T>(N0 parity, T x, T y)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.mix(parity,uint8(x), uint8(y)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.mix(parity,uint16(x), uint16(y)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.mix(parity,uint32(x), uint32(y)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.mix(parity,uint64(x), uint64(y)));
            else            
                throw unsupported<T>();
        }

        /// <summary>
        /// Selects/intersperses odd bits from the source operands
        /// </summary>
        /// <param name="parity">The parity selector</param>
        /// <param name="x">The left operand</param>
        /// <param name="y">The riight operand</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T mix<T>(N1 parity, T x, T y)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.mix(parity,uint8(x), uint8(y)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.mix(parity,uint16(x), uint16(y)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.mix(parity,uint32(x), uint32(y)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.mix(parity,uint64(x), uint64(y)));
            else            
                throw unsupported<T>();
        }

    }

}