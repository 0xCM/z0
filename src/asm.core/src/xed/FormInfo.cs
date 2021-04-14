//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct XedModels
    {
        /// <summary>
        /// Defines a structure that reflects the content of the xed "idata.txt" file
        /// </summary>

        [Record(TableId)]
        public struct FormInfo : IRecord<FormInfo>
        {
            public const string TableId = "xed.form-summary";

            public const byte FieldCount = 6;

            public string Class;

            public string Extension;

            public string Category;

            public string Form;

            public string IsaSet;

            public string Attributes;
        }
    }
}