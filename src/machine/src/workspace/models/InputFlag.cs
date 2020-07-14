//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct InputFlag
    {
        [MethodImpl(Inline)]
        public InputFlag(string flag_identifier, string flag_marker = "/")
        {
            this.flag_identifier = flag_identifier;
            this.flag_marker = flag_marker;
        }

        /// <summary>
        /// Uniquely identifies the flag (which may have synonyms)
        /// </summary>
        public string flag_identifier {get;}

        /// <summary>
        /// Expression which signals that a switch begins immediately thereafter
        /// </summary>
        public string flag_marker {get;}

        public string Format()
            => $"{flag_marker}{flag_identifier}";

        public override string ToString()
            => Format();
    }
}