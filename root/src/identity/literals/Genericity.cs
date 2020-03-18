//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;

    using T = GenericTarget;
    using S = GenericState;

    public enum GenericTarget : byte
    {
        None = 0,
        
        /// <summary>
        /// Indicates generic argument applies to a method
        /// </summary>
        Method = 2,

        /// <summary>
        /// Indicates generic argument applies to a type
        /// </summary>
        Type = 4
    }

    public enum GenericState : byte
    {
        /// <summary>
        /// Indicates subject is nongeneric
        /// </summary>
        None = 0,

        /// <summary>
        /// Indicates subject is a generic defintion
        /// </summary>
        Definition = 16,

        /// <summary>
        /// Indicates subject is open generic
        /// </summary>
        Open = 32,

        /// <summary>
        /// Indicates subject is closed generic
        /// </summary>
        Closed = 64,
    }

    [Flags]
    public enum Genericy : byte
    {
        None  = 0,

        /// <summary>
        /// Indicates generic argument applies to a method
        /// </summary>
        Type = T.Type,

        /// <summary>
        /// Indicates generic argument applies to a method
        /// </summary>
        Method = T.Method,

        /// <summary>
        /// Indicates subject is a generic defintion
        /// </summary>
        Definition = S.Definition,

        /// <summary>
        /// Indicates subject is open generic
        /// </summary>
        Open = S.Open,

        /// <summary>
        /// Indicates subject is closed generic
        /// </summary>
        Closed = S.Closed,

        /// <summary>
        /// Designates a generic type definition
        /// </summary>
        TypeDefinition = T.Type | S.Definition,

        /// <summary>
        /// Designates a generic method definition
        /// </summary>
        MethodDefinition = T.Method | S.Definition,

        /// <summary>
        /// Designates an open generic type
        /// </summary>
        OpenType = T.Type | S.Open,

        /// <summary>
        /// Designates an open generic method
        /// </summary>
        OpenMethod = T.Method | S.Open,

        /// <summary>
        /// Designates a closed generic type
        /// </summary>
        ClosedType = T.Type | S.Closed,

        /// <summary>
        /// Designates a closed generic method
        /// </summary>
        ClosedMethod = T.Method | S.Closed

    }

    partial class ReflectedClass
    {

        public static GenericState GenericState(this Type src, bool effective)
            =>   src.IsOpenGeneric(false) ? S.Open 
               : src.IsClosedGeneric(false) ? S.Closed 
               : src.IsGenericTypeDefinition ? S.Definition 
               : 0;

        public static GenericState GenericState(this MethodInfo src, bool effective)
            =>   src.IsOpenGeneric() ? S.Open 
               : src.IsClosedGeneric() ? S.Closed 
               : src.IsGenericMethodDefinition ? S.Definition 
               : 0;
    }
}