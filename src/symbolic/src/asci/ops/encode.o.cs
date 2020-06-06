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
        public static ref readonly AsciCode2 encode(ReadOnlySpan<char> src, out AsciCode2 dst)        
        {
            dst = default;
            Symbolic.literals(src, span<AsciCode2,AsciCharCode>(ref dst));
            return ref dst;
        }

        /// <summary>
        /// Populates a 4-code asci block from the leading cells of a character span
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target block</param>
        [MethodImpl(Inline), Op]
        public static ref readonly AsciCode4 encode(ReadOnlySpan<char> src, out AsciCode4 dst)
        {
            dst = default;
            Symbolic.literals(src, span<AsciCode4,AsciCharCode>(ref dst));
            return ref dst;
        }        

        /// <summary>
        /// Populates a 5-code asci block from the leading cells of a character span
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target block</param>
        [MethodImpl(Inline), Op]
        public static ref readonly AsciCode5 encode(ReadOnlySpan<char> src, out AsciCode5 dst)        
        {
            dst = default;
            Symbolic.literals(src, span<AsciCode5,AsciCharCode>(ref dst));
            return ref dst;
        }

        /// <summary>
        /// Populates an 8-code asci block from the leading cells of a character span
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target block</param>
        [MethodImpl(Inline), Op]
        public static ref readonly AsciCode8 encode(ReadOnlySpan<char> src, out AsciCode8 dst)        
        {
            dst = default;
            Symbolic.literals(src, span<AsciCode8,AsciCharCode>(ref dst));
            return ref dst;
        }

        /// <summary>
        /// Populates a 16-code asci block from the leading cells of a character span
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target block</param>
        [MethodImpl(Inline), Op]
        public static ref readonly AsciCode16 encode(ReadOnlySpan<char> src, out AsciCode16 dst)        
        {
            dst = default;
            Symbolic.literals(src, span<AsciCode16,AsciCharCode>(ref dst));
            return ref dst;
        }

        /// <summary>
        /// Populates a 32-code asci block from the leading cells of a character span
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target block</param>
        [MethodImpl(Inline), Op]
        public static ref readonly AsciCode32 encode(ReadOnlySpan<char> src, out AsciCode32 dst)        
        {
            dst = default;
            Symbolic.literals(src, span<AsciCode32,AsciCharCode>(ref dst));
            return ref dst;
        }

        /// <summary>
        /// Populates a 64-code asci block from the leading cells of a character span
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target block</param>
        [MethodImpl(Inline), Op]
        public static ref readonly AsciCode64 encode(ReadOnlySpan<char> src, out AsciCode64 dst)        
        {
            dst = default;
            Symbolic.literals(src, span<AsciCode64,AsciCharCode>(ref dst));
            return ref dst;
        }
    }
}