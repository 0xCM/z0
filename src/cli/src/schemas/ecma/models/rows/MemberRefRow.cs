//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System.Runtime.InteropServices;

    using static Relations;

    public struct MemberRefRow : IRecord<MemberRefRow>
    {
        public RowKey Key;

        public int Class;

        public FK<StringIndex> Name;

        public FK<BlobIndex> Signature;
    }
}