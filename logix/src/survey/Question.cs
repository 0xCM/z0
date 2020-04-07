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
    
    using static root;

    /// <summary>
    /// Defines a question in the context of a survey
    /// </summary>
    /// <typeparam name="T">The primal survey representation type</typeparam>
    public class Question<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public Question(uint Id, string statement, int? MaxSelect, params QuestionChoice<T>[] choices)
        {
            this.Id = Id;
            this.Label = statement;
            this.MaxSelect = MaxSelect ?? choices.Length;
            this.Choices = choices;
        }

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
        public IReadOnlyList<QuestionChoice<T>> Choices {get;}

        public bool MultipleChoice 
            => MaxSelect > 1;

        public string Title
            => $"{Id} - {Label}";

        public string Format()
        {
            var format = text.build();
            format.Append(Label.PadRight(12));
            format.Append(Chars.Colon);
            format.Append(Chars.Space);
            format.Append(Chars.LBracket);
            format.Append(string.Join(MultipleChoice ? Chars.Pipe : Chars.Caret, Choices.Select(c => c.Format())));
            format.Append(Chars.RBracket);
            return format.ToString();
        }

        public override string ToString()
            => Title;
    }

}