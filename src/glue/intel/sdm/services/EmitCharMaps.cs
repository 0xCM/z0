//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Root;
    using static core;

    partial class IntelSdmProcessor
    {
        Outcome EmitCharMaps()
        {
            var map = CharMaps.create(Unicode, Asci);
            CharMapper.Emit(map, CharMapPath());
            CharMapper.LogUnmapped(map, SourceDocPath(), UnmappedCharLog());
            return true;
        }
    }
}