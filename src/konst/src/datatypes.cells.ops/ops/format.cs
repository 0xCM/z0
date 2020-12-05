//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class CellOpKinds
    {
        [MethodImpl(Inline), Op]
        public static string Format(ICellOpKind kind)
            => format<ICellOpKind>(kind);

        [MethodImpl(Inline)]
        public static string format<K>(K kind)
            where K : ICellOpKind
        {
            var name = kind.OperatorType.DisplayName();
            var width = kind.OperandWidth.Format();
            var operand = kind.OperandType.DisplayName();
            var format = text.concat(name, Chars.LBracket, width, Chars.RBracket, Chars.Colon, operand, Chars.MapsTo, operand);
            return format;
        }
    }
}