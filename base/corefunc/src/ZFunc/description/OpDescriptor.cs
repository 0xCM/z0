//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Linq;
    using System.Reflection;

    using static zfunc;

    /// <summary>
    /// Encapsulates operator information
    /// </summary>
    public sealed class OpDescriptor
    {        
        public static bool operator==(OpDescriptor a, OpDescriptor b)
            => a.Equals(b);

        public static bool operator!=(OpDescriptor a, OpDescriptor b)
            => !a.Equals(b);

        internal static OpDescriptor Define(MethodInfo method, params Type[] args)
        {            
            var dst = Init(method,args);
            dst.Name = dst.Method.Name;
            var attrib = method.CustomAttribute<ZFuncAttribute>();
            attrib.OnSome(z => z.Name.OnSome(n => dst.Name = n));
            dst.Homogenous = dst.Method.IsHomogenous();
            dst.Vectorized = dst.Method.IsVectorized();   
            dst.Signature = dst.Method.Signature();   
            dst.NativeData = dst.Method.CaptureAsm();
            dst.Input = dst.Method.InputWidths();
            dst.Output = dst.Method.OutputWidth();
            dst.Moniker = Z0.Moniker.define(dst.Method);
            return dst;
        }

        public MethodInfo Method {get; private set;}

        public Moniker Moniker {get; private set;}

        public Option<MethodInfo> GenericDefinition {get; private set;}

        public Pair<ParameterInfo,int>[] Input {get; private set;}

        public Pair<ParameterInfo,int> Output {get; private set;}
                
        public Type[] TypeArgs {get; private set;}

        public MethodSig Signature {get; private set;}

        public INativeMemberData NativeData {get; private set;}
        
        public bool Homogenous {get; private set;}

        public bool Vectorized {get; private set;}

        public string Name {get; private set;}

        public string FormatSig()
            => Signature.Format();
        
        public string FormatMapping()
            => $"{Name}:{Input.FormatParams()} -> {Output.FormatParam()}";
        
        public override string ToString()
            => FormatSig();

        public override int GetHashCode()
            => Method.GetHashCode();

        public bool Equals(OpDescriptor a)
            => Method.Equals(a.Method);

        public override bool Equals(object obj)                    
            => obj is OpDescriptor s && Equals(s);
            
        static OpDescriptor Init(MethodInfo method, params Type[] args)
        {
            var dst = new OpDescriptor();

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