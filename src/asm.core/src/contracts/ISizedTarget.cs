//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface ISizedTarget
    {
        NativeSize Size {get;}

        AsmAddress Target {get;}
    }

    public interface ISizedTarget<T> : ISizedTarget
        where T : unmanaged, ISizedTarget<T>
    {
    }
}