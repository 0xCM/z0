//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public enum Sign8Kind : byte
    {
        Unsigned = 0,

        Signed = byte.MaxValue ^ sbyte.MaxValue
    }

    public enum Sign16Kind : ushort
    {
        Unsigned = 0,

        Signed = ushort.MaxValue ^ short.MaxValue
    }    

    public enum Sign32Kind : uint
    {
        Unsigned = 0,

        Signed = uint.MaxValue ^ int.MaxValue
    }        

    public enum Sign64Kind : ulong
    {
        Unsigned = 0,

        Signed = ulong.MaxValue ^ long.MaxValue
    }            
}