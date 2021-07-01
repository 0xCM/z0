//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class IntelSdmProcessor
    {
        string VolumeMarker(byte vol)
            => string.Format("Vol. {0}", vol);

        Strings VolumeMarkers(byte min, byte max)
        {
            var dst = Strings.create();
            for(var i=min; i<=max; i++)
                dst.Add(VolumeMarker(i));
            return dst;
        }
    }
}