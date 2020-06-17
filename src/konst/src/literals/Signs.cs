//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Defines polarity classifiers
    /// </summary>
    /// <remaks>
    /// Here, polarity is defined to be an optional choice between exactly one of two values
    /// Note that an <see cref="Orientation" /> can be viewed as a required choice of sign
    /// Or, a sign can be viwed as a subsumption of orientation sans duality
    /// This construct also fills in the need for sign in a mathematical sense:
    /// It defines a partition over any (real) number r: r is exactly one of: Negative (r < 0), 
    /// Positive (r > 0) or Neutral (r = 0)
    /// </remaks>
    public enum SignKind : sbyte
    {        
        /// <summary>
        /// Specifies negative polarity and can be interpreted as mathematical sign
        /// </summary>
        Negative = -1,
        
        /// <summary>
        /// Specifies neutral polarity and from a mathemtatical perspectives gives 
        /// a sign classification to the number 0.
        /// </summary>
        Neutral = 0,
            
        /// <summary>
        /// Specifies positive polarity and can be interpreted as mathematical sign
        /// </summary>
        Positive = 1
    }

    /// <summary>
    /// Characterizes a type-level sign classifier
    /// </summary>
    public interface ISign
    {
        /// <summary>
        /// Specifies the literal classifier the type-level classifier represents
        /// </summary>
        SignKind Kind {get;}
    }
    
    /// <summary>
    /// Characterizes an F-bound polymorphic type-level sign classifier reification
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    public interface ISign<F> : ISign
        where F : unmanaged, ISign
    {

    }

    /// <summary>
    /// Characterizes an F-bound polymorphic and S-parametric sign classifier reification
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    /// <typeparam name="S">The sign classifier type</typeparam>
    public interface ISign<F,S> : ISign<S>
        where S : unmanaged, ISign
        where F : unmanaged, ISign<F,S>
    {

    }

    /// <summary>
    /// Characterizes an F-bound polymorphic S/T-parametric sign classifier reification
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    /// <typeparam name="S">The sign classifier type</typeparam>
    /// <typeparam name="T">The T-carrier, of any sort</typeparam>
    public interface ISign<F,S,T> : ISign<F,S>
        where S : unmanaged, ISign
        where F : unmanaged, ISign<F,S,T>
    {
        /// <summary>
        /// Reveals the singleton instance of the T-parametric classifier
        /// </summary>
        S SignType 
            => default;

        /// <summary>
        /// Default implementation of <see cref="ISign.Kind"/>
        /// </summary>
        SignKind ISign.Kind 
            => SignType.Kind;
    }

    /// <summary>
    /// Promotes the literal classifier <See cref="SignKind.Neutral"/> to a type
    /// </summary>
    public readonly struct Neutral : ISign<Neutral>
    {
        /// <summary>
        /// Reveals the represented literal
        /// </summary>
        public SignKind Kind 
            => SignKind.Neutral;
    }

    /// <summary>
    /// Promotes the literal classifier <See cref="SignKind.Negative"/> to a type
    /// </summary>
    public readonly struct Negative : ISign<Negative>
    {
        /// <summary>
        /// Reveals the represented literal
        /// </summary>
        public SignKind Kind 
            => SignKind.Negative;
    }

    /// <summary>
    /// Promotes the literal classifier <See cref="SignKind.Positive"/> to a type
    /// </summary>
    public readonly struct Positive : ISign<Positive>
    {
        /// <summary>
        /// Reveals the represented literal
        /// </summary>
        public SignKind Kind 
            => SignKind.Positive;
    }

    /// <summary>
    /// Captures an S-parametric sign classifier via parametricity
    /// </summary>
    /// <remarks>
    /// The member implementations are redundant with those provided by the default interface implementations;
    /// however, accessing these implementations requires a boxing conversion along with polymorphic
    /// dispatch. Though these implementations are useful in generalized contexts, they are not useful for emulating type-level
    /// features in a language that does not support dependent types
    /// </remarks>
    public readonly struct Sign<S> : ISign<Sign<S>,S>
        where S : unmanaged, ISign<S>
    {
        /// <summary>
        /// Reveals the type-level classifier
        /// </summary>
        public static S SignType 
            => default;
        
        /// <summary>
        /// Reveals the literal represented by the type-level classifier
        /// </summary>
        /// <remarks>
        /// The implementation is redundant with that provided by the default interface implementation;
        /// however, accessing that implementation requires a boxing conversion along with polymorphic
        /// dispatch
        /// </remarks>
        public SignKind Kind 
            => SignType.Kind;
    }

    /// <summary>
    /// Defines a T-parametric <See cref="SignKind.Negative"/> literal classifer promotion
    /// </summary>
    public readonly struct Negative<T> : ISign<Negative<T>,Negative,T>
    {
        /// <summary>
        /// Reveals the singleton instance of the nonparametric classifier
        /// </summary>
        public Negative SignType 
            => default;

        /// <summary>
        /// Reveals the represented literal
        /// </summary>
        public SignKind Kind 
            => SignType.Kind;
    }

    /// <summary>
    /// Defines a T-parametric <See cref="SignKind.Negative"/> literal classifer promotion
    /// </summary>
    public readonly struct Neutral<T> : ISign<Neutral<T>,Neutral,T>
    {
        /// <summary>
        /// Reveals the singleton instance of the nonparametric classifier
        /// </summary>
        public Neutral SignType 
            => default;

        /// <summary>
        /// Reveals the represented literal
        /// </summary>
        public SignKind Kind 
            => SignType.Kind;
    }
    
    /// <summary>
    /// Defines a T-parametric <See cref="SignKind.Negative"/> literal classifer promotion
    /// </summary>
    public readonly struct Positive<T> : ISign<Positive<T>,Positive,T>
    {
        /// <summary>
        /// Reveals the singleton instance of the nonparametric classifier
        /// </summary>
        public Positive SignType 
            => default;

        /// <summary>
        /// Reveals the represented literal
        /// </summary>
        public SignKind Kind 
            => SignType.Kind;
    }


    /// <summary>
    /// Captures an S/T-parametric sign classifier via parametricity
    /// </summary>
    public readonly struct Sign<S,T> : ISign<Sign<S,T>,S,T>
        where S : unmanaged, ISign<S>
    {

    }    

    /// <summary>
    /// Defines type-level sign classifier accessors/factories
    /// </summary>
    public readonly struct Signs
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
            where S : unmanaged, ISign<S>
                => default;   

        /// <summary>
        /// Reveals the literal represented by a parametrically-identified classifier
        /// </summary>
        /// <param name="s">The sign classifier, used only for type inference</param>
        /// <typeparam name="S">The choice type: Negative, Neutral or Positive</typeparam>
        public static SignKind kind<S>(S s = default)     
            where S : unmanaged, ISign
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