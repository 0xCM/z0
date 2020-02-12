//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static RootShare;

    public interface IOpSpec
    {
        /// <summary>
        /// The operation's api host
        /// </summary>
        ApiHost Host {get;}     

        /// <summary>
        /// The operation identity
        /// </summary>
        OpIdentity Id {get;}        

        /// <summary>
        /// The method upon which the specification is defined
        /// </summary>
        MethodInfo Subject {get;}    
    }

    public interface IDirectOpSpec : IOpSpec
    {
        MethodInfo ConcreteMethod {get;}        

        MethodInfo IOpSpec.Subject
            => ConcreteMethod;
    }

    public interface IGenericOpSpec : IOpSpec
    {
        MethodInfo MethodDefinition {get;}        

        MethodInfo IOpSpec.Subject
            => MethodDefinition;
    }

    public interface IClosedOpSpec : IOpSpec
    {
        MethodInfo ClosedMethod {get;}        

        MethodInfo IOpSpec.Subject
            => ClosedMethod;
    }
}