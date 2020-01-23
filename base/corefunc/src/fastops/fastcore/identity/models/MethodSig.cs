//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using static zfunc;

    public enum ParamDirection
    {
        Default,

        In = 1,

        Out = 2
    }

    /// <summary>
    /// Identifies and describes a method that, whithin some useful scope, is unique
    /// </summary>
    public sealed class MethodSig
    {
        public static ParamDirection Direction(ParameterInfo src)
            => src.IsIn ? ParamDirection.In : src.IsOut ? ParamDirection.Out : ParamDirection.Default;

        internal static MethodSig Define(MethodInfo method)
        {            
            var valparams = method.GetParameters().Select(p => new MethodParamRep(TypeRep.FromParameter(p), Direction(p), p.Name, p.Position)).ToArray();
            var typeparams = method.GenericSlots().Mapi((i,t) => new TypeParamRep(t.DisplayName(), i, t.IsGenericType));            
            return new MethodSig(
                MethodId: method.MetadataToken,
                DefiningAssembly: method.Module.Assembly.GetSimpleName(),
                DefiningModule: method.Module.Name,
                DeclaringType: TypeRep.FromType(method.DeclaringType),
                MethodName: method.DisplayName(),
                ReturnType: TypeRep.FromType(method.ReturnType),
                ValueParams: valparams,
                TypeParams: typeparams);
        }

        MethodSig(int MethodId, string DefiningAssembly, string DefiningModule,
            TypeRep DeclaringType, string MethodName, TypeRep ReturnType, MethodParamReps ValueParams, TypeParamReps TypeParams)
        {
            this.MethodId = MethodId;
            this.DefiningAssembly = DefiningAssembly;
            this.DefiningModule = DefiningModule;
            this.DeclaringType = DeclaringType;
            this.MethodName = MethodName;
            this.ReturnType = ReturnType;
            this.ValueParams = ValueParams;
            this.TypeParams = TypeParams;
        }
        
        public int MethodId {get;}
        
        public string MethodName {get;}

        public string DefiningAssembly {get;}

        public string DefiningModule {get;}

        public TypeRep DeclaringType {get;}

        public TypeRep ReturnType {get; }

        public MethodParamReps ValueParams {get; }

        public TypeParamReps TypeParams {get; }
                
        public string Format()
        {
            var sigtext = text();            
            sigtext.Append(ReturnType.Format());
            sigtext.Append(AsciSym.Space);
            sigtext.Append(MethodName);
            sigtext.Append(ValueParams.Format(true));
            return sigtext.ToString();            
        }

        public override string ToString()
            => Format();
    }
}