//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    
    partial struct ProjectModel
    {
        const string OpenTagFence = "<";        

        /// <summary>
        /// Defines the string literal <{0}>
        /// </summary>
        const string OpenTagFormat = "<" + Arg0 + ">";

        /// <summary>
        /// Defines the string literal <{0}/>
        /// </summary>
        const string CloseTagFormat = "</" + Arg0 + ">";
        
        /// <summary>
        /// Defines the string literal <{0}>{1}</{0}>
        /// </summary>
        const string TagFormat = OpenTagFormat + Arg1 + CloseTagFormat;

        const string CloseLineTag = "/>";

        const string Delimiter =" ";

        const string AttribSetOpen = "=\"";

        const string AttribSetClose = "\"";

        const string Arg0 = "{0}";

        const string Arg1 = "{1}";

        const string Arg2 = "{2}";
    }
}