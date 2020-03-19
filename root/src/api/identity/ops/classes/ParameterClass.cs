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
    using PC = ParameterClass;

    [Flags]
    public enum ParameterClass : uint
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
        Ref = 4,

        /// <summary>
        /// Classifies paramters that require 8-bit immediate values
        /// </summary>
        Imm8 = Pow2.T08,

        /// <summary>
        /// Classifies paramters that require 16-bit immediate values
        /// </summary>
        Imm16 = Imm8 << 1,

        /// <summary>
        /// Classifies paramters that require 32-bit immediate values
        /// </summary>
        Imm32 = Imm16 << 1,

        /// <summary>
        /// Classifies paramters that require 64-bit immediate values
        /// </summary>
        Imm64 = Imm32 << 1,

        /// <summary>
        /// Classifies paramters that are of numeric kind
        /// </summary>
        Numeric = Pow2.T14,

        /// <summary>
        /// Classifies paramters that are of blocked kind
        /// </summary>
        Blocked = Numeric << 1,

        /// <summary>
        /// Classifies paramters of fixed kind
        /// </summary>
        Fixed = Blocked << 1,

        /// <summary>
        /// Classifies paramters that are of vectorized kind
        /// </summary>
        CpuVector = Fixed << 1,

        /// <summary>
        /// Classifies paramters of bitvector kind
        /// </summary>
        BitVector = CpuVector << 1,

        /// <summary>
        /// Classifies paramters of bitmatrix kind
        /// </summary>
        BitMatrix = BitVector << 1,

        /// <summary>
        /// Classifies paramters of bitgrid kind
        /// </summary>
        BitGrid = BitMatrix << 1,
    }

    public enum ParamRefAspect : uint
    {
        /// <summary>
        /// The empty class
        /// </summary>
        None = 0,

        /// <summary>
        /// Classifies paramters that are declared with the "in" modifier
        /// </summary>
        In = PC.In,

        /// <summary>
        /// Classifies paramters that are declared with the "out" modifier
        /// </summary>
        Out = PC.Out,

        /// <summary>
        /// Classifies paramters that are declared with the "ref" modifier
        /// </summary>
        Ref = PC.Ref,
    }    

    /// <summary>
    /// Classfies parameters according to whether the require/expect an immediate value
    /// </summary>
    public enum ParamImmAspect : uint
    {
        None = 0,

        Imm8 = PC.Imm8,

        Imm16 = PC.Imm16,

        Imm32 = PC.Imm32,

        Imm64 = PC.Imm64,
    }

    public enum ParamKindAspect : uint
    {
        None = 0,
    
        Numeric = PC.Numeric,

        Blocked = PC.Blocked,

        /// <summary>
        /// Classifies paramters of fixed kind
        /// </summary>
        Fixed = PC.Fixed,

        /// <summary>
        /// Classifies paramters of vectorized kind
        /// </summary>
        CpuVector = PC.CpuVector,

        /// <summary>
        /// Classifies paramters of bitvector kind
        /// </summary>
        BitVector = PC.BitVector,

        /// <summary>
        /// Classifies paramters of bitmatrix kind
        /// </summary>
        BitMatrix = PC.BitMatrix,

        /// <summary>
        /// Classifies paramters of bitgrid kind
        /// </summary>
        BitGrid = PC.BitGrid
    }
 

    public static class ParamAspectOps
    {
        /// <summary>
        /// Determines the variance of a parameter
        /// </summary>
        /// <param name="src">The source parameter</param>
        public static ParamRefAspect ClassifyVariance(this ParameterInfo src)        
            => src.IsIn 
            ? Z0.ParamRefAspect.In  : src.IsOut 
            ? Z0.ParamRefAspect.Out : src.ParameterType.IsByRef 
            ? Z0.ParamRefAspect.Ref : Z0.ParamRefAspect.None;

        [MethodImpl(Inline)]
        public static bool IsSome(this ParamRefAspect src)        
            => src != ParamRefAspect.None;

        public static string Keyword(this ParamRefAspect src)        
            => src switch{
                ParamRefAspect.In => "in",
                ParamRefAspect.Out => "out",
                ParamRefAspect.Ref => "ref",    
                _ => string.Empty
            };

        public static string Format(this ParamRefAspect src)
            => src.IsSome() ? ('~' + src.Keyword()) : string.Empty;              
    }
}