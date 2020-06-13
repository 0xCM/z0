//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
 
    using static Seed;

    partial class AsciCodes
    {
        /// <summary>
        /// Populates an asci target with a specified number of source characters
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="count">The number of characters to encode</param>
        /// <param name="dst">The receiver</param>
        [MethodImpl(Inline), Op]
        public static ref readonly asci2 encode(in char src, Hex1 count, out asci2 dst)        
        {
            dst = asci2.Null;
            ref var codes = ref Unsafe.As<asci2,AsciCharCode>(ref dst);
            AsciCodes.codes(src, (byte)count, ref codes);
            return ref dst;
        }

        /// <summary>
        /// Populates an asci target with a specified number of source characters
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="count">The number of characters to encode</param>
        /// <param name="dst">The receiver</param>
        [MethodImpl(Inline), Op]
        public static ref readonly asci4 encode(in char src, Hex2 count, out asci4 dst)        
        {
            dst = asci4.Null;
            ref var codes = ref Unsafe.As<asci4,AsciCharCode>(ref dst);
            AsciCodes.codes(src, (byte)count, ref codes);
            return ref dst;
        }

        /// <summary>
        /// Populates an asci target with a specified number of source characters
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="count">The number of characters to encode</param>
        /// <param name="dst">The receiver</param>
        [MethodImpl(Inline), Op]
        public static ref readonly asci8 encode(in char src, Hex3 count, out asci8 dst)        
        {
            dst = asci8.Null;
            ref var codes = ref Unsafe.As<asci8,AsciCharCode>(ref dst);
            AsciCodes.codes(src, (byte)count, ref codes);
            return ref dst;
        }

        /// <summary>
        /// Populates an asci target with a specified number of source characters
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="count">The number of characters to encode</param>
        /// <param name="dst">The receiver</param>
        [MethodImpl(Inline), Op]
        public static ref readonly asci16 encode(in char src, Hex4 count, out asci16 dst)        
        {
            dst = asci16.Null;
            ref var codes = ref Unsafe.As<asci16,AsciCharCode>(ref dst);
            AsciCodes.codes(src, (byte)count, ref codes);
            return ref dst;
        }

        /// <summary>
        /// Populates an asci target with a specified number of source characters
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="count">The number of characters to encode</param>
        /// <param name="dst">The receiver</param>
        [MethodImpl(Inline), Op]
        public static ref readonly asci32 encode(in char src, Hex5 count, out asci32 dst)        
        {
            dst = asci32.Null;
            ref var codes = ref Unsafe.As<asci32,AsciCharCode>(ref dst);
            AsciCodes.codes(src, (byte)count, ref codes);
            return ref dst;
        }

        /// <summary>
        /// Populates an asci target with a specified number of source characters
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="count">The number of characters to encode</param>
        /// <param name="dst">The receiver</param>
        [MethodImpl(Inline), Op]
        public static ref readonly asci64 encode(in char src, Hex6 count, out asci64 dst)        
        {
            dst = asci64.Null;
            ref var codes = ref Unsafe.As<asci64,AsciCharCode>(ref dst);
            AsciCodes.codes(src, (byte)count, ref codes);
            return ref dst;
        }
    }
}