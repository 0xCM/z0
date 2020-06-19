//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using E = ImmInjectionFailed;

    public readonly struct ImmInjectionFailed : IAppError<E>
    {
        [MethodImpl(Inline)]
        public static E Define(MethodInfo method)
            => new E(method);

        [MethodImpl(Inline)]
        internal ImmInjectionFailed(MethodInfo method)
        {
            Method = method;
        }
        
        public MethodInfo Method {get;}
        
        public string Description
            => $"Imm injection failure for {Method.Name}";
        
        public E Zero 
            => Empty;

        public static ImmInjectionFailed Empty 
            => new ImmInjectionFailed(typeof(object).GetMethod(nameof(object.GetHashCode)));           
    }
}