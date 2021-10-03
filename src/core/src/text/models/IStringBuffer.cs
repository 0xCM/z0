//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IStringBuffer
    {
        MemoryAddress Base {get;}

        ByteSize Size {get;}
    }
}