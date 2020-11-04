//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;
    using static z;


    public static partial class XTend
    {
        /// <summary>
        /// Transforms a bitstring into a literal logic sequence
        /// </summary>
        /// <param name="bs">The source bitstring</param>
        public static LiteralLogicSeqExpr ToLogicSeq(this BitString bs)
        {
            var terms = new Bit32[bs.Length];
            for(var i=0; i<terms.Length; i++)
                terms[i] = bs[i];
            return new LiteralLogicSeqExpr(terms);
        }

        /// <summary>
        /// Transforms a bitstring into a literal logic sequence of natural length
        /// </summary>
        /// <param name="bs">The source bitstring</param>
        /// <typeparam name="N">The length type</typeparam>
        [MethodImpl(Inline)]
        public static LiteralLogicSeqExpr<N> ToLogicSeq<N>(this BitString src, N n = default)
            where N : unmanaged, ITypeNat
        {
            z.insist<N>(src.Length);
            return new LiteralLogicSeqExpr<N>(src.ToLogicSeq().Terms);
        }

    }

    public class Survey
    {
        public static QuestionResponse<T> Respond<T>(in Question<T> question, IPolyrand random)
            where T : unmanaged
        {
            var count = question.Choices.Length;
            var index = random.Next(0,count);
            var chosen = question.Choices[index];
            return SurveyBuilder.response(question.QuestionId, chosen);
        }

        public static SurveyResponse<T> Respond<T>(in Survey<T> survey, IPolyrand random)
            where T : unmanaged
        {
            var answered = new QuestionResponse<T>[survey.Questions.Length];
            for(var i=0; i<answered.Length; i++)
                answered[i] = Respond(survey.Questions[i], random);
            return new SurveyResponse<T>(survey.SurveyId, answered);
        }

        /// <summary>
        /// Creates a bitvector representation of a question
        /// </summary>
        /// <param name="src">The question upon which the bitvector will be predicated</param>
        /// <typeparam name="T">The primal data type used for survey aspect representation</typeparam>
        public static BitVector<T> Vector<T>(in Question<T> src)
            where T : unmanaged
        {
            var data = default(T);
            foreach(var choice in src.Choices)
                data = gmath.or(data, choice.ChoiceId);
            return data;
        }

        /// <summary>
        /// Creates a bitvector representation of a question response
        /// </summary>
        /// <param name="src">The response upon which the bitvector will be predicated</param>
        /// <typeparam name="T">The primal data type used for survey aspect representation</typeparam>
        public static BitVector<T> Vector<T>(in QuestionResponse<T> src)
            where T : unmanaged
        {
            var data = default(T);
            foreach(var choice in src.Chosen)
                data = gmath.or(data, choice.ChoiceId);
            return data;
        }

        /// <summary>
        /// Creates a bitmatrix representation of a survey response
        /// </summary>
        /// <param name="src">The survey upon which the matrix will be predicated</param>
        /// <typeparam name="T">The primal data type used for survey aspect representation</typeparam>
        public static BitMatrix<T> Matrix<T>(in SurveyResponse<T> src)
            where T : unmanaged
        {
            var rowcount = src.Answered.Length;
            var maxrows = bitsize<T>();
            if(rowcount > maxrows)
                throw new Exception($"Too many rows for a primal bitmatrix");

            var dst = BitMatrix.alloc<T>();
            for(var i=0; i< rowcount; i++)
                dst[i] = Vector(src.Answered[i]);
            return dst;
        }

        /// <summary>
        /// Creates a bitmatrix representation of a survey
        /// </summary>
        /// <param name="src">The survey upon which the matrix will be predicated</param>
        /// <typeparam name="T">The primal data type used for survey aspect representation</typeparam>
        public static BitMatrix<T> Matrix<T>(in Survey<T> src)
            where T : unmanaged
        {
            var rowcount = src.Questions.Length;
            var maxrows = bitsize<T>();
            if(rowcount > maxrows)
                throw new Exception($"Too many rows for a primal bitmatrix");

            var dst = BitMatrix.alloc<T>();
            for(var i=0; i< rowcount; i++)
                dst[i] = Vector(src.Questions[i]);
            return dst;
        }

        public static RowBits<T> Rows<T>(in Survey<T> src)
            where T : unmanaged
        {
            var rowcount = src.Questions.Length;
            var dst = RowBits.alloc<T>(rowcount);
            for(var i=0; i< rowcount; i++)
                dst[i] = Vector(src.Questions[i]);
            return dst;
        }

        public static RowBits<T> Rows<T>(in SurveyResponse<T> src)
            where T : unmanaged
        {
            var rowcount = src.Answered.Length;
            var dst = RowBits.alloc<T>(rowcount);
            for(var i=0; i< rowcount; i++)
                dst[i] = Vector(src.Answered[i]);
            return dst;
        }
    }
}