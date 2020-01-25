//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using Z0.AsmSpecs;

    using static zfunc;

    readonly struct AsmImmUnaryCapture : IAsmImmCapture
    {
        [MethodImpl(Inline)]
        public static IAsmImmCapture Create(MethodInfo src, Moniker baseid)
            => new AsmImmUnaryCapture(src,baseid);
        
        readonly MethodInfo Method;

        readonly Moniker BaseId;

        [MethodImpl(Inline)]
        AsmImmUnaryCapture(MethodInfo method, Moniker baseid)
        {
            this.Method = method;
            this.BaseId = baseid;
        }

        public AsmFunction Capture(byte imm)
        {
            var decoder = AsmServices.Decoder();
            var d = UnaryDelegates(imm).Single();
            return decoder.DecodeFunction(d);
        }

        public IEnumerable<AsmFunction> Capture(params byte[] immediates)
        {
            var decoder = AsmServices.Decoder();
            foreach(var d in UnaryDelegates(immediates))
                yield return decoder.DecodeFunction(d);
        }

        IEnumerable<DynamicDelegate> UnaryDelegates(params byte[] immediates)
        {
            var parameters = Method.GetParameters().ToArray();            
            var optype = parameters[0].ParameterType;
            var width = optype.Width();
            var celltype = optype.GetGenericArguments()[0];
            
            var factory = width switch{
                FixedWidth.W128 => Dynop.unaryfactory(HK.vk128(), BaseId, Method, celltype),
                FixedWidth.W256 => Dynop.unaryfactory(HK.vk256(), BaseId, Method, celltype),
                _ =>throw new NotSupportedException(width.ToString())
            };
            
            foreach(var imm in immediates)            
                yield return factory(imm);                    
        }                    
    }
}