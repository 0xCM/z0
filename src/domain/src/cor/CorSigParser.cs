//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using CC = Cor.CorUnmanagedCallingConvention;
    using CCM = Cor.CorCallingConvention;

    /// <summary>
    /// Defines a CLI signature parser
    /// </summary>
    /// <remarks>
    /// [CliSpec, II.23.2] The value of the first byte of a Signature 'blob' indicates what kind of Signature it is. Its lowest 4 bits hold one of the following:
    /// <see cref='CC.IMAGE_CEE_CS_CALLCONV_C'/>
    /// <see cref='CCM.IMAGE_CEE_CS_CALLCONV_DEFAULT'/>
    /// <see cref='CC.IMAGE_CEE_UNMANAGED_CALLCONV_FASTCALL'/>
    /// <see cref='CC.IMAGE_CEE_CS_CALLCONV_STDCALL'/>
    /// <see cref='CC.IMAGE_CEE_CS_CALLCONV_THISCALL'/>
    /// <see cref='CCM.IMAGE_CEE_CS_CALLCONV_VARARG'/>
    /// </remarks>
    public abstract class CorSigParser
    {
        /// <summary>
        /// Parses a method signature without VARARG
        /// </summary>
        public sealed class MethodDef : ClrSigParser<MethodDef>
        {
            public override CorSigKind Kind => CorSigKind.MethodDef;
        }

        /// <summary>
        /// Parses a method signature with VARARG calls
        /// </summary>
        public sealed class MethodRef : ClrSigParser<MethodRef>
        {
            public override CorSigKind Kind => CorSigKind.MethodRef;

        }

        public sealed class StandAloneMethod : ClrSigParser<StandAloneMethod>
        {

            public override CorSigKind Kind  => CorSigKind.StandAloneMethod;

        }

        public sealed class Field : ClrSigParser<Field>
        {
            public override CorSigKind Kind => CorSigKind.Field;
        }

        public sealed class Property : ClrSigParser<Property>
        {

            public override CorSigKind Kind => CorSigKind.Property;

        }

        public sealed class LocalVar : ClrSigParser<LocalVar>
        {

            public override CorSigKind Kind => CorSigKind.LocalVar;
        }
    }

    public abstract class ClrSigParser<T> : CorSigParser
        where T : ClrSigParser<T>, new()
    {
        public abstract CorSigKind Kind {get;}
    }

}