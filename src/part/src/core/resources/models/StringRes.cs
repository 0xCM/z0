//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Describes/models a literal text resource
    /// </summary>
    public struct StringRes : ITextual
    {
        const string RenderPattern = "{0,-10} | {1,-16} | {2}";

        /// <summary>
        /// The resource identifier
        /// </summary>
        public FieldInfo Source;

        /// <summary>
        /// The resource address
        /// </summary>
        public StringAddress Address;

        /// <summary>
        /// The resource value extracted from the accompanying location
        /// </summary>
        public string Value;

        [MethodImpl(Inline)]
        public StringRes(FieldInfo src, StringAddress address, string value)
        {
            Source = src;
            Address = address;
            Value = value;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Address.Format();
    }
}