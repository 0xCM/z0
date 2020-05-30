//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Control;
    using static Seed;
    using static Typed;

    using API = ResourceTools;

    [ApiHost("ascidata")]
    public readonly struct AsciDataLookup : IApiHost<AsciDataLookup>
    {
        public static AsciDataLookup Service => default;

        static AsciDataStrings ResData => default;

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