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

    [DataType]
    public readonly struct Labeled : ILabeled<Labeled>
    {
        /// <summary>
        /// Returns the a target label, if attributed; otherwise, returns the target's system-defined name
        /// </summary>
        /// <typeparam name="T">The label target</typeparam>
        [MethodImpl(Inline)]
        public static Labeled from(MemberInfo src)
        {
             var attrib = src.GetCustomAttribute<LabelAttribute>();
             return attrib is null ? src.Name : attrib.Label;
        }

        /// <summary>
        /// Returns the label of a parametric type, if attributed; otherwise, returns the type's name
        /// </summary>
        /// <typeparam name="T">The label target</typeparam>
        [MethodImpl(Inline)]
        public static Labeled from<T>()
            => from(typeof(T));

        public string Label {get;}

        [MethodImpl(Inline)]
        public Labeled(string label)
            => Label = label;

        [MethodImpl(Inline)]
        public static implicit operator string(Labeled src)
            => src.Label;

        [MethodImpl(Inline)]
        public static implicit operator Labeled(string src)
            => new Labeled(src);
    }
}