//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Root;

    partial struct asci
    {
        /// <summary>
        /// Populates a 2-code asci block from the leading cells of a character span
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target block</param>
        [MethodImpl(Inline), Op]
        public static ref readonly asci2 encode(ReadOnlySpan<char> src, out asci2 dst)        
        {
            dst = default;
            
            codes(src, span<asci2,AsciCharCode>(ref dst));
            return ref dst;
        }

        /// <summary>
        /// Populates a 4-code asci block from the leading cells of a character span
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target block</param>
        [MethodImpl(Inline), Op]
        public static ref readonly asci4 encode(ReadOnlySpan<char> src, out asci4 dst)
        {
            dst = default;
            codes(src, span<asci4,AsciCharCode>(ref dst));
            return ref dst;
        }        

        /// <summary>
        /// Populates a 5-code asci block from the leading cells of a character span
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target block</param>
        [MethodImpl(Inline), Op]
        public static ref readonly asci5 encode(ReadOnlySpan<char> src, out asci5 dst)        
        {
            dst = default;
            codes(src, span<asci5,AsciCharCode>(ref dst));
            return ref dst;
        }

        /// <summary>
        /// Populates an 8-code asci block from the leading cells of a character span
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target block</param>
        [MethodImpl(Inline), Op]
        public static ref readonly asci8 encode(ReadOnlySpan<char> src, out asci8 dst)        
        {
            dst = default;
            codes(src, span<asci8,AsciCharCode>(ref dst));
            return ref dst;
        }

        /// <summary>
        /// Populates a 16-code asci block from the leading cells of a character span
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target block</param>
        [MethodImpl(Inline), Op]
        public static ref readonly asci16 encode(ReadOnlySpan<char> src, out asci16 dst)        
        {
            dst = asci16.Blank;
            codes(src, span<asci16,AsciCharCode>(ref dst));
            return ref dst;
        }

        /// <summary>
        /// Populates a 32-code asci block from the leading cells of a character span
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target block</param>
        [MethodImpl(Inline), Op]
        public static ref readonly asci32 encode(ReadOnlySpan<char> src, out asci32 dst)        
        {
            dst = asci32.Blank;
            codes(src, span<asci32,AsciCharCode>(ref dst));
            return ref dst;
        }

        /// <summary>
        /// Populates a 64-code asci block from the leading cells of a character span
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target block</param>
        [MethodImpl(Inline), Op]
        public static ref readonly asci64 encode(ReadOnlySpan<char> src, out asci64 dst)        
        {
            dst = asci64.Blank;
            codes(src, span<asci64,AsciCharCode>(ref dst));
            return ref dst;
        }
    }
}