//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    partial struct AsmCatalogRecords
    {
        /// <summary>
        /// Defines a structure that reflects the content of the xed "idata.txt" file
        /// </summary>

        [Record(TableId), StructLayout(LayoutKind.Sequential)]
        public struct XedFormInfo : IRecord<XedFormInfo>
        {
            public const string TableId = "xed-form-summary";

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