//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IEncodedIndexBuilder
    {
        int Include(params MemberCode[] src);   

        EncodedIndex Freeze();
    }
}