//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    public interface ISized
    {
        /// <summary>
        /// Specifies the bit-scaled data width of the reification type
        /// </summary>
        BitSize Width {get;}   

        ByteSize Size
            => Width.Bytes; 
    }

    public interface ISized<W> : ISized
        where W : unmanaged, IDataWidth
    {        
        BitSize ISized.Width 
            => Widths.data<W>();
    }

    public interface ISized<F,W> : ISized<W>
        where F : unmanaged, ISized<F,W>
        where W : unmanaged, IDataWidth
    {        

    }
}