//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    sealed class EmitImageMaps : CmdReactor<EmitImageMapsCmd, Index<LocatedImageRow>>
    {
        protected override Index<LocatedImageRow> Run(EmitImageMapsCmd cmd)
            => ImageMaps.emit(ImageMaps.index(), cmd.Target);
    }
}