//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;

    using static ImmFunctionClass;

    partial class XKinds
    {
        /// <summary>
        /// Calculates a method's immediate class
        /// </summary>
        /// <param name="src">The method to classify</param>
        [Op]
        public static ImmFunctionClass ImmFunctionClass(this MethodInfo src, ScalarRefinementKind refinement)
        {
            var found = src.ImmParameters(refinement);
            var count = found.Length;
            if(count == 0 || count > 2)
                return 0;

            var dst = Imm8;
            var first = found.First();
            switch(count)
            {
                case 1:
                    dst |= ImmCount1;
                    dst |= first.ImmSlot();
                break;

                case 2:
                    var second = found.Last();
                    dst |= ImmCount2;
                    dst |= first.ImmSlot();
                    dst |= second.ImmSlot();
                break;
            }

            return dst;
        }
    }
}