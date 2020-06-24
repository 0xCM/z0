//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct ReaderInternals
    {
        internal static string PaddedHex(int src)
            => src.FormatHex(zpad:true, specifier:true, prespec:false);
    }
}