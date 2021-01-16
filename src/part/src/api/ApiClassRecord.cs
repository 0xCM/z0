//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines an api partition element that classifies a set of related operations
    /// </summary>
    public struct ApiClassRecord
    {
        /// <summary>
        /// A number that identifies the represented class
        /// </summary>
        public ushort ClassKey;

        /// <summary>
        /// A name that identifies the represented class
        /// </summary>
        public Name ClassName;

        /// <summary>
        /// The meaning of the class
        /// </summary>
        public TextBlock Description;
    }

    /// <summary>
    /// Specifies the global api equivalence class
    /// </summary>
    public readonly struct ApiKlass
    {
        /// <summary>
        /// The partition elements
        /// </summary>
        public Index<ApiClassRecord> Classes {get;}

        [MethodImpl(Inline)]
        public ApiKlass(ApiClassRecord[] classes)
        {
            Classes = classes;
        }

        /// <summary>
        /// The classifier id's
        /// </summary>
        [MethodImpl(Inline)]
        public Index<ushort> Keys()
            => Classes.Select(c => c.ClassKey);

        /// <summary>
        /// The classifier names
        /// </summary>
        public Index<Name> Names()
            => Classes.Select(c => c.ClassName);

        [MethodImpl(Inline)]
        public KeyedValues<ushort,Name> KeyedNames()
            => Classes.Select(c => root.kvp(c.ClassKey, c.ClassName));
    }
}