//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class IntelIntrinsics
    {
        /// <summary>
        /// [parameter type="unsigned char" varname="c_in" etype="UI8"]
        /// </summary>
        public struct Parameter : ITextual
        {
            public const string ElementName = "parameter";

            public string varname;

            public string type;

            public string etype;

            public string memwidth;

            public string Format()
            {
                if(text.nonempty(memwidth))
                    return string.Format("{0}:w{1}", varname, memwidth);
                else
                    return string.Format("{0}:{1}", varname, type);
            }

            public override string ToString()
                => Format();
        }
    }
}