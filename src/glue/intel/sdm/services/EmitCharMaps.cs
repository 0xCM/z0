//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class IntelSdm
    {
        public Outcome EmitCharMaps()
        {
            var map = CharMaps.create(TextEncodings.Unicode, TextEncodings.Asci);
            CharMapper.Emit(map, SdmPaths.CharMapPath());
            CharMapper.LogUnmapped(map, SdmPaths.SdmSrcPath(), SdmPaths.UnmappedCharLog());
            return true;
        }
    }
}