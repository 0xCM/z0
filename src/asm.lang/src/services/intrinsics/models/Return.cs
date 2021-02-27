//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Part;

    partial class IntelIntrinsics
    {
        /// <summary>
        /// [return type="unsigned char" varname="c_in" etype="UI8"]
        /// </summary>
        public struct Return : ITextual
        {
            public const string ElementName = "return";

            public string varname;

            public string type;

            public string etype;

            public string memwidth;

            public string Format()
                => format(this);

            public override string ToString()
                => Format();

            public static Return Empty
            {
                get
                {
                    var dst = new Return();
                    dst.varname = EmptyString;
                    dst.type = EmptyString;
                    dst.etype = EmptyString;
                    dst.memwidth = EmptyString;
                    return dst;
                }
            }
        }
    }
}