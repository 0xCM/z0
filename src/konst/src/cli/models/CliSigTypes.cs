//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface ICliSig<T>
        where T : struct, ICliSig<T>
    {
        CliSigKind Kind {get;}
    }

    public readonly struct CliSigTypes
    {
        public readonly struct MethodDef : ICliSig<MethodDef>
        {
            public CliSigKind Kind => CliSigKind.MethodDef;
        }

        public readonly struct MethodRef : ICliSig<MethodRef>
        {
            public CliSigKind Kind => CliSigKind.MethodRef;
        }

        public readonly struct StandAloneMethod : ICliSig<StandAloneMethod>
        {
            public CliSigKind Kind => CliSigKind.StandAloneMethod;
        }

        public readonly struct Field : ICliSig<Field>
        {
            public CliSigKind Kind => CliSigKind.Field;
        }

        public readonly struct Property : ICliSig<Property>
        {
            public CliSigKind Kind => CliSigKind.Property;
        }

        public readonly struct LocalVar : ICliSig<LocalVar>
        {
            public CliSigKind Kind => CliSigKind.LocalVar;
        }
    }
}