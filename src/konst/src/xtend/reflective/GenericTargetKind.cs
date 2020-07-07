//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public enum GenericTargetKind : byte
    {
        None = 0,
        
        /// <summary>
        /// Indicates generic argument applies to a type
        /// </summary>
        Type = 2,

        /// <summary>
        /// Indicates generic argument applies to a method
        /// </summary>
        Method = 4,
    }
}