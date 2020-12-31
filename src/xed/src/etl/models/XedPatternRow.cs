//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using F = XedPatternField;
    using R = XedPatternRow;

    [Record(TableId)]
    public struct XedPatternRow : ITabular<F,R>
    {
        public const string TableId = "xed.summary";

        public static bool load(in TextRow src, ref XedPatternRow dst)
        {
            if(src.CellCount == 9)
            {
                var i=0;
                dst.Class = src[i++];
                dst.Category = src[i++];
                dst.Extension = src[i++];
                dst.IsaSet = src[i++];
                dst.BaseCode = HexByteParser.Service.ParseData(src[i++]).Value ?? BinaryCode.Empty;
                dst.Mod = src[i++];
                dst.Reg = src[i++];
                dst.Pattern = src[i++];
                dst.Operands = src[i++];
                return true;
            }

            return false;
        }

        public string Class;

        public string Category;

        public string Extension;

        public string IsaSet;

        public BinaryCode BaseCode;

        public string Mod;

        public string Reg;

        public string Pattern;

        public string Operands;

        public string DelimitedText(char sep)
            => XedWfOps.format(this,sep);
    }
}