//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct InputParameter
    {
        public static InputParameter at_position(string identifier, int position)
            => new InputParameter(identifier).at_position(position);

        public InputParameter(string identifier)
        {
            this.identifier = identifier;
            this.parameter_marker = EmptyString;
            this.argument_marker = EmptyString;
            this.argument_qualifier = EmptyString;
            this.named = false;
            this.position = default;
        }

        public InputParameter(string identifier, 
            string parameter_marker = "/", 
            string argument_marker = ":", 
            string argument_qualifier = "\"",
            bool named = true,
            int? position = null
            )
        {
            this.identifier = identifier;
            this.parameter_marker = parameter_marker;
            this.argument_marker = argument_marker;
            this.argument_qualifier = argument_qualifier;
            this.named = named;
            this.position = position;
        }

        /// <summary>
        /// Uniquely identifies the parameter (which may have synonyms)
        /// </summary>
        public string identifier { get; set; }

        /// <summary>
        /// Expression which signals that a parameter begins immediately thereafter
        /// </summary>
        public string parameter_marker { get; set; }

        /// <summary>
        /// Expression that terminates parameter designation and immediatly precedes
        /// argument specification
        /// </summary>
        public string argument_marker { get; set; }

        /// <summary>
        /// Expression that bounds argument value content when needed
        /// </summary>
        public string argument_qualifier { get; set; }

        public bool named { get; set; }

        public int? position { get; set; }

        public InputParameter at_position(int position)
            => new InputParameter(identifier,
                    parameter_marker: parameter_marker,
                    argument_marker: argument_marker,
                    argument_qualifier: argument_qualifier,
                    named: named,
                    position: position
                );

        public string Format()
            => $"{parameter_marker}{identifier}{argument_marker}{argument_qualifier}arg_value{argument_qualifier}";
        
        public override string ToString()
            => Format();

        public static InputParameter Empty
            => new InputParameter(EmptyString, EmptyString, EmptyString, EmptyString, false, null );
    }
}