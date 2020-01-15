//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;

    using static zfunc;

    /// <summary>
    /// Encapsulates operator information
    /// </summary>
    public sealed class Operation
    {        
        public static bool operator==(Operation a, Operation b)
            => a.Equals(b);

        public static bool operator!=(Operation a, Operation b)
            => !a.Equals(b);

        internal static Operation Define(MethodInfo method, params Type[] args)
        {            
            var dst = Init(method,args);
            dst.Moniker = Moniker.define(dst.Method);
            method.CustomAttribute<OpAttribute>()
                .OnSome(z => z.Name.OnSome(n => dst.Name = n))
                .OnNone(() => dst.Name = dst.Method.Name);
            dst.NativeData = dst.Method.CaptureAsm();
            return dst;
        }

        internal static Operation Define(MethodInfo method, Moniker m)
        {            
            var dst = Init(method);
            dst.Moniker = m;
            method.CustomAttribute<OpAttribute>()
                .OnSome(z => z.Name.OnSome(n => dst.Name = n))
                .OnNone(() => dst.Name = dst.Method.Name);
            dst.NativeData = dst.Method.CaptureAsm();
            return dst;
        }

        public string Name {get; private set;}

        public MethodInfo Method {get; private set;}

        public Moniker Moniker {get; private set;}

        public Option<MethodInfo> GenericDefinition {get; private set;}

        public Type[] TypeArgs {get; private set;}

        public IEnumerable<Pair<ParameterInfo,int>> Input 
            => Method.InputWidths();

        public Pair<ParameterInfo,int> Output 
            => Method.OutputWidth();
                
        public MethodSig Signature 
            => Method.Signature();

        public INativeMemberData NativeData {get; private set;}
        
        public bool Homogenous 
            => Method.IsHomogenous();

        public bool Vectorized 
            => Method.IsVectorized();   
        
        public string FormatMapping()
            => $"{Name}:{Input.FormatParams()} -> {Output.FormatParam()}";
        
        public override string ToString()
            => Signature.Format();

        public override int GetHashCode()
            => Method.GetHashCode();

        public bool Equals(Operation a)
            => Method.Equals(a.Method);

        public override bool Equals(object obj)                    
            => obj is Operation s && Equals(s);
            
        static Operation Init(MethodInfo method, params Type[] args)
        {
            var dst = new Operation();

            if(method.IsConstructedGenericMethod)
            {
                dst.Method = method;
                dst.TypeArgs = method.GetGenericArguments();
                dst.GenericDefinition = method.GetGenericMethodDefinition();
            }
            else if(method.IsGenericMethodDefinition)
            {
                dst.Method = method.MakeGenericMethod(args);
                dst.TypeArgs = args;
                dst.GenericDefinition = method;
            }
            else if(method.IsGenericMethod)
            {
                var def = method.GetGenericMethodDefinition();
                dst.Method = def.MakeGenericMethod(args);
                dst.TypeArgs = args;
                dst.GenericDefinition = def;
            }
            else
            {
                dst.Method = method;
                dst.TypeArgs = new Type[]{};
            }
            return dst;
        }
    }
}