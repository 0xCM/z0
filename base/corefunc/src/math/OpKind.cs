//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.ComponentModel;
    using static zfunc;

    public enum Genericity : byte
    {
        Direct = 1,


        Generic = 2        
    }

    public enum OpArity : byte
    {
        None = 0,
        
        /// <summary>
        /// Indicates an operator that accepts one input
        /// </summary>
        Unary = 1,

        /// <summary>
        /// Indicates an operator that accepts two inputs, normally described by "left" and "right"
        /// </summary>
        Binary = 2,

        /// <summary>
        /// Indicates an operator that accepts three inputs
        /// </summary>
        Ternary = 3,

        /// <summary>
        /// Indicates an operator that accepts a single input which
        /// can be partitioned into a finite number of elements
        /// </summary>
        UnaryCollection = 10,
    }

    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class ArityAttribute : Attribute
    {
        public ArityAttribute(OpArity Arity)
            => this.Arity = Arity;

        public OpArity Arity {get;} 
    }

    public enum OpFusion : byte
    {
        Atomic,

        Fused,
        
    }


    public enum ParamVariance
    {
        Value,

        In,

        Out,

        Ref, 

    }

    class CompoundOpSymbols
    {
        public const string Eq = "==";

        public const string GtEq = ">=";

        public const string LtEq = "<=";

        public const string NEq = "!=";

        public const string Increment = "++";

        public const string Decrement = "--";

        public const string ShiftL = "<<";

        public const string ShiftR = ">>";

    }

    public enum OpKind : byte
    {        
        None = 0,

        /// <summary>
        /// Indicates a binary operator that computes the sum of the left
        /// and right operands
        /// </summary>
        [Symbol(AsciSym.Plus), Arity(OpArity.Binary)]
        Add,

        /// <summary>
        /// Indicates a binary operator that computes the difference between
        /// the left and right operands
        /// </summary>
        [Symbol(AsciSym.Minus), Arity(OpArity.Binary)]
        Sub,

        /// <summary>
        /// Indicates a binary predicate that computes the product of the left
        /// and right operands
        /// </summary>
        [Symbol(AsciSym.Star), Arity(OpArity.Binary)]
        Mul,

        /// <summary>
        /// Indicates a binary operator that divides the left operand by the
        /// right operand
        /// </summary>
        [Symbol(AsciSym.FSlash), Arity(OpArity.Binary)]
        Div,
        
        /// <summary>
        /// Indicates a binary operator that computes the modulus of the source operands
        /// </summary>
        [Symbol(AsciSym.Percent), Arity(OpArity.Binary)]
        Mod,

        /// <summary>
        /// Indicates a binary operator that computes the bitwise and of the source operands
        /// </summary>
        [Symbol(AsciSym.Amp), Arity(OpArity.Binary)]
        And,
        
        /// <summary>
        /// Indicates a binary operator that computes the composite operation not(a & b)
        /// </summary>
        [Arity(OpArity.Binary)]
        Nand,

        /// <summary>
        /// Indicates a binary operator that computes the bitwise or of the source operands
        /// </summary>
        [Symbol(AsciSym.Pipe), Arity(OpArity.Binary)]
        Or,

        /// <summary>
        /// Indicates a binary operator that computes the composite operation not(a | b)
        /// </summary>
        [Arity(OpArity.Binary)]
        Nor,

        /// <summary>
        /// Indicates a binary operator that computes the bitwise xor of the source operands
        /// </summary>
        [Symbol(AsciSym.Caret), Arity(OpArity.Binary)]
        XOr,

        /// <summary>
        /// Indicates a binary operator that computes the composite operation ~(a ^ b)
        /// </summary>
        [Arity(OpArity.Binary)]
        XNor,

        /// <summary>
        /// Indicates a binary operator that computes the composite operation a & (~b)
        /// </summary>
        [Arity(OpArity.Binary)]
        AndNot,

        /// <summary>
        /// Indicates the ternary operator a ? b : c
        /// </summary>
        [Arity(OpArity.Ternary)]
        AltSelect,

        /// <summary>
        /// Indicates a left-shift bitwise operator
        /// </summary>
        [Symbol(CompoundOpSymbols.ShiftL, MathSym.LT2), Arity(OpArity.Binary),
            Description("Indicates a left-shift bitwise operator")]
        ShiftL,

        /// <summary>
        /// Indicates a right-shift bitwise operator
        /// </summary>
        [Symbol(CompoundOpSymbols.ShiftR, MathSym.GT2), Arity(OpArity.Binary),
            Description("Indicates a right-shift bitwise operator")]
        ShiftR,

        [Arity(OpArity.Binary), 
            Description("Indicates a bitwise operator that rotates the bits of an operand leftwards")]
        RotL,

        [Arity(OpArity.Binary), 
            Description("Indicates a bitwise operator that rotates the bits of an operand rightwards")]
        RotR,

        /// <summary>
        /// Indicates the bitwise complement operator ~
        /// </summary>
        [Arity(OpArity.Unary)]
        Not,

        /// <summary>
        /// Indicates the identity operator x -> x for all x
        /// </summary>
        [Arity(OpArity.Unary)]
        Identity,

        /// <summary>
        /// Indicates a bit test operator
        /// </summary>
        [Arity(OpArity.Binary), Description("Indicates a bitwise binary operator that tests the state of a bit")]
        Test,

        /// <summary>
        /// Indicates a bitwise binary enable operator that sets the state of a bit to enabled
        /// </summary>
        [Arity(OpArity.Binary), 
            Description("Indicates a bitwise binary enable operator that sets the state of a bit to enabled")]
        Enable,

        /// <summary>
        /// Indicates a bitwise binary enable operator that sets the state of a bit to disabled
        /// </summary>
        [Arity(OpArity.Binary), 
            Description("Indicates a bitwise binary enable operator that sets the state of a bit to disabled")]
        Disable,

        /// <summary>
        /// Indicates a bitwise binary operator that reverses the state of a bit
        /// </summary>
        [Arity(OpArity.Binary), 
            Description("Indicates a bitwise binary operator that reverses the state of a bit")]
        Toggle,

        /// <summary>
        /// Indicates a bitwise unary operator that computes the count of an operand's on bits
        /// </summary>
        [Arity(OpArity.Unary), 
            Description("Indicates a bitwise unary operator that computes the count of an operand's on bits")]
        Pop,

        /// <summary>
        /// Indicates a bitwise unary operator that computes the count of an operand's trailing zero bits
        /// </summary>
        [Arity(OpArity.Unary), 
            Description("Indicates a bitwise unary operator that computes the count of an operand's trailing zero bits")]
        Ntz,

        /// <summary>
        /// Indicates a bitwise unary operator that computes the count of an operand's leading zero bits
        /// </summary>
        [Arity(OpArity.Unary), 
            Description("Indicates a bitwise unary operator that computes the count of an operand's leading zero bits")]
        Nlz,

        /// <summary>
        /// Indicates a unary operator that flips the sign of a signed number
        /// </summary>
        [Symbol(AsciSym.Minus), Arity(OpArity.Unary), 
            Description("Indicates a unary operator that reverses the sign of a signed number")]
        Negate,

        /// <summary>
        /// Indicates a unary increment operator
        /// </summary>
        [Symbol(CompoundOpSymbols.Increment), Arity(OpArity.Unary),
            Description("Indicates a unary increment operator")]
        Inc,

        /// <summary>
        /// Indicates a unary operator that decrements a value by a unit
        /// </summary>
        [Symbol(CompoundOpSymbols.Decrement), Arity(OpArity.Unary), 
            Description("Indicates a unary decrement operator")]
        Dec,

        /// <summary>
        /// Indicates a factory operator of unspecified arity
        /// </summary>
        [Description("Indicates a factory operator of unspecified arity")]
        New,

        /// <summary>
        /// Indicates a unary operator that computes the absolute value of a signed number
        /// </summary>
        [Arity(OpArity.Unary),
            Description("Indicates an absolute value operator")]
        Abs,

        /// <summary>
        /// Indicates a sum aggregation operator
        /// </summary>
        [Symbol(MathSym.Sum), 
            Description("Indicates an aggregation operator that computes the sum of an arbitrary number of values")]
        Sum,

        /// <summary>
        /// Indicates an aggregate unary operator that calculates the
        /// average of the operand constituents
        /// </summary>
        [Arity(OpArity.UnaryCollection),
            Description("Indicates an aggregation operator that computes the average of an arbitrary number of values")]
        Avg,
        
        /// <summary>
        /// Indicates a unary aggregate operator calculates the maximum value contained in a collection
        /// </summary>
        [Arity(OpArity.UnaryCollection),
            Description("Indicates a unary aggregate operator calculates the maximum value contained in a collection")]
        Max,

        /// <summary>
        /// Indicates a unary aggregate operator calculates the minimum value contained in a collection
        /// </summary>
        [Arity(OpArity.UnaryCollection)]
        Min,


        [Symbol(Arrows.RightSquiggle)]
        Stream,

        /// <summary>
        /// Indicates a binary float comparison predicate
        /// </summary>
        [Arity(OpArity.Binary)]
        FCmp,
 
        /// <summary>
        /// Indicates a binary predicate that adjudicates operand equality
        /// </summary>
        [Symbol(CompoundOpSymbols.Eq), Arity(OpArity.Binary)]
        Eq,
        
        /// <summary>
        /// Indicates a binary predicate that determines whether the left
        /// operand is strictly larger than the right operand
        /// </summary>
        [Symbol(AsciSym.Gt), Arity(OpArity.Binary)]
        Gt,
        
        /// <summary>
        /// Indicates a binary predicate that determines whether the left
        /// operand is not smaller than the right operand
        /// </summary>
        [Symbol(CompoundOpSymbols.GtEq,MathSym.GTEQ), Arity(OpArity.Binary)]
        GtEq,
        
        /// <summary>
        /// Indicates a binary predicate that determines whether the left operand value is less than the right operand value
        /// </summary>
        [Symbol(AsciSym.Lt), Arity(OpArity.Binary),
            Description("Indicates a binary predicate that determines whether the left operand value is less than the right operand value")]
        Lt,
        
        /// <summary>
        /// Indicates a binary predicate that determines whether the left operand value is less than or equal to the right operand value
        /// </summary>
        [Symbol(CompoundOpSymbols.LtEq, MathSym.LTEQ), Arity(OpArity.Binary),
            Description("Indicates a binary predicate that determines whether the left operand value is less than or equal to the right operand value")]
        LtEq,

        [Arity(OpArity.Unary)]
        Sqrt,

        [Arity(OpArity.Unary)]
        Square,
        
        Parse,

        [Description("Indicates an operator that coverts a value of one type to a value of another type")]
        Convert
    }

}