//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Types
{
    public interface sized
    {
        uint Size {get;}
    }

    public interface sized<W> : sized
        where W : unmanaged, IDataWidth
    {
        uint sized.Size => Widths.measure<W>();

        DataWidth Width => Widths.data<W>();
        
    }

}