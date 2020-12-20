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

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes a model of a CLR type during runtime
    /// </summary>
    [Free]
    public interface IClrRuntimeType : IClrRuntimeObject, IClrRuntimeObject<Type>
    {
        ClrTypeKind TypeKind
            => Definition.Kind();

        ClrArtifactKind IClrRuntimeObject.ClrKind
            => (ClrArtifactKind)TypeKind;

        /// <summary>
        /// Models of the types nested within the subject, if any
        /// </summary>
        IEnumerable<IClrRuntimeType> NestedTypes
            => z.stream<IClrRuntimeType>();

        CliKey IClrRuntimeObject.Token
            => Definition.MetadataToken;
    }

    [Free]
    public interface IClrRuntimeType<T> : IClrRuntimeType
    {
        new IEnumerable<T> NestedTypes
            => z.stream<T>();

        IEnumerable<IClrRuntimeType> IClrRuntimeType.NestedTypes
            => NestedTypes.Cast<IClrRuntimeType>();
    }
}