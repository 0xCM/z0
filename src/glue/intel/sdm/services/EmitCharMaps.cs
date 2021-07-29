//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Root;

    partial class IntelSdm
    {
        public Outcome EmitCharMaps()
        {
            var map = CharMaps.create(Unicode, Asci);
            CharMapper.Emit(map, CharMapPath());
            CharMapper.LogUnmapped(map, SdmUnicodePath(), UnmappedCharLog());
            return true;
        }
    }
}