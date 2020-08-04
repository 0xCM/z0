//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Defines classifiers that correspond to the basic CLR types
    /// </summary>
    public enum ClrTypeKind : byte
    {
        None = 0,

        Class = 1,

        Struct = 2,

        Delegate = 4,

        Enum = 8,

        Interface = 16
    }
}
