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
        public static IAsmImmCapture Create(IAsmContext context, MethodInfo src, Moniker baseid)
            => new AsmImmUnaryCapture(context.WithEmptyClrIndex(), src,baseid);

        public IAsmContext Context {get;}
        
        readonly MethodInfo Method;

        readonly Moniker BaseId;

        [MethodImpl(Inline)]
        AsmImmUnaryCapture(IAsmContext context, MethodInfo method, Moniker baseid)
        {            
            this.Context = context;
            this.Method = method;
            this.BaseId = baseid;
        }

        public AsmFunction Capture(byte imm)
        {
            var decoder = Context.Decoder();
            var d = UnaryDelegates(imm).Single();
            return decoder.DecodeFunction(d);
        }

        public IEnumerable<AsmFunction> Capture(params byte[] immediates)
        {
            var decoder = Context.Decoder();
            foreach(var d in UnaryDelegates(immediates))
                yield return decoder.DecodeFunction(d);
        }

        IEnumerable<DynamicDelegate> UnaryDelegates(params byte[] immediates)
        {
            (var celltype, var width) = Method.ParameterTypes()
                    .Where(p => p.IsVector())
                    .Select(x => (x.SuppliedGenericArguments().Single(),x.Width()))
                    .FirstOrDefault();            

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