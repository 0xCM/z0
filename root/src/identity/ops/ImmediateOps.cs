//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;

    using static Root;
 
    using NK = NumericKind;
    using static ImmediateClass;

    partial class ReflectedClass
    {
        /// <summary>
        /// Determines whether a parameters is an immediate
        /// </summary>
        /// <param name="src">The source parameter</param>
        public static bool IsImmediate(this ParameterInfo param)
            => param.Tagged<ImmAttribute>();

        /// <summary>
        /// Determines whether a method defines a parameter that requires an 8-bit immediate immediate
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool AcceptsImmediate(this MethodInfo m)        
            => m.GetParameters().Where(IsImmediate).Any();

        /// <summary>
        /// Selects parameters from a method, if any, that acceptrequire an immediate value
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static IEnumerable<ParameterInfo> ImmParameters(this MethodInfo src)
            => from p in src.GetParameters()
                where p.IsImmediate()
                select p;

        /// <summary>
        /// Returns a method's immediate parameter types
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static IEnumerable<Type> ImmParameterTypes(this MethodInfo src)
            => src.ImmParameters().Select(p => p.ParameterType);

        /// <summary>
        /// Determines whether a method defines an index-identified parameter that requires an 8-bit immediate immediate
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool AcceptsImmediate(this MethodInfo m, int index)        
        {
            var parameters = m.GetParameters().ToArray();
            return parameters.Length > index && parameters[index].IsImmediate();
        }

        static ImmediateClass ImmSlotClass(this ParameterInfo p)
        {
            switch(p.Position)
            {
                case 0:
                    return ImmSlot0;
                case 1:
                    return ImmSlot1;
                case 2:
                    return ImmSlot2;
                case 3:
                    return ImmSlot3;
                case 4:
                    return ImmSlot4;
                default:
                    return 0;
            }
        }

        /// <summary>
        /// Calculates a method's immediate class
        /// </summary>
        /// <param name="src">The method to classify</param>
        public static ImmediateClass ImmClass(this MethodInfo src)
        {
            var parms = src.ImmParameters().ToArray();
            var count = parms.Length;
            if(count == 0 || count > 2)
                return 0;

            var immc = Imm8;
            var first = parms.First();
            switch(count)
            {
                case 1:
                    immc |= ImmCount1;
                    immc |= first.ImmSlotClass();
                break;

                case 2:
                    var second = parms.Last();
                    immc |= ImmCount2;
                    immc |= first.ImmSlotClass();
                    immc |= second.ImmSlotClass();
                break;
            }
            
            return immc;
        }
    }
}