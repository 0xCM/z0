//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static AsmSpecs;
    using static AsmTypes;

    partial class AsmSpecs
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

    partial class AsmTypes
    {

    }
}