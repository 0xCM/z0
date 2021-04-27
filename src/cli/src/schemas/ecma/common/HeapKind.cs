//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    public enum HeapKind : byte
    {
        None,

        UserString = 0x70,

        Blob = 0x71,

        Guid = 0x72,

        String = 0x78,
    }

    public enum StringHeapKind : byte
    {
        None = 0,

        Default = 0x78,

        String1 = 0x79,

        String2 = 0x7a,

        String3 = 0x7b,

        Namespace = 0x7c,

    }
}