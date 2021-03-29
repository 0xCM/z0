//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;
    using static memory;

    public class Vsib : WfService<Vsib>
    {
        public string Format(VsibBits src)
        {
            var buffer = text.buffer();
            buffer.Append("[ ");
            buffer.Append(src.SS.ToString());
            buffer.Append(" | ");
            buffer.Append(src.Index.ToString());
            buffer.Append(" | ");
            buffer.Append(src.Base.ToString());
            buffer.Append(" ]");
            return buffer.Emit();
        }

        [MethodImpl(Inline), Op]
        public static VsibBits vsib(byte src)
            => new VsibBits(src);

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
        public static MemoryAddress effective(VsibBits vsib, Vector256<uint> src, uint dx)
            => vsib.Scale()*cpu.vcell(src, vsib.Index)+ (ulong)vsib.Base + (ulong)dx;
    }
}