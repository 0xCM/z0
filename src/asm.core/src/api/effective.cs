//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;
    using static core;

    using K = EffectiveAddress.ComponentKind;

    partial struct asm
    {
        /// <summary>
        /// Specifies an effective address for 8-bit operands
        /// </summary>
        /// <param name="w">The register width selector</param>
        /// <param name="base">The base register code</param>
        /// <param name="index">The index register code</param>
        /// <param name="scale">The scale factor</param>
        /// <param name="disp">The displacement</param>
        [MethodImpl(Inline), Op]
        public static EffectiveAddress effective(W8 w, RegIndexCode @base, RegIndexCode? index = null, MemoryScale? scale = null, Disp? disp = null)
        {
            var dst = new EffectiveAddress();
            dst.RegWidth = RegWidthCode.W8;
            return effective(ref dst, @base, index, scale, disp);
        }

        /// <summary>
        /// Specifies an effective address for 16-bit operands
        /// </summary>
        /// <param name="w">The register width selector</param>
        /// <param name="base">The base register code</param>
        /// <param name="index">The index register code</param>
        /// <param name="scale">The scale factor</param>
        /// <param name="disp">The displacement</param>
        [MethodImpl(Inline), Op]
        public static EffectiveAddress effective(W16 w, RegIndexCode @base, RegIndexCode? index = null, MemoryScale? scale = null, Disp? disp = null)
        {
            var dst = new EffectiveAddress();
            dst.RegWidth = RegWidthCode.W16;
            return effective(ref dst, @base, index, scale, disp);
        }

        /// <summary>
        /// Specifies an effective address for 32-bit operands
        /// </summary>
        /// <param name="w">The register width selector</param>
        /// <param name="base">The base register code</param>
        /// <param name="index">The index register code</param>
        /// <param name="scale">The scale factor</param>
        /// <param name="disp">The displacement</param>
        [MethodImpl(Inline), Op]
        public static EffectiveAddress effective(W32 w, RegIndexCode @base, RegIndexCode? index = null, MemoryScale? scale = null, Disp? disp = null)
        {
            var dst = new EffectiveAddress();
            dst.RegWidth = RegWidthCode.W32;
            return effective(ref dst, @base, index, scale, disp);
        }

        /// <summary>
        /// Specifies an effective address for 64-bit operands
        /// </summary>
        /// <param name="w">The register width selector</param>
        /// <param name="base">The base register code</param>
        /// <param name="index">The index register code</param>
        /// <param name="scale">The scale factor</param>
        /// <param name="disp">The displacement</param>
        [MethodImpl(Inline), Op]
        public static EffectiveAddress effective(W64 w, RegIndexCode @base, RegIndexCode? index = null, MemoryScale? scale = null, Disp? disp = null)
        {
            var dst = new EffectiveAddress();
            dst.RegWidth = RegWidthCode.W64;
            return effective(ref dst, @base, index, scale, disp);
        }

        /// <summary>
        /// Specifies an effective address
        /// </summary>
        /// <param name="w">The register width code</param>
        /// <param name="base">The base register code</param>
        /// <param name="index">The index register code</param>
        /// <param name="scale">The scale factor</param>
        /// <param name="disp">The displacement</param>
        [MethodImpl(Inline), Op]
        public static EffectiveAddress effective(RegWidthCode w, RegIndexCode @base, RegIndexCode? index = null, MemoryScale? scale = null, Disp? disp = null)
        {
            var dst = new EffectiveAddress();
            dst.RegWidth = w;
            return effective(ref dst, @base, index, scale,disp);
        }

        /// <summary>
        /// Effective address computation with vsib addressing
        /// </summary>
        /// <remarks>
        /// Each element i of the effective address array is computed using the formula:
        /// effective address[i] = scale * index[i] + base + displacement, where index[i]
        /// is the ith element of the XMM/YMM register specified by {X, VSIB.index}.
        /// An index element is either 32 or 64 bits wide and is treated as a signed integer
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static MemoryAddress effective(Vsib vsib, Vector256<uint> src, uint dx)
            => vsib.Scale()*src.GetElement(vsib.Index())+ (ulong)vsib.Base() + (ulong)dx;

        [MethodImpl(Inline), Op]
        static ref EffectiveAddress effective(ref EffectiveAddress dst, RegIndexCode @base, RegIndexCode? index = null, MemoryScale? scale = null, Disp? disp = null)
        {
            dst.Base = @base;
            dst.Components = K.RegWidth | K.Base;
            if(index != null)
            {
                dst.Components |= K.Index;
                dst.Index = extract(index);
            }

            if(scale != null)
            {
                dst.Components |= K.Scale;
                dst.Scale = extract(scale);
            }

            if(disp != null)
            {
                dst.Components |= K.Disp;
                dst.Disp = extract(disp);
            }
            return ref dst;
        }
    }
}