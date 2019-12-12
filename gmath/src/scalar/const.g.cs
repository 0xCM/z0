//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
    using static AsIn;
    
    partial class gmath
    {
        /// <summary>
        /// Returns the additive identity for a primal type
        /// </summary>
        /// <typeparam name="T">The type</typeparam>
        [MethodImpl(Inline)]
        public static T zero<T>()
            where T : unmanaged
                => default;

        /// <summary>
        /// Returns the multiplicative identity for a primal type
        /// </summary>
        /// <typeparam name="T">The type</typeparam>
        [MethodImpl(Inline)]
        public static T one<T>()
            where T : unmanaged
                => zfunc.one<T>();

        /// <summary>
        /// Returns the minimum value that can be represented by a primal type
        /// </summary>
        /// <typeparam name="T">The type</typeparam>
        [MethodImpl(Inline)]
        public static T minval<T>()
            where T : unmanaged
                => zfunc.minval<T>();

        /// <summary>
        /// Returns the maximum value that can be represented by a primal type
        /// </summary>
        /// <typeparam name="T">The type</typeparam>
        [MethodImpl(Inline)]
        public static T maxval<T>()
            where T : unmanaged
                => zfunc.maxval<T>();

        /// <summary>
        /// Defines an alternating bit pattern 01 01...01
        /// </summary>
        /// <typeparam name="T">The primal unsigned type</typeparam>
        [MethodImpl(Inline)]
        public static T altodd<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Constants.U8_AltOdd);
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Constants.U16_AltOdd);
            else if(typeof(T) == typeof(uint))
                return generic<T>(Constants.U32_AltOdd);
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Constants.U64_AltOdd);
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// Defines an alternating bit pattern 10 10...10
        /// </summary>
        /// <typeparam name="T">The primal unsigned type</typeparam>
        [MethodImpl(Inline)]
        public static T alteven<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Constants.U8_AltEven);
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Constants.U16_AltEven);
            else if(typeof(T) == typeof(uint))
                return generic<T>(Constants.U32_AltEven);
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Constants.U64_AltEven);
            else 
                throw unsupported<T>();
        }
    }
}