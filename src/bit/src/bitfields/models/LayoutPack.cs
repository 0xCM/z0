//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Defines the pack size of a struct layout according to https://docs.microsoft.com/en-us/dotnet/api/system.runtime.interopservices.structlayoutattribute.pack?view=net-5.0
    /// </summary>
    public enum LayoutPack : byte
    {
        Default = 0,

        W1 = 1,

        W2 = 2,

        W4 = 4,

        W8 = 8,

        W16 = 16,

        W32 = 32,

        W64 = 64,

        W128 = 128,
    }
}