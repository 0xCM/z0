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
    public readonly partial struct RenderOptions
    {
        [MethodImpl(Inline), Op]
        public static HexFormatConfig hex(bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true, char? delimiter = null)
            => new HexFormatConfig(zpad,specifier, uppercase, prespec, delimiter ?? Space);

        [MethodImpl(Inline), Op]
        public static SeqFormatConfig seq(string delimiter)
            => new SeqFormatConfig(delimiter);  

        [MethodImpl(Inline), Op]
        public static BitFormatConfig bits(bool tlz = false)
            => bits(tlz:tlz, specifier:false, blockWidth:null, blocksep:null, rowWidth:null, maxbits:null,zpad:null);

        [MethodImpl(Inline), Op]
        public static BitFormatConfig bitmax(int maxbits, int? zpad = null)
            => bits(tlz:true, maxbits: maxbits, zpad:zpad);

        [MethodImpl(Inline), Op]
        public static BitFormatConfig bitblock(int width, char? sep = null, int? maxbits = null, bool specifier = false)
            => bits(tlz:false, blockWidth: width, blocksep: sep, maxbits:maxbits, specifier: specifier);

        [MethodImpl(Inline), Op]
        public static BitFormatConfig bitrows(int blockWidth, int rowWidth, char? blockSep = null)
            => bits(tlz:false, blockWidth: blockWidth, rowWidth:rowWidth, blocksep: blockSep);

        [MethodImpl(Inline), Op]
        public static BitFormatConfig bits(bool tlz, bool specifier = false, int? blockWidth = null, 
            char? blocksep = null, int? rowWidth = null, int? maxbits = null, int? zpad = null)
                => new BitFormatConfig(tlz, specifier, blockWidth, blocksep, rowWidth, maxbits,zpad);
    }
}