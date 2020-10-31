//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static Konst;

    /// <summary>
    /// Identifies and describes a method that, whithin some useful scope, is unique
    /// </summary>
    public struct MethodSig : ITextual
    {
        public ClrArtifactKey MethodId;

        public Name MethodName;

        public Name DefiningAssembly;

        public Name DefiningModule;

        public TypeSig DeclaringType;

        public TypeSig ReturnType;

        public MethodParameters ValueParams;

        public TypeParameters TypeParams;

        public MethodSig(
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
            this.ValueParams = Args;
            this.TypeParams = TypeParams;
        }

        public string Format()
            => ClrQuery.format(this);

        public override string ToString()
            => Format();
    }
}