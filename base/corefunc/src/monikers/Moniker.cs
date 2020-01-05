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
            => $"{Primitive.bitsize(k)}{Primitive.indicator(k)}";

        /// <summary>
        /// Produces a canonical designator of the form {op}_{bitsize[T]}{u | i | f} for an operation over a primal type
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]   
        public static Moniker define(string opname, PrimalKind kind)
            => new Moniker($"{opname}_{suffix(kind)}");

        /// <summary>
        /// Defines a moniker of the form {opname}_{w}X{bitsize(k)}{u | i | f} to identify an operation 
        /// over a segmented type of bitwidth w over a primal kind k
        /// </summary>
        /// <param name="opname">The base operator name/operator classifier</param>
        /// <param name="w">The bit width</param>
        /// <param name="k">The primal cell kind</param>
        [MethodImpl(Inline)]   
        public static Moniker define<W>(string opname, PrimalKind k, W w)
            where W : unmanaged, ITypeNat
                => new Moniker($"{opname}_{w}{SegSep}{suffix(k)}");

        /// <summary>
        /// Makes a best-guess at defining an appropriate moniker for a specified method
        /// </summary>
        /// <param name="method">The operation method</param>
        public static Moniker define(MethodInfo method)
            => method.Vectorized() ? intrinsic(method) : primal(method);

        /// <summary>
        /// Derives a moniker for an operation over primal values
        /// </summary>
        /// <param name="method">The operation method</param>
        static Moniker primal(MethodInfo method)
        {
            var type = method.GetParameters().FirstOrDefault()?.ParameterType ?? method.ReturnType; 
            return Moniker.define(method.Name, type.Kind());
        }

        /// <summary>
        /// Derives a segmented moniker that identifies a vectorized intrinsic operation
        /// </summary>
        /// <param name="m">The operation method</param>
        static Moniker intrinsic(MethodInfo m)
        {
            var opname = m.Name;
            if(m.Vectorized())
            {
                var v = (from p in m.GetParameters()
                        where p.ParameterType.IsIntrinsicVector()
                        select p.ParameterType).FirstOrDefault() ?? m.ReturnType;
                
                var kind = v.GenericTypeArguments.FirstOrDefault().Kind();                
                var typedef = v.GetGenericTypeDefinition();

                if(typedef == typeof(Vector64<>))
                    return Moniker.define(opname, kind, n64);
                else if(typedef == typeof(Vector128<>))
                    return Moniker.define(opname, kind, n128);
                else if(typedef == typeof(Vector256<>))
                    return Moniker.define(opname, kind, n256);                
                else if(typedef == typeof(Vector512<>))
                    return Moniker.define(opname, kind, n512);                
                else if(typedef == typeof(Vector1024<>))
                    return Moniker.define(opname, kind, n1024);                
                else 
                    return Moniker.define(opname, kind, n0);
            }
            
            return Moniker.Empty;
        }

        public static implicit operator string(Moniker src)
            => src.Text;

        [MethodImpl(Inline)]
        internal Moniker(string text)
            => this.Text = string.IsNullOrWhiteSpace(text) ? "?" : text;
        
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

        public int? SegWidth
        {
            [MethodImpl(Inline)]
            get => ParseSegWidth();
        }

        public string OpName
            => Text.TakeBefore(OpSep);

        string Metrics
            => Text.TakeAfter(OpSep);

        public bool IsSegmented
            => Text.Contains(SegSep);

        public bool IsUnsignedInt
            => Indicator == UIntIndicator;

        public bool IsSignedInt
            => Indicator == SIntIndicator;

        public bool IsFloat
            => Indicator == FloatIndicator; 

        char Indicator
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

        int? ParseSegWidth()
        {
            var t = IsSegmented ? Metrics.Split(SegSep)[0] : string.Empty;

            if(t != string.Empty && int.TryParse(t, out var w))
                return w;
            else
                return null;                
        }

        int ParsePrimalWidth()
        {
            var t = (IsSegmented ? Metrics.Split(SegSep)[1] : Metrics);
            var ss = t.Substring(0, t.Length - 1);
            if(int.TryParse(ss, out var n))
                return n;
            else 
                return 0;
        }

        public override string ToString()
            => Text;

        static char SegSep => AsciLower.x;

        static char OpSep => AsciSym.Underscore;

        static char UIntIndicator = AsciLower.u;

        static char SIntIndicator = AsciLower.i;

        static char FloatIndicator = AsciLower.f;

    }
}