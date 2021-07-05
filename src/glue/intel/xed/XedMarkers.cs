//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public readonly struct XedMarkers
    {
        public static TextMarker BeginLegal => text.marker("#BEGIN_LEGAL");

        public static TextMarker EndLegal => text.marker("#END_LEGAL");

        public static TextMarker File => text.marker("###FILE:");

        public static TextMarker Comment => text.marker(Chars.Hash);

        public static TextMarker OpenSpec => text.marker(Chars.LBrace);

        public static TextMarker CloseSpec  => text.marker(Chars.RBrace);

        public static TextMarker PropDelimiter => text.marker(Chars.Colon);
    }
}