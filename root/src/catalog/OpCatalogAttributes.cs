//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    /// <summary>
    /// Identifies a parameter that accepts an immediate value
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter)]
    public class ImmAttribute : Attribute
    {


    }

    /// <summary>
    /// Identifies a formal operation for inclusing in the identity assignment and catalog system
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
    public class OpAttribute : Attribute
    {
        public string Name {get;}

        /// <summary>
        /// Indicates whether the operation return type should be reflected in the identity
        /// </summary>
        public bool IncludeReturn {get;}

        public OpAttribute(bool @return = false)
        {
            this.Name = string.Empty;
            this.IncludeReturn = @return;
        }

        public OpAttribute(string name, bool @return = false)
        {
            this.Name = name;          
            this.IncludeReturn = @return;  
        }

        public override string ToString()
            => Name;
    }

    public abstract class SpecificOpAttribute : OpAttribute
    {
        protected SpecificOpAttribute(object kind) 
            : base(false) 
        {

            KindId = (OpKindId)kind;
        }

        public OpKindId KindId {get;}
    }
    


    /// <summary>
    /// Identifies a parameter that accepts an immediate shift count
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter)]
    public class ShiftAttribute : ImmAttribute
    {

        public ShiftAttribute(bool bits)
        {
            if(bits)
            {
                Bits = true;
                Bytes = false;
            }
            else
            {
                Bits = false;
                Bytes = true;
            }
        }

        public ShiftAttribute()
            : this(true)
        {}

        public bool Bits {get;}

        public bool Bytes {get;}
    }    

    /// <summary>
    /// Identifies operations that accept one or more spans and computes a result that is stored in a caller-supplied target span
    /// </summary>
    public class SpanOpAttribute : OpAttribute
    {
        public SpanOpAttribute()
            : base()
        {

        }

    }    
}