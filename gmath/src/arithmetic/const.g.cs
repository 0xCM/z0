//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Root;    
    
    partial class gmath
    {
        /// <summary>
        /// Defines an alternating bit pattern 01 01...01
        /// </summary>
        /// <typeparam name="T">The primal unsigned type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static T altodd<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(U8_AltOdd);
            else if(typeof(T) == typeof(ushort))
                return generic<T>(U16_AltOdd);
            else if(typeof(T) == typeof(uint))
                return generic<T>(U32_AltOdd);
            else if(typeof(T) == typeof(ulong))
                return generic<T>(U64_AltOdd);
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// Defines an alternating bit pattern 10 10...10
        /// </summary>
        /// <typeparam name="T">The primal unsigned type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static T alteven<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(U8_AltEven);
            else if(typeof(T) == typeof(ushort))
                return generic<T>(U16_AltEven);
            else if(typeof(T) == typeof(uint))
                return generic<T>(U32_AltEven);
            else if(typeof(T) == typeof(ulong))
                return generic<T>(U64_AltEven);
            else 
                throw unsupported<T>();
        }

        const byte U8_AltEven = 0xAA;

        const byte U8_AltOdd = 0x55;

        const ushort U16_AltEven = 0xAAAA;

        const ushort U16_AltOdd = 0x5555;

        const uint U32_AltEven = 0xAAAAAAAA;

        const uint U32_AltOdd = 0x55555555;

        const ulong U64_AltEven = 0xAAAAAAAAAAAAAAAA;

        const ulong U64_AltOdd = 0x5555555555555555;
    }
}