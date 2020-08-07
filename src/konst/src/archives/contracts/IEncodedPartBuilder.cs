//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IEncodedPartBuilder
    {
        int Include(params MemberCode[] src);   

        EncodedParts Freeze();
    }
}