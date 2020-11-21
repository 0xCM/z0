//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using api = Tooling;

    /// <summary>
    /// Defines a tool option
    /// </summary>
    public readonly struct CmdOption : ICmdOption
    {
        internal const string AnonymousOptionName = "_anonymous_";

        /// <summary>
        /// The option name
        /// </summary>
        public string Name {get;}

        /// <summary>
        /// The option's use
        /// </summary>
        public string Purpose {get;}

        [MethodImpl(Inline)]
        public CmdOption(string name)
        {
            Name = name;
            Purpose = EmptyString;
        }

        [MethodImpl(Inline)]
        public CmdOption(string name, string purpose)
        {
            Name = name;
            Purpose = purpose;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => text.empty(Name);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => text.nonempty(Name);
        }

        public bool IsAnonymous
        {
            [MethodImpl(Inline)]
            get => string.Equals(Name, AnonymousOptionName);
        }

        [MethodImpl(Inline)]
        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator CmdOption(string src)
            => new CmdOption(src);

        public static CmdOption Empty
        {
            [MethodImpl(Inline)]
            get => new CmdOption(EmptyString);
        }
    }
}