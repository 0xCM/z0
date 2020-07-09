//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    /// <summary>
    /// Identifies and describes a method that, whithin some useful scope, is unique
    /// </summary>
    public readonly struct MethodSig
    {
        public readonly int MethodId;
        
        public readonly string MethodName;

        public readonly string DefiningAssembly;

        public readonly string DefiningModule;

        public readonly TypeSig DeclaringType;

        public readonly TypeSig ReturnType;

        public readonly MethodParameters Args;

        public readonly TypeParameters TypeParams;

        public static MethodSig define(MethodInfo method)                    
            => new MethodSig(
                MethodId: method.MetadataToken,
                DefiningAssembly: method.Module.Assembly.GetSimpleName(),
                DefiningModule: method.Module.Name,
                DeclaringType: TypeSig.FromType(method.DeclaringType),
                MethodName: method.DisplayName(),
                ReturnType: TypeSig.FromType(method.ReturnType),
                Args: method.GetParameters().Select(p => new MethodParameter(TypeSig.FromParameter(p), p.ReferenceKind(), p.Name, p.Position)),
                TypeParams: TypeParameters(method));
        
        MethodSig(
            int MethodId, 
            string DefiningAssembly, 
            string DefiningModule, 
            TypeSig DeclaringType, 
            string MethodName, 
            TypeSig ReturnType, 
            MethodParameters Args, 
            TypeParameters TypeParams
            )
        {
            this.MethodId = MethodId;
            this.DefiningAssembly = DefiningAssembly;
            this.DefiningModule = DefiningModule;
            this.DeclaringType = DeclaringType;
            this.MethodName = MethodName;
            this.ReturnType = ReturnType;
            this.Args = Args;
            this.TypeParams = TypeParams;
        }
        
                
        public string Format()
        {
            var sigtext = new StringBuilder();
            sigtext.Append(ReturnType.Format());
            sigtext.Append(Chars.Space);
            sigtext.Append(MethodName);
            sigtext.Append(Args.Format());
            return sigtext.ToString();            
        }

        public override string ToString()
            => Format();

        /// <summary>
        /// Describes a method's type parameters, if any
        /// </summary>
        /// <param name="method">The method to examine</param>
        static TypeParameter[] TypeParameters(MethodInfo method)
            => method.GenericParameters(false).Mapi((i,t) => new TypeParameter(t.DisplayName(), i));
    }
}