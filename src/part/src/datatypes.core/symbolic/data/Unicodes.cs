//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly partial struct Unicodes
    {
        enum Lo : byte
        {
            Tab = Unicode.Tab & 0xFF,

            LF = Unicode.LF & 0xFF,

            FF = Unicode.FF & 0xFF,

            CR = Unicode.CR & 0xFF,

            Space = Unicode.Space & 0xFF,

            NextLine = Unicode.NextLine & 0xFF,

            NoBreakSpace = Unicode.NoBreakSpace &  0xFF,
        }

        enum Hi : byte
        {
            Tab = Unicode.Tab >> 8,

            LF = Unicode.LF >> 8,

            FF = Unicode.FF >> 8,

            CR = Unicode.CR >> 8,

            Space = Unicode.Space >> 8,

            NextLine = Unicode.NextLine >> 8,

            NoBreakSpace = Unicode.NoBreakSpace >> 8,
        }
    }
}