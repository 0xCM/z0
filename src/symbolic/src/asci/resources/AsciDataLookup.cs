//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Control;
    using static Seed;
    using static Typed;

    using API = ResourceTools;

    [ApiHost("ascidata")]
    public readonly struct AsciDataLookup : IApiHost<AsciDataLookup>
    {
        public static AsciDataLookup Service => default;

        static AsciDataStrings ResData => default;

        /// <summary>
        /// Loads 16 asci symbols beginning at a specified index
        /// </summary>
        /// <param name="index">The index of the first code</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vsymbols(int index)
        {
            ref readonly var src = ref head(ResData.Bytes(n0));
         
            return SymBits.vmove8x16(src);
        }

        /// <summary>
        /// Loads 32 asci codes beginning at a specified index
        /// </summary>
        /// <param name="index">The index of the first code</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> vcodes(int index)
        {
            ref readonly var src = ref head(ResData.Bytes(n0));
         
            return SymBits.vload(w256,src);
        }

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<AsciCharCode> codes()
            => cast<AsciCharCode>(ResData.Bytes(n0));

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<AsciCharCode> codes(int i0, int i1)
            => cast<AsciCharCode>(API.segment(ResData.Bytes(n0),i0,i1));

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<char> chars()
            => ResData.Text(n0);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<char> chars(int i0, int i1)
            => API.segment(ResData.Text(n0),i0,i1);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<AsciChar> symbols()
            => cast<char,AsciChar>(ResData.Text(n0));

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<AsciChar> symbols(int i0, int i1)
            => cast<char,AsciChar>(API.segment(ResData.Text(n0),i0,i1));
    }
}