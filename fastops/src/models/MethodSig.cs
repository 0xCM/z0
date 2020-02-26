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

    /// <summary>
    /// Identifies and describes a method that, whithin some useful scope, is unique
    /// </summary>
    public sealed class MethodSig
    {
        internal static MethodSig Define(MethodInfo method)
        {            
            var valparams = method.GetParameters().Select(p => new MethodParameter(TypeSig.FromParameter(p), p.Variance(), p.Name, p.Position)).ToArray();
            var typeparams = TypeParameters(method);
            return new MethodSig(
                MethodId: method.MetadataToken,
                DefiningAssembly: method.Module.Assembly.GetSimpleName(),
                DefiningModule: method.Module.Name,
                DeclaringType: TypeSig.FromType(method.DeclaringType),
                MethodName: method.DisplayName(),
                ReturnType: TypeSig.FromType(method.ReturnType),
                ValueParams: valparams,
                TypeParams: typeparams);
        }

        MethodSig(int MethodId, string DefiningAssembly, string DefiningModule,
            TypeSig DeclaringType, string MethodName, TypeSig ReturnType, MethodParameters ValueParams, TypeParameters TypeParams)
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

        public TypeSig DeclaringType {get;}

        public TypeSig ReturnType {get; }

        public MethodParameters ValueParams {get; }

        public TypeParameters TypeParams {get; }
                
        public string Format()
        {
            var sigtext = text.factory.Builder();            
            sigtext.Append(ReturnType.Format());
            sigtext.Append(AsciSym.Space);
            sigtext.Append(MethodName);
            sigtext.Append(ValueParams.Format(true));
            return sigtext.ToString();            
        }

        public override string ToString()
            => Format();

        /// <summary>
        /// Describes a method's type parameters, if any
        /// </summary>
        /// <param name="method">The method to examine</param>
        static TypeParameter[] TypeParameters(MethodInfo method)
            => method.GenericParameters(false).Mapi((i,t) => TypeParameter.Define(t.DisplayName(), i, t.IsGenericType));
    }
}