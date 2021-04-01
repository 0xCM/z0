//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    /// <summary>
    /// Defines a structure that reflects the content of the xed "idata.txt" file
    /// </summary>

    [Record(TableId)]
    public struct XedFormSource : IRecord<XedFormSource>
    {
        public const string TableId = "xed.forms.source";

        public const byte FieldCount = 6;

        public string Class;

        public string Extension;

        public string Category;

        public string Form;

        public string IsaSet;

        public string Attributes;
    }

}