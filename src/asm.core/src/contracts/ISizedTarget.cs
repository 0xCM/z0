//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface ISizedTarget
    {
        AsmSizeKind SizeKind {get;}

        AsmAddress Target {get;}
    }

    public interface ISizedTarget<T> : ISizedTarget
        where T : unmanaged, ISizedTarget<T>
    {
    }

}