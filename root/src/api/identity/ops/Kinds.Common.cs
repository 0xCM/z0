//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static OpKindId;

    using A = OpKindAttribute;
    
    public static partial class OpKinds
    {


    }

    /// <summary>
    /// Characterizes a type that represents an operation kind
    /// </summary>
    public interface IBitLogicKind : IOpKind
    {
        
    }

    public interface IComparisonKind : IOpKind
    {
        
    }


    public interface IArithmeticKind : IOpKind
    {
        
    }

    /// <summary>
    /// Identifies a formal operation and its kind
    /// </summary>
    public abstract class OpKindAttribute : OpAttribute
    {
        protected OpKindAttribute(object id) 
            : base(false) 
        {

            KindId = (OpKindId)(ulong)Convert.ChangeType(id,typeof(ulong));
        }

        public OpKindId KindId {get;}
    }

    public sealed class IdentityFunctionAttribute : A { public IdentityFunctionAttribute() : base(Identity) {} }

    public static class OpIdentities
    {
        public static string name(MethodInfo m)
        {
            var attrib = m.Tag<OpAttribute>();
            if(attrib.IsNone())
                return m.Name;

            var attribVal = attrib.Value;              
            return attribVal.Name.IsNotBlank() ? attribVal.Name : m.Name;                
        }
    }
}