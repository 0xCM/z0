//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using static zfunc;

    /// <summary>
    /// Chooses a question based on prior answer
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SurveyBranch<T>
        where T : unmanaged
    {
        
    }

    public class QuestionChoice<T> 
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public QuestionChoice(T Id, string Label)
        {
            this.Id = Id;
            this.Label = Label;
        }
        
        /// <summary>
        /// Uniquely identifies a choice relative to a question
        /// </summary>
        public T Id {get;}
        
        /// <summary>
        /// The meaning of the choice
        /// </summary>
        public string Label {get;}

        public string Title
            => $"{gmath.log2(Id)}: {Label}";
         
        public string Format()
            => parenthetical($"{gmath.log2(Id)}, {Label}");

        public override string ToString()
            => Title;
    }

    public class Question<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public Question(uint Id, string Label, int? MaxSelect, params QuestionChoice<T>[] choices)
        {
            this.Id = Id;
            this.Label = Label;
            this.MaxSelect = MaxSelect ?? choices.Length;
            this.Choices = choices;
        }


        /// <summary>
        /// Uniquely identifies a question relative to a survey
        /// </summary>
        public uint Id {get;}

        /// <summary>
        /// The meaning of the question
        /// </summary>
        public string Label {get;}

        public int MaxSelect {get;}

        public bool MultipleChoice 
            => MaxSelect > 1;

        public string Title
            => $"{Id} - {Label}";

        public IReadOnlyList<QuestionChoice<T>> Choices {get;}

        public string Format()
        {
            var format = sbuild();
            format.Append(Label.PadRight(12));
            format.Append(AsciSym.Colon);
            format.Append(AsciSym.Space);
            format.Append(AsciSym.LBracket);
            format.Append(string.Join(MultipleChoice ? AsciSym.Pipe : AsciSym.Caret, Choices.Select(c => c.Format())));
            format.Append(AsciSym.RBracket);
            return format.ToString();
        }

        public override string ToString()
            => Title;
    }
    
    public class Survey<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public Survey(uint Id, string Label, params Question<T>[] Questions)
        {
            this.Id = Id;
            this.Label = Label;
            this.Questions = Questions;
        }

        public uint Id {get;}

        public string Label {get;}

        public string Title
            => Label;

        public IReadOnlyList<Question<T>> Questions {get;}

        public string Format()
        {
            var format = sbuild();
            format.AppendLine(Title);
            format.AppendLine(new string(AsciSym.Minus,80));
            Questions.Iterate(q => format.AppendLine(q.Format()));
            return format.ToString();
        }

        public override string ToString()
            => Title;


        
    }


}