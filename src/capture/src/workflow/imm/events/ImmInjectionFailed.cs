//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Seed;
    using E = AsmEvents.ImmInjectionFailed;

    partial class AsmEvents
    {
        public readonly struct ImmInjectionFailed : IAppError<E>
        {
            public static ImmInjectionFailed Empty => new ImmInjectionFailed(typeof(object).GetMethod(nameof(object.GetHashCode)));

            [MethodImpl(Inline)]
            public static E Define(MethodInfo method)
                => new E(method);

            [MethodImpl(Inline)]
            ImmInjectionFailed(MethodInfo method)
            {
                this.Method = method;
            }
            
            public MethodInfo Method {get;}
            
            public string Description
                => $"Imm injection failure for {Method.Name}";
            
            public E Zero => Empty;
           
        }    
    }
}