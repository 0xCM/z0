//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machine
{
    public interface IMachineIndexBuilder
    {
        int Include(params MemberCode[] src);   

        EncodedIndex Freeze();
    }
}