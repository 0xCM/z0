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
    using static Flow;
    
    using E = ImmInjectionFailed;

    public readonly struct ImmInjectionFailed : IWfEvent<E>
    {
        public WfEventId EventId  => WfEventId.define("Placeholder");

        [MethodImpl(Inline)]
        public ImmInjectionFailed(MethodInfo method)
        {
            Method = method;
        }
        
        public MethodInfo Method {get;}
        
        public string Format()
            => $"Imm injection failure for {Method.Name}";
        
        public MessageFlair Flair
            => MessageFlair.Red;

        public static ImmInjectionFailed Empty 
            => default;
    }
}