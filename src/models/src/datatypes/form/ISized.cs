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
        uint Width {get;}   

        uint Size
            => Width/8;
    }

    public interface ISized<W> : ISized
        where W : unmanaged, IDataWidth
    {        
        new W Width => default(W);
        
        uint ISized.Width 
            => Width.Value;
    }

    public interface ISized<F,W> : ISized<W>
        where F : unmanaged, ISized<F,W>
        where W : unmanaged, IDataWidth
    {        

    }
}