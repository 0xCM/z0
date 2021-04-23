//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Windows;
    using System.Runtime.InteropServices;

    partial struct Images
    {
        public enum MemberRefKind : byte
        {
            Method,

            Field = 1,
        }

    }
}