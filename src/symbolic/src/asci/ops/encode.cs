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
        /// Populates a 2-code asci block from the leading cells of a character span
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static AsciCode2 encode(ReadOnlySpan<char> src, N2 n)
            => encode(src, out AsciCode2 dst);

        /// <summary>
        /// Populates a 4-code asci block from the leading cells of a character span
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static AsciCode4 encode(ReadOnlySpan<char> src, N4 n)
            => encode(src, out AsciCode4 dst);

        /// <summary>
        /// Populates an 8-code asci block from the leading cells of a character span
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static AsciCode8 encode(ReadOnlySpan<char> src, N8 n)
            => encode(src, out AsciCode8 dst);

        /// <summary>
        /// Populates a 16-code asci block from the leading cells of a character span
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static AsciCode16 encode(ReadOnlySpan<char> src, N16 n)
            => encode(src, out AsciCode16 dst);

        /// <summary>
        /// Populates a 32-code asci block from the leading cells of a character span
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static AsciCode32 encode(ReadOnlySpan<char> src, N32 n)
            => encode(src, out AsciCode32 dst);


        [MethodImpl(Inline), Op]
        public static AsciCode4 encode(string src, N4 n)
        {
            var dst = 0u;
            var data = span(src);
            ref readonly var src16 = ref head(data);
            ref var dst8 = ref imagine<uint,byte>(ref dst);
            seek(ref dst8, 0) = (byte)skip(src16, 0);
            seek(ref dst8, 1) = (byte)skip(src16, 1);
            seek(ref dst8, 2) = (byte)skip(src16, 2);
            seek(ref dst8, 3) = (byte)skip(src16, 3);
            return define(dst, n);
        }
    }
}