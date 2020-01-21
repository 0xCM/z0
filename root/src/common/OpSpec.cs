//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    /// <summary>
    /// Encapsulates operator information
    /// </summary>
    public sealed class OpSpec
    {        
        public static bool operator==(OpSpec a, OpSpec b)
            => a.Equals(b);

        public static bool operator!=(OpSpec a, OpSpec b)
            => !a.Equals(b);

        public Moniker Id {get; set;}

        public string Name {get; set;}

        public string Label {get; set;}

        public MethodInfo Method {get; set;}

        public Type[] TypeArgs {get; set;}


        public override int GetHashCode()
            => Method.GetHashCode();

        public bool Equals(OpSpec a)
            => Method.Equals(a.Method);

        public override bool Equals(object obj)                    
            => obj is OpSpec s && Equals(s);            
    }
}