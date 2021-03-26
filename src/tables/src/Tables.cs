//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Part;

    [ApiHost]
    public readonly partial struct Tables
    {
        const NumericKind Closure = UnsignedInts;

        public const string DefaultDelimiter = " | ";

    }

    partial struct Msg
    {
        public static MsgPattern<uint,uint> RecordFieldWidthMismatch
            => "The record field count of {0} does not match the supplied width count of {1}";
    }
}