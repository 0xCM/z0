//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class Kinds
    {
        /// <summary>
        /// Specifies the singleton instance of the <see cref="Z0.Negative"/> type-level classifier
        /// </summary>
        public static Negative Negative => default;

        /// <summary>
        /// Specifies the singleton instance of the <see cref="Z0.Neutral"/> type-level classifier
        /// </summary>
        public static Neutral Neutral => default;

        /// <summary>
        /// Specifies the singleton instance of the <see cref="Z0.Positive"/> type-level classifier
        /// </summary>
        public static Positive Positive => default;

        /// <summary>
        /// Closes the S-parametric sign classifier over a particular sign choice
        /// </summary>
        /// <param name="s">The sign choice, used only for type inference</param>
        /// <typeparam name="S">The choice type: Negative, Neutral or Positive</typeparam>
        public static Sign<S> sign<S>(S s = default)
            where S : unmanaged, ISigned<S>
                => default;

        /// <summary>
        /// Reveals the literal represented by a parametrically-identified classifier
        /// </summary>
        /// <param name="s">The sign classifier, used only for type inference</param>
        /// <typeparam name="S">The choice type: Negative, Neutral or Positive</typeparam>
        public static SignKind kind<S>(S s = default)
            where S : unmanaged, ISigned
                => s.Kind;

        /// <summary>
        /// Closes the S/T-parametric sign classifier over the <see cref="Z0.Neutral"/> with a specified T-choice
        /// </summary>
        /// <param name="t">A T-choice representative, used only for type inference</param>
        /// <typeparam name="T">Any type</typeparam>
        public static Sign<Neutral,T> neutral<T>(T t = default)
            => default;

        /// <summary>
        /// Closes the S/T-parametric sign classifier over the <see cref="Z0.Neutral"/> with a specified T-choice
        /// </summary>
        /// <param name="t">A T-choice representative, used only for type inference</param>
        /// <typeparam name="T">Any type</typeparam>
        public static Sign<Negative,T> negative<T>(T t = default)
            => default;

        /// <summary>
        /// Closes the S/T-parametric sign classifier over the <see cref="Z0.Positive"/> with a specified T-choice
        /// </summary>
        /// <param name="t">A T-choice representative, used only for type inference</param>
        /// <typeparam name="T">Any type</typeparam>
        public static Sign<Positive,T> positive<T>(T t = default)
            => default;
    }
}