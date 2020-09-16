//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly partial struct FormatOptions
    {
        [MethodImpl(Inline), Op]
        public static HexFormatOptions hex(bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true, char? delimiter = null)
            => new HexFormatOptions(zpad,specifier, uppercase, prespec, delimiter ?? Space);

        [MethodImpl(Inline), Op]
        public static SeqFormatConfig seq(string delimiter)
            => new SeqFormatConfig(delimiter);

        [MethodImpl(Inline), Op]
        public static BitFormat bits(bool tlz = false)
            => bits(tlz:tlz, specifier:false, blockWidth:null, blocksep:null, rowWidth:null, maxbits:null,zpad:null);

        [MethodImpl(Inline), Op]
        public static BitFormat bitmax(uint maxbits, int? zpad = null)
            => bits(tlz:true, maxbits: maxbits, zpad:zpad);

        [MethodImpl(Inline), Op]
        public static BitFormat bitblock(int width, char? sep = null, uint? maxbits = null, bool specifier = false)
            => bits(tlz:false, blockWidth: width, blocksep: sep, maxbits:maxbits, specifier: specifier);

        [MethodImpl(Inline), Op]
        public static BitFormat bitrows(int blockWidth, int rowWidth, char? blockSep = null)
            => bits(tlz:false, blockWidth: blockWidth, rowWidth:rowWidth, blocksep: blockSep);

        [MethodImpl(Inline), Op]
        public static BitFormat bits(bool tlz, bool specifier = false, int? blockWidth = null,
            char? blocksep = null, int? rowWidth = null, uint? maxbits = null, int? zpad = null)
                => new BitFormat(tlz, specifier, blockWidth, blocksep, rowWidth, maxbits,zpad);
    }
}