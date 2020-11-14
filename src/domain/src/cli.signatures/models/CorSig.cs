//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public enum CorSigKind : byte
    {
        Default = 0,

        MethodDef,

        MethodRef,

        StandAloneMethod,

        Field,

        Property,

        LocalVar
    }

    public interface ICorSig<T>
        where T : struct, ICorSig<T>
    {
        CorSigKind Kind {get;}
    }

    public readonly struct CorSig
    {
        public readonly struct MethodDef : ICorSig<MethodDef>
        {
            public CorSigKind Kind => CorSigKind.MethodDef;
        }

        public readonly struct MethodRef : ICorSig<MethodRef>
        {
            public CorSigKind Kind => CorSigKind.MethodRef;
        }

        public readonly struct StandAloneMethod : ICorSig<StandAloneMethod>
        {
            public CorSigKind Kind => CorSigKind.StandAloneMethod;
        }

        public readonly struct Field : ICorSig<Field>
        {
            public CorSigKind Kind => CorSigKind.Field;
        }


        public readonly struct Property : ICorSig<Property>
        {
            public CorSigKind Kind => CorSigKind.Property;
        }

        public readonly struct LocalVar : ICorSig<LocalVar>
        {
            public CorSigKind Kind => CorSigKind.LocalVar;
        }
    }
}