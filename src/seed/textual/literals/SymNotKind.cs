//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    /// <summary>
    /// Defines symbols that aren't symbols
    /// </summary>
    public enum SymNotKind : ushort
    {
        /// <summary>
        /// ᙿ
        /// </summary>
        Eq = 'ᙿ',
        
        /// <summary>
        /// Eq
        /// </summary>
        ᙿ = Eq,

        /// <summary>
        /// ᐳ
        /// </summary>
        Gt = 'ᐳ',

        /// <summary>
        /// Gt
        /// </summary>
        ᐳ = Gt,

        /// <summary>
        /// ᐸ
        /// </summary>
        Lt = 'ᐸ',

        /// <summary>
        /// Lt
        /// </summary>
        ᐸ = Lt,

        /// <summary>
        /// Λ
        /// </summary>
        And = 'Λ',

        /// <summary>
        /// And
        /// </summary>
        Λ = And,

        /// <summary>
        /// Ʌ
        /// </summary>
        SmallAnd = 'Ʌ',
        
        /// <summary>
        /// SmallAnd
        /// </summary>
        Ʌ = SmallAnd,

        /// <summary>
        /// V
        /// </summary>
        Or = 'V',
        
        /// <summary>
        /// Or
        /// </summary>
        V = Or,

        /// <summary>
        /// ተ
        /// </summary>
        Dagger = 'ተ',

        /// <summary>
        /// Dagger
        /// </summary>
        ተ = Dagger,

        /// <summary>
        /// ᕀ
        /// </summary>
        Plus = 'ᕀ',

        /// <summary>
        /// Plus
        /// </summary>
        ᕀ = Plus,

        /// <summary>
        /// ᛡ
        /// </summary>
        Star = 'ᛡ',

        /// <summary>
        /// Star
        /// </summary>
        ᛡ = Star,

        /// <summary>
        /// ᐟ
        /// </summary>
        Tick = 'ᐟ',

        /// <summary>
        /// Tick
        /// </summary>
        ᐟ = Tick,

        /// <summary>
        /// ヽ
        /// </summary>
        LeftTick = 'ヽ',
        
        /// <summary>
        /// LeftTick
        /// </summary>
        ヽ = LeftTick,

        /// <summary>
        /// ー
        /// </summary>
        Dash = 'ー',

        /// <summary>
        /// Dash
        /// </summary>
        ー = Dash,

        /// <summary>
        /// ｰ
        /// </summary>
        HalfDash = 'ｰ',

        /// <summary>
        /// HalfDash
        /// </summary>
        ｰ = HalfDash,
        
        /// <summary>
        /// ᐨ
        /// </summary>
        UpperDash = 'ᐨ',

        /// <summary>
        /// UpperDash
        /// </summary>
        ᐨ = UpperDash,
        
        /// <summary>
        /// ㆍ
        /// </summary>
        Dot = 'ㆍ',

        /// <summary>
        /// Dot
        /// </summary>
        ㆍ = Dot,

        SQuote = 'ᑊ',

        /// <summary>
        /// SQuote
        /// </summary>
        ᑊ = SQuote,

        DQuote = 'ʺ',

        /// <summary>
        /// DQuote
        /// </summary>
        ʺ = DQuote,

        /// <summary>
        /// ᐤ
        /// </summary>
        Circle = 'ᐤ',

        /// <summary>
        /// Circle
        /// </summary>
        ᐤ = Circle,

        /// <summary>
        /// ᙾ
        /// </summary>
        HashExp = 'ᙾ',

        /// <summary>
        /// HashExp
        /// </summary>
        ᙾ = HashExp,

        /// <summary>
        /// ノ'
        /// </summary>
        FSlash = 'ノ',

        /// <summary>
        /// FSlash
        /// </summary>
        ノ = FSlash,

        /// <summary>
        /// ﾉ
        /// </summary>
        FSlashSmall = 'ﾉ',

        /// <summary>
        /// FSlashSmall
        /// </summary>
        ﾉ = FSlashSmall,

        /// <summary>
        /// ᛏ
        /// </summary>
        Up = 'ᛏ',

        /// <summary>
        /// Up
        /// </summary>
        ᛏ = Up,

        /// <summary>
        /// ᚾ
        /// </summary>
        PlusSlant = 'ᚾ',

        /// <summary>
        /// PlusSlant
        /// </summary>
        ᚾ = PlusSlant,

        ᛃ = 'ᛃ',

        /// <summary>
        /// ᛎ
        /// </summary>
        Down = 'ᛎ',

        /// <summary>
        /// Down
        /// </summary>
        ᛎ = Down,

        /// <summary>
        /// ॽ
        /// </summary>
        Q = 'ॽ',

        /// <summary>
        /// Q
        /// </summary>
        ॽ = Q,
        
        /// <summary>
        /// ᛜ
        /// </summary>
        Diamond = 'ᛜ',

        /// <summary>
        /// Diamond
        /// </summary>
        ᛜ = 'ᛜ' ,
        
        /// <summary>
        /// З
        /// </summary>
        Three = 'З',

        /// <summary>
        /// Three
        /// </summary>
        З = Three,

        /// <summary>
        /// ᛁ
        /// </summary>
        Pipe = 'ᛁ',

        ᛁ = Pipe,

        /// <summary>
        /// ǀ
        /// </summary>
        LeftPipe = 'ǀ',

        /// <summary>
        /// LeftPipe
        /// </summary>
        ǀ = LeftPipe,


        /// <summary>
        /// ヨ
        /// </summary>
        Exists = 'ヨ',

        /// <summary>
        /// Exists
        /// </summary>
        ヨ = Exists,        

        Box = 'ロ',

        /// <summary>
        /// Box
        /// </summary>
        ロ = Box,

        Contains = 'コ',

        /// <summary>
        /// Contains
        /// </summary>
        コ = Contains,

        /// <summary>
        /// є
        /// </summary>
        RightIn = 'є',        
    
        /// <summary>
        /// RightIn
        /// </summary>
        є = RightIn,
    
        /// <summary>
        /// э
        /// </summary>
        LeftIn = 'э',

        /// <summary>
        /// LeftIn
        /// </summary>
        э,

        Cap = 'П',

        /// <summary>
        /// Cap
        /// </summary>
        П = Cap,

        /// <summary>
        /// Π
        /// </summary>
        CapGreek = 'Π',

        /// <summary>
        /// CapGreek
        /// </summary>
        Π = CapGreek,
        
        /// <summary>
        /// α
        /// </summary>
        Alpha = 'α',

        /// <summary>
        /// alpha
        /// </summary>
        α = Alpha,

        Beta = 'β',

        /// <summary>
        /// beta
        /// </summary>
        β = Beta,  

        Gamma = 'γ',

        γ = Gamma,

        GammaUpper = 'Γ',

        /// <summary>
        /// GammaUpper
        /// </summary>
        Γ = GammaUpper,

        Epsilon = 'ε',

        /// <summary>
        /// Epsilon
        /// </summary>
        ε = Epsilon,

        DeltaEps = 'δ',

        /// <summary>
        /// DeltaEps
        /// </summary>
        δ = DeltaEps,

        Delta = 'Δ',

        /// <summary>
        /// Delta
        /// </summary>
        Δ = Delta,

        /// <summary>
        /// η
        /// </summary>
        Eta = 'η',

        /// <summary>
        /// Eta
        /// </summary>
        η = Eta,

        /// <summary>
        /// ω
        /// </summary>
        Omega = 'ω',

        /// <summary>
        /// Omega
        /// </summary>
        ω = Omega,

        /// <summary>
        /// Ω
        /// </summary>
        TheEnd = 'Ω',

        /// <summary>
        /// TheEnd
        /// </summary>
        Ω = TheEnd,

        /// <summary>
        /// λ
        /// </summary>
        Lambda = 'λ',

        /// <summary>
        /// Lambda
        /// </summary>
        λ = Lambda,

        Pi = 'π',

        /// <summary>
        /// Pi
        /// </summary>
        π = Pi,

        BigPi = 'ℿ',

        /// <summary>
        /// BigPi
        /// </summary>
        ℿ = BigPi,

        Mu = 'μ',

        /// <summary>
        /// Mu
        /// </summary>
        μ = Mu,

        /// <summary>
        /// 
        /// </summary>
        Psi = 'ψ',

        /// <summary>
        /// Psi
        /// </summary>
        ψ = Psi,
        
        Rho = 'ρ',

        /// <summary>
        /// Rho
        /// </summary>
        ρ = Rho,

        Sigma = 'σ',

        /// <summary>
        /// Sigma
        /// </summary>
        σ = Sigma,

        /// <summary>
        /// Sum
        /// </summary>
        Sum = 'Σ',

        /// <summary>
        /// 
        /// </summary>
        Σ = Sum,

        /// <summary>
        /// 
        /// </summary>
        Tau = 'τ',

        /// <summary>
        /// Tau
        /// </summary>
        τ = Tau,

        /// <summary>
        /// 
        /// </summary>
        Chi = 'χ',

        /// <summary>
        /// Chi
        /// </summary>
        χ = Chi,
    
        /// <summary>
        /// 
        /// </summary>
        Iota = 'ι',

        /// <summary>
        /// Iota
        /// </summary>
        ι = Iota,

        /// <summary>
        /// 
        /// </summary>
        OmicronUpper = 'Ο',

        /// <summary>
        /// OmicronUpper
        /// </summary>
        Ο = OmicronUpper,

        /// <summary>
        /// ν
        /// </summary>
        Nu = 'ν',

        /// <summary>
        /// Nu
        /// </summary>
        ν = Nu,

        /// <summary>
        /// ℕ
        /// </summary>
        Natural = 'ℕ',

        /// <summary>
        /// Natural
        /// </summary>
        ℕ = Natural,
                
        /// <summary>
        /// ℤ
        /// </summary>
        Integral = 'ℤ',

        /// <summary>
        /// Integral
        /// </summary>
        ℤ = Integral,

        /// <summary>
        /// ℝ
        /// </summary>
        Real = 'ℝ',

        /// <summary>
        /// Real
        /// </summary>
        ℝ = Real,

        /// <summary>
        /// ℚ
        /// </summary>
        Rational = 'ℚ',

        /// <summary>
        /// Rational
        /// </summary>
        ℚ = Rational,

        Prime ='ℙ',

        /// <summary>
        /// Prime
        /// </summary>
        ℙ = Prime,

        Complex = 'ℂ',

        /// <summary>
        /// Complex
        /// </summary>
        ℂ = Complex,

        /// <summary>
        /// Half (Quaternions)
        /// </summary>
        Half = 'ℍ',

        /// <summary>
        /// Half (Quaternions)
        /// </summary>
        ℍ = Half,

        /// <summary>
        /// ℵ
        /// </summary>
        Aleph = 'ℵ',

        /// <summary>
        /// Aleph
        /// </summary>
        ℵ = Aleph,

        Gimel = 'ℷ',

        /// <summary>
        /// Gimel
        /// </summary>
        ℷ,

        /// <summary>
        /// ⅆ
        /// </summary>
        DSmall = 'ⅆ',

        /// <summary>
        /// DSmall
        /// </summary>
        ⅆ = DSmall,
            
        /// <summary>
        /// ESmall
        /// </summary>
        ⅇ,

        /// <summary>
        /// ISmall
        /// </summary>
        ⅈ,

        /// <summary>
        /// IThick
        /// </summary>
        ℹ,
        
        /// <summary>
        /// ⅉ
        /// </summary>
        JSmall = 'ⅉ',

        /// <summary>
        /// JSmall
        /// </summary>
        ⅉ = JSmall,

        /// <summary>
        /// ℎ
        /// </summary>
        HSmall = 'ℎ',

        /// <summary>
        /// HSmall
        /// </summary>
        ℎ = HSmall,

        /// <summary>
        /// ο
        /// </summary>
        OSmall = 'ο',

        /// <summary>
        /// OSmall
        /// </summary>
        ο = OSmall,

        /// <summary>
        /// υ
        /// </summary>
        USmall = 'υ',

        /// <summary>
        /// USmall
        /// </summary>
        υ = USmall,                                        
    }
}