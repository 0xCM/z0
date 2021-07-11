//-----------------------------------------------------------------------------
// Copyright   : Intel Corporation, 2020
// License     : Apache
// Source      : xed-iclass-enum.h
//-----------------------------------------------------------------------------
namespace Z0
{
    using W = DataWidth;
    using T = XedModels.DataType;

    using static XedModels;

    partial struct XedRules
    {
        [Op]
        public static DataWidth width(DataType src)
            => src switch {
                T.I1 => W.W1,
                T.I8 => W.W8,
                T.I16 => W.W16,
                T.I32 => W.W32,
                T.I64 => W.W64,
                T.U8 => W.W8,
                T.U16 => W.W16,
                T.U32 => W.W32,
                T.U64 => W.W64,
                T.U128 => W.W128,
                T.U256 => W.W256,
                T.F32 => W.W32,
                T.F64 => W.W64,
                T.F80 => W.W80,
                T.B80 => W.W80,
                _ => 0
            };
    }
}