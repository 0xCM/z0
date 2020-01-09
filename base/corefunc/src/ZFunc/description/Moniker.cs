//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Linq;
    using System.Reflection;

    using static zfunc;

    public readonly struct Moniker
    {
        /// <summary>
        /// The moniker text
        /// </summary>
        public readonly string Text;

        /// <summary>
        /// The zero moniker
        /// </summary>
        public static Moniker Empty => new Moniker(string.Empty);

        [MethodImpl(Inline)]   
        public static Moniker parse(string text)
            => new Moniker(text);

        /// <summary>
        /// Produces a canonical designator of the form {bitsize(k)}{u | i | f} for a primal kind k
        /// </summary>
        /// <param name="k">The primal kind</param>
        [MethodImpl(Inline)]   
        public static string suffix(PrimalKind k)
            => $"{Classified.width(k)}{Classified.sign(k)}";

        /// <summary>
        /// Produces a canonical designator of the form {op}_{bitsize[T]}{u | i | f} for an operation over a primal type
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]   
        public static Moniker define(string opname, PrimalKind kind, bool generic = false)
            => generic ? new Moniker($"{opname}_g{suffix(kind)}") : new Moniker($"{opname}_{suffix(kind)}");

        /// <summary>
        /// Defines a moniker of the form {opname}_{w}X{bitsize(k)}{u | i | f} to identify an operation over a segmented type of bitwidth w over a primal kind k
        /// </summary>
        /// <param name="opname">The base operator name/operator classifier</param>
        /// <param name="w">The bit width</param>
        /// <param name="segkind">The primal cell kind</param>
        [MethodImpl(Inline)]   
        public static Moniker define<W>(string opname, PrimalKind segkind, W w)
            where W : unmanaged, ITypeNat
                => new Moniker($"{opname}_{w}{SegSep}{suffix(segkind)}");

        /// <summary>
        /// Defines a moniker of the form {opname}_{w}X{bitsize(k)}{u | i | f} to identify an operation over a segmented type of bitwidth w over a primal kind k
        /// </summary>
        /// <param name="opname">The base operator name/operator classifier</param>
        /// <param name="w">The bit width</param>
        /// <param name="segkind">The primal cell kind</param>
        [MethodImpl(Inline)]   
        public static Moniker define(string opname, int w, PrimalKind segkind, bool generic = false)
            => generic ? new Moniker($"{opname}_g{w}{SegSep}{suffix(segkind)}") : new Moniker($"{opname}_{w}{SegSep}{suffix(segkind)}");

        /// <summary>
        /// Makes a best-guess at defining an appropriate moniker for a specified method
        /// </summary>
        /// <param name="method">The operation method</param>
        public static Moniker define(MethodInfo method)
        {
            if(method.IsVectorOp())
                return Segmented(method);
            else if(method.IsPrimalOp())
                return Primal(method);
            else if(method.IsPredicate())
                return Predicate(method);
            else if(method.IsPrimalShift())
                return PrimalShift(method);
            else
                return new Moniker($"{method.Name}_{method.GetHashCode()}");
        }

        public static implicit operator string(Moniker src)
            => src.Text;

        [MethodImpl(Inline)]
        internal Moniker(string text)
            => this.Text = string.IsNullOrWhiteSpace(text) ? "00000" : text;
        
        public int PrimalWidth
        {
            [MethodImpl(Inline)]
            get => ParsePrimalWidth();
        }

        public PrimalKind PrimalKind
        {
            [MethodImpl(Inline)]
            get => ParseKind();
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => string.IsNullOrWhiteSpace(Text);
        }

        /// <summary>
        /// The unqualified operation name
        /// </summary>
        public string Name
            => Text.TakeBefore(OpSep);

        /// <summary>
        /// Indicates whether the operation is defined over a blocked/vectorized type
        /// </summary>
        public bool IsSegmented
            => Text.Contains(SegSep);

        /// <summary>
        /// Indicates whether the operation is defined over an unsigned integral domain
        /// </summary>
        public bool IsUnsignedInt
            => NumericIndicator == UIntIndicator;

        /// <summary>
        /// Indicates whether the operation is defined over a signed integral domain
        /// </summary>
        public bool IsSignedInt
            => NumericIndicator == SIntIndicator;

        /// <summary>
        /// Indicates whether the operation is defined over a floating-point domain
        /// </summary>
        public bool IsFloat
            => NumericIndicator == FloatIndicator; 

        /// <summary>
        /// Specifies whether the operation was reified from a generic definition 
        /// </summary>
        public bool IsGeneric
            => Text.TakeAfter(OpSep)[0] == GenericIndicator;

        public override string ToString()
            => Text;

        /// <summary>
        /// Derives a moniker for an operation over primal domain(s)
        /// </summary>
        /// <param name="method">The operation method</param>
        static Moniker Primal(MethodInfo method)
            => Moniker.define(method.Name, method.ReturnType.Kind(), method.IsConstructedGenericMethod);

        /// <summary>
        /// Derives a moniker for a predicate
        /// </summary>
        /// <param name="method">The operation method</param>
        static Moniker Predicate(MethodInfo method)
            => Moniker.define(method.Name, method.ParameterTypes().First().Kind(), method.IsConstructedGenericMethod);

        /// <summary>
        /// Derives a moniker for a predicate
        /// </summary>
        /// <param name="method">The operation method</param>
        static Moniker PrimalShift(MethodInfo method)
            => Moniker.define(method.Name, method.ParameterTypes().First().Kind(), method.IsConstructedGenericMethod);

        /// <summary>
        /// Derives a moniker for an operation over segmented domain(s)
        /// </summary>
        /// <param name="method">The operation method</param>
        static Moniker Segmented(MethodInfo method)
        {
            var v = method.ParameterTypes().First();       
            var segkind = v.GenericTypeArguments.FirstOrDefault().Kind();         
            return define(method.Name, v.BitWidth(), segkind, method.IsConstructedGenericMethod);                            
        }

        string Metrics
            => IsGeneric ? Text.TakeAfter(GenericIndicator) : Text.TakeAfter(OpSep);

        char NumericIndicator
        {
            [MethodImpl(Inline)]
            get => Text.Last();
        }

        PrimalKind ParseKind()
            => PrimalWidth switch{
                8 => IsUnsignedInt ? PrimalKind.U8 : PrimalKind.I8,
                16 => IsUnsignedInt ? PrimalKind.U16 : PrimalKind.I16,
                32 => IsFloat ? PrimalKind.F32 : (IsUnsignedInt ? PrimalKind.U32 : PrimalKind.I32),
                64 => IsFloat ? PrimalKind.F64 : (IsUnsignedInt ? PrimalKind.U64 : PrimalKind.I64),
                _ => PrimalKind.None
            };

        int ParsePrimalWidth()
        {
            var t = (IsSegmented ? Metrics.Split(SegSep)[1] : Metrics);
            var ss = t.Substring(0, t.Length - 1);
            if(int.TryParse(ss, out var n))
                return n;
            else 
                return 0;
        }

        const char SegSep = AsciLower.x;

        const char OpSep = AsciSym.Underscore;

        const char UIntIndicator = AsciLower.u;

        const char SIntIndicator = AsciLower.i;

        const char FloatIndicator = AsciLower.f;

        const char GenericIndicator = AsciLower.g;
    }
}