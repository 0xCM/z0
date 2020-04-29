//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    /// <summary>
    /// Defines a question in the context of a survey
    /// </summary>
    /// <typeparam name="T">The primal survey representation type</typeparam>
    public readonly struct Question<T> : IFormattable<Question<T>>
        where T : unmanaged
    {
        /// <summary>
        /// Uniquely identifies a question relative to a survey
        /// </summary>
        public uint Id {get;}

        /// <summary>
        /// The question statement
        /// </summary>
        public string Label {get;}

        /// <summary>
        /// The maximum number of choices allowed for a response, between 0 and the number of available choices
        /// </summary>
        public int MaxSelect {get;}

        /// <summary>
        /// The potiential choices/answers 
        /// </summary>
        public QuestionChoice<T>[] Choices {get;}

        [MethodImpl(Inline)]
        public Question(uint Id, string statement, int? MaxSelect, params QuestionChoice<T>[] choices)
        {
            this.Id = Id;
            this.Label = statement;
            this.MaxSelect = MaxSelect ?? choices.Length;
            this.Choices = choices;
        }

        public bool MultipleChoice 
            => MaxSelect > 1;

        public string Title
            => $"{Id} - {Label}";

        public string Format()
            => Survey.Format(this);

        public override string ToString()
            => Title;
    }
}