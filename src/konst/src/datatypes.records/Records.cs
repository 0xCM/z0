//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Part;
    using static memory;

    [ApiHost]
    public readonly partial struct Records
    {
        const NumericKind Closure = UnsignedInts;

        public const string DefaultDelimiter = " | ";
    }

    partial struct Msg
    {
        public static RenderPattern<uint,uint> RecordFieldWidthMismatch
            => "The record field count of {0} does not match the supplied width count of {1}";
    }
}