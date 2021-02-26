//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct IntelIntrinsicsModel
    {
        public const string ReturnElement = "return";

        /// <summary>
        /// [return type="unsigned char" varname="c_in" etype="UI8"]
        /// </summary>
        public struct Return
        {
            public string varname;

            public string type;

            public string etype;

            public string memwidth;

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