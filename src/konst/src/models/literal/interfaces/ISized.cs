//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ISized
    {
        /// <summary>
        /// Specifies the bit-scaled data width
        /// </summary>
        DataWidth Width {get;}    

        /// <summary>
        /// The width expressed in bytes, possibly truncated if the bit-width 
        /// cannot be evenly partitioned into bytes
        /// </summary>
        uint Size 
            => (uint)Width/8;
    }
}