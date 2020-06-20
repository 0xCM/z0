//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Konst;
    partial class XTend
    {        
        /// <summary>
        /// Formats an operator type class using divined identifiers
        /// </summary>
        /// <param name="src">The class to format</param>
        public static string Format(this OperatorTypeClass src)
            =>  src.IsEmpty 
                ? string.Empty 
                : "f:" + text.format(Identity.identify(src.OperandType))
                            .Replicate(src.OperatorClass.ArityValue() + 1)
                            .Intersperse(AsciArrow)
                            .Concat();
    }
}