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

    public struct InputParameter
    {
        /// <summary>
        /// Uniquely identifies the parameter (which may have synonyms)
        /// </summary>
        public readonly StringRef Identifier;

        public readonly InputMarkers Markers;

        public readonly bool Named;

        public readonly byte Position;

        [MethodImpl(Inline)]
        public InputParameter(string identifier, byte position)
        {
            Identifier = identifier;
            Markers = InputMarkers.Default;
            Named = false;
            Position = position;
        }

        [MethodImpl(Inline)]
        public InputParameter(string identifier, in InputMarkers markers, bool named = true, byte position = 0)
        {
            Identifier = identifier;
            Markers = markers;
            Named = named;
            Position = position;
        }

        [MethodImpl(Inline)]
        public string Format()
            => api.format(this);
        
        public override string ToString()
            => Format();

        public static InputParameter Empty
            => new InputParameter(EmptyString, InputMarkers.Default);
    }
}