//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
    using static AsIn;
    
    partial class gmath
    {
        [MethodImpl(Inline)]
        public static T zero<T>()
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static T one<T>()
            where T : unmanaged
                => convert<T>(1);

        [MethodImpl(Inline)]
        public static T minval<T>()
            where T : unmanaged
                => PrimalInfo.minval<T>();

        [MethodImpl(Inline)]
        public static T maxval<T>()
            where T : unmanaged
                => PrimalInfo.maxval<T>();

        /// <summary>
        /// Defines an alternating bit pattern 0101...01 where the first bit is enabled
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
    }
}