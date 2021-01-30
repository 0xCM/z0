//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public enum BitSectionStyle : byte
    {
        /// <summary>
        /// Indicates a <see cref='BitSection'/ is presented as [max:min]
        /// </summary>
        Intel = 0,

        /// <summary>
        /// Indicates a <see cref='BitSection'/ is presented as [min,max]
        /// </summary>
        Interval = 1,
    }
}