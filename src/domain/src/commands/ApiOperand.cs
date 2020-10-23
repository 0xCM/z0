//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public struct ApiOperand
    {
        public byte Position;
    }


    public enum ApiOperandKind : ulong
    {

    }

    [Flags]
    public enum ApiOperandClass : ushort
    {
        None = 0,

        Unmanaged = 1,

        Primitive = 2,

        UserDefined = 4,

        Segmented = 8,
    }
}