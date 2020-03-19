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
 
    using static ImmClass;

    /// <summary>
    /// Identifies a parameter that accepts an immediate value
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter)]
    public class ImmAttribute : Attribute
    {

    }

    /// <summary>
    /// Classfies operations according to their immediate needs
    /// </summary>
    [Flags]
    public enum ImmClass : byte
    {
        /// <summary>
        /// The empty class
        /// </summary>
        None = 0,
        
        /// <summary>
        /// Classifies operations that accept one or more immediate values
        /// </summary>
        Imm8 = 1,

        /// <summary>
        /// Classifies operations that accept immediate values in the first parameter
        /// </summary>
        ImmSlot0 = 2,

        /// <summary>
        /// Classifies operations that accept immediate values in the second parameter
        /// </summary>
        ImmSlot1 = 4,

        /// <summary>
        /// Classifies operations that accept immediate values in the third parameter
        /// </summary>
        ImmSlot2 = 8,

        /// <summary>
        /// Classifies operations that accept immediate values in the fourth parameter
        /// </summary>
        ImmSlot3 = 16,

        /// <summary>
        /// Classifies operations that accept immediate values in the fifth parameter
        /// </summary>
        ImmSlot4 = 32,

        /// <summary>
        /// Classifies operations that immediate one immediate value
        /// </summary>
        ImmCount1 = 64,

        /// <summary>
        /// Classifies operations that immediate two immediate values
        /// </summary>
        ImmCount2 = 128,

        /// <summary>
        /// F:A -> byte -> A
        /// </summary>
        UnaryImm8 = Imm8 | ImmCount1 | ImmSlot1,

        /// <summary>
        /// F:A -> A -> byte -> A
        /// </summary>
        BinaryImm8 = Imm8 | ImmCount1 | ImmSlot2,

        /// <summary>
        /// F:A -> A -> A -> byte -> A
        /// </summary>
        TernaryImm8 = Imm8 | ImmCount1 | ImmSlot3,

        /// <summary>
        /// F:A -> byte -> byte -> A
        /// </summary>
        UnaryImm8x2 = Imm8 | ImmCount2 | ImmSlot1 | ImmSlot2,

        /// <summary>
        /// F:A -> A -> byte -> byte -> A
        /// </summary>
        BinaryImm8x2 = Imm8 | ImmCount2 | ImmSlot2 | ImmSlot3,

        /// <summary>
        /// F:A -> A -> A -> byte -> byte -> A
        /// </summary>
        TernaryImm8x2 = Imm8 | ImmCount2 | ImmSlot3 | ImmSlot4        
    }

    public static class ImmClassOps
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

        static ImmClass ImmSlotClass(this ParameterInfo p)
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
        public static ImmClass ImmClass(this MethodInfo src)
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