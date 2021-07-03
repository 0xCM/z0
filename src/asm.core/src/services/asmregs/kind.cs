//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static RegFacets;

    partial struct AsmRegs
    {
        /// <summary>
        /// Combines a <see cref='RegIndexCode'/>, a <see cref='RegClassCode'/> and a <see cref='RegWidthCode'/> to produce a <see cref='RegKind'/>
        /// </summary>
        /// <param name="i">The register index</param>
        /// <param name="k">The register class</param>
        /// <param name="w">The register width</param>
        [MethodImpl(Inline), Op]
        public static RegKind kind(RegIndexCode i, RegClassCode k, RegWidthCode w, BitSplitCode s = 0)
            => (RegKind)( ((uint)i  << IndexField) | ((uint)k << ClassField) | ((uint)w << WidthField) | (uint)s);
    }
}