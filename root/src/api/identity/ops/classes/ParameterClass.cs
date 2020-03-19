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
 
    [Flags]
    public enum ParameterClass : byte
    {
        None = 0,
    
    }

    /// <summary>
    /// Classfies parameters according to whether the require/expect an immediate value
    /// </summary>
    public enum ParamImmAspect : byte
    {

        None = 0,

        Imm8 = 1,

        Imm16 = 2,

        Imm32 = 3,

        Imm64 = 4

    }

    public enum ParamRefClass
    {
        /// <summary>
        /// The empty class
        /// </summary>
        None = 0,

        /// <summary>
        /// Classifies paramters that are declared with the "in" modifier
        /// </summary>
        In = 1,

        /// <summary>
        /// Classifies paramters that are declared with the "out" modifier
        /// </summary>
        Out = 2,

        /// <summary>
        /// Classifies paramters that are declared with the "ref" modifier
        /// </summary>
        Ref = 4
    }    

    public static class ParameterClassOps
    {
        /// <summary>
        /// Determines the variance of a parameter
        /// </summary>
        /// <param name="src">The source parameter</param>
        public static ParamRefClass ClassifyVariance(this ParameterInfo src)        
            => src.IsIn 
            ? Z0.ParamRefClass.In  : src.IsOut 
            ? Z0.ParamRefClass.Out : src.ParameterType.IsByRef 
            ? Z0.ParamRefClass.Ref : Z0.ParamRefClass.None;

        [MethodImpl(Inline)]
        public static bool IsSome(this ParamRefClass src)        
            => src != ParamRefClass.None;

        public static string Keyword(this ParamRefClass src)        
            => src switch{
                ParamRefClass.In => "in",
                ParamRefClass.Out => "out",
                ParamRefClass.Ref => "ref",    
                _ => string.Empty
            };

        public static string Format(this ParamRefClass src)
            => src.IsSome() ? ('~' + src.Keyword()) : string.Empty;              
    }
}