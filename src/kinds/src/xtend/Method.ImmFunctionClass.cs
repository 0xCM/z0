//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;

    using static ImmFunctionClass;

    partial class XTend
    {
        /// <summary>
        /// Calculates a method's immediate class
        /// </summary>
        /// <param name="src">The method to classify</param>
        public static ImmFunctionClass ImmFunctionClass(this MethodInfo src, ImmRefinementKind refinement)
        {
            var parms = src.ImmParameters(refinement).ToArray();
            var count = parms.Length;
            if(count == 0 || count > 2)
                return 0;

            var immc = Z0.ImmFunctionClass.Imm8;
            var first = parms.First();
            switch(count)
            {
                case 1:
                    immc |= ImmCount1;
                    immc |= first.ImmSlot();
                break;

                case 2:
                    var second = parms.Last();
                    immc |= ImmCount2;
                    immc |= first.ImmSlot();
                    immc |= second.ImmSlot();
                break;
            }
            
            return immc;
        } 


    }
}