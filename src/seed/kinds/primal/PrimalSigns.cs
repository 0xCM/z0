//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public enum Sign8 : byte
    {
        Unsigned = 0,

        Signed = byte.MaxValue ^ sbyte.MaxValue
    }

    public enum Sign16 : ushort
    {
        Unsigned = 0,

        Signed = ushort.MaxValue ^ short.MaxValue
    }    

    public enum Sign32 : uint
    {
        Unsigned = 0,

        Signed = uint.MaxValue ^ int.MaxValue
    }        

    public enum Sign64 : ulong
    {
        Unsigned = 0,

        Signed = ulong.MaxValue ^ long.MaxValue
    }        
}