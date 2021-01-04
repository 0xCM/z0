//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System.Runtime.InteropServices;

    public struct MemberRefRow : IRecord<MemberRefRow>
    {
        public RowKey Key;

        public int Class;

        public FK<string> Name;

        public FK<byte> Signature;
    }
}