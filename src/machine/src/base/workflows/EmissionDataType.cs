//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public enum EmissionDataType : byte
    {
        None = 0,

        Il,

        x64,

        Pe,

        Konst,

        Blob,

        Strings,

        Rva,

        Field,

        PartDat
    }
}