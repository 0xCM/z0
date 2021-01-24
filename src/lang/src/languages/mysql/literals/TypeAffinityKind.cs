//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    partial struct MySql
    {
        public enum TypeAffinityKind : byte
        {
            None = 0,

            Text = 1,

            Numeric = 2,

            Integer = 4,

            Real = 8,

            Blob = 16
        }
    }
}