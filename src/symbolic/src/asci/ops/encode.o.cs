//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;    
 
    using static Seed;
    using static Control;
    using static Typed;

    partial class AsciCodes
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
            Symbolic.literals(src, span<asci2,AsciCharCode>(ref dst));
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
            Symbolic.literals(src, span<asci4,AsciCharCode>(ref dst));
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
            Symbolic.literals(src, span<asci5,AsciCharCode>(ref dst));
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
            Symbolic.literals(src, span<asci8,AsciCharCode>(ref dst));
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
            Symbolic.literals(src, span<asci16,AsciCharCode>(ref dst));
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
            Symbolic.literals(src, span<asci32,AsciCharCode>(ref dst));
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
            Symbolic.literals(src, span<asci64,AsciCharCode>(ref dst));
            return ref dst;
        }
    }
}