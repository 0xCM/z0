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

        [Op]
        internal static string slot(uint index, RenderWidth width, string delimiter = DefaultDelimiter)
            => delimiter + RP.slot(index, (short)(-(short)width));

        [Op]
        internal static string pattern(Index<CellFormatSpec> cells, string delimiter = DefaultDelimiter)
        {
            var count = cells.Count;
            var view = cells.View;
            var parts = sys.alloc<string>(count);
            for(var i=0u; i<count; i++)
            {
                var cell = skip(view,i);
                seek(parts,i) = Records.slot(i, cell.Width, delimiter);
            }
            return string.Concat(parts);
        }
    }

    partial struct Msg
    {
        public static RenderPattern<uint,uint> RecordFieldWidthMismatch
            => "The record field count of {0} does not match the supplied width count of {1}";
    }
}