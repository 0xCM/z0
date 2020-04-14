//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Seed;

    partial class XTend
    {        
        /// <summary>
        /// Formats an operator type class using divined identifiers
        /// </summary>
        /// <param name="src">The class to format</param>
        public static string Format(this OperatorTypeClass src)
            =>  src.IsNone 
                ? string.Empty 
                : "f:" + Formattable.format(Identity.identify(src.OperandType))
                            .Replicate(src.OperatorClass.ArityValue() + 1)
                            .Intersperse(CharText.AsciArrow)
                            .Concat();
    }
}