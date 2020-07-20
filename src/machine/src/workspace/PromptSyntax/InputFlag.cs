//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using api = PromptSyntax;

    public readonly struct InputFlag
    {
        /// <summary>
        /// Uniquely identifies the flag (which may have synonyms)
        /// </summary>
        public readonly StringRef FlagIdentifier;

        /// <summary>
        /// Expression which signals that a switch begins immediately thereafter
        /// </summary>
        public readonly StringRef FlagMarker;

        [MethodImpl(Inline)]
        public InputFlag(string identifier, string marker)
        {
            FlagIdentifier = identifier;
            FlagMarker = marker;
        }
        
        [MethodImpl(Inline)]
        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();
    }
}